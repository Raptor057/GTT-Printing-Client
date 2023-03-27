using Dapper;
using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Notifications.UseCases.ParseContainerComplete;
using GT.Trace.Labels.App.Persistence.UseCases.AddJuniorLabel;
using GT.Trace.Labels.Templates.UseCases.PrintJuniorLabel;
using GT.Trace.Labels.Templates.UseCases.PrintMasterLabel;
using GT.Trace.Labels.Templates.UseCases.PrintPickingLabel;
using GT.Trace.Labels.Templates.UseCases.PrintReturnLabel;
using GT.Trace.Labels.Templates.UseCases.PrintWipLabel;
using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GT.Trace.PrintingCompanion.SignalR
{
    public sealed class PackagingSignalRClient : SignalRClient
    {
        private readonly IMediator _mediator;

        public PackagingSignalRClient(IConfigurationRoot configuration, Notifications notifications, IMediator mediator)
            : base("Packaging Client", configuration, notifications)
        {
            _mediator = mediator;
        }

        public override async Task Start()
        {
            On<string, long>("UnitPicked", OnUnitPicked);
            On<string, long>("PalletComplete", OnPalletComplete);
            On<string, string>("ContainerComplete", OnContainerComplete);
            On<string>("PrintWip", OnWip);
            await base.Start().ConfigureAwait(false);
        }

        private Task OnUnitPicked(string lineCode, long unitID)
        {
            Notifications.Add($"Mensaje recibido: unidad seleccionada para pruebas {lineCode} / WB{unitID}.");
            if (string.Compare(LineCode, lineCode, true) != 0) return Task.CompletedTask;

            var request = new PrintPickingLabelRequest
            {
                LineCode = lineCode,
                ProtoID = -1,
                UnitID = unitID
            };

            return Task.CompletedTask;
        }

        private Task OnPalletComplete(string lineCode, long masterID)
        {
            Notifications.Add($"Mensaje recibido: tarima llena {lineCode} / M{masterID}.");
            if (string.Compare(LineCode, lineCode, true) != 0)
            {
                return Task.CompletedTask;
            }

            dynamic master;
            using (var con = new SqlConnection("server=mxsrvtraca;database=trazab;uid=sa;pwd=cegid.2008;"))
            {
                master = con.QuerySingle("SELECT * FROM Master_Labels_WB WHERE id = @id;", new { id = masterID });
            }

            if (!master.is_active)
            {
                Notifications.Add($"M{masterID} no se encuentra activa.");
            }
            else if (master.is_partial)
            {
                PrintWipLabelRequest request = new PrintWipLabelRequest
                {
                    LineCode = lineCode,
                    ApprovalDate = master.aprov_date,
                    Approver = master.aprov_user,
                    Customer = master.customer,
                    CustomerPartNo = master.cust_pn,
                    Date = DateTime.Parse($"{master.fecha} {master.Hora}"),
                    JulianDate = master.juliano,
                    MasterID = masterID,
                    PartDescription = master.description,
                    PartNo = master.part_num,
                    PO = master.po_num,
                    Quantity = master.qty,
                    Revision = master.rev,
                    IsPartial = true
                };
                //Notifications.Raise("OnWip", request);
            }
            else if (string.Compare(master.master_type, "ateq", true) == 0)
            {
                PrintWipLabelRequest request = new PrintWipLabelRequest
                {
                    LineCode = lineCode,
                    ApprovalDate = DateTime.Parse(master.aprov_date),
                    Approver = master.aprov_user,
                    Customer = master.customer,
                    CustomerPartNo = master.cust_pn,
                    Date = DateTime.Parse($"{master.fecha} {master.Hora}"),
                    JulianDate = master.juliano,
                    MasterID = masterID,
                    PartDescription = master.description,
                    PartNo = master.part_num,
                    PO = master.po_num,
                    Quantity = master.qty,
                    Revision = master.rev,
                    IsAteq = true
                };
                //Notifications.Raise("OnWip", request);
            }
            else
            {
                PrintMasterLabelRequest request = new PrintMasterLabelRequest
                {
                    ApprovalDate = master.aprov_date,
                    Approver = master.aprov_user,
                    Customer = master.customer,
                    CustomerPartNo = master.cust_pn,
                    Date = DateTime.Parse($"{master.fecha} {master.Hora}"),
                    JulianDate = master.juliano,
                    LineCode = lineCode,
                    MasterID = masterID,
                    PartDescription = master.description,
                    PartNo = master.part_num,
                    PO = master.po_num,
                    Quantity = master.qty,
                    Revision = master.rev
                };
                //Notifications.Raise("OnPalletComplete", request);
            }
            return Task.CompletedTask;
        }

        private async Task OnContainerComplete(string lineCode, string jsonData)
        {
            if (string.Compare(LineCode, lineCode, true) == 0)
            {
                Notifications.Add($"Mensaje recibido: contenedor lleno {lineCode}.");
                var request = new ParseContainerCompleteRequest(jsonData);
                await _mediator.Send(request).ConfigureAwait(false);
            }
        }

        private Task OnWip(string lineCode)
        {
            Notifications.Add($"Mensaje recibido: trabajo en progreso WIP {lineCode}.");
            if (string.Compare(LineCode, lineCode, true) != 0)
            {
                return Task.CompletedTask;
            }

            dynamic pro_production, pro_prod_unit, tempContainer;
            using (var con = new SqlConnection("server=mxsrvtraca;database=apps;uid=sa;pwd=cegid.2008;"))
            {
                pro_prod_unit = con.QuerySingle("SELECT * FROM dbo.pro_prod_units WHERE letter = @lineCode;", new { lineCode });
                pro_production = con.QuerySingleOrDefault("SELECT TOP 1 * FROM dbo.pro_production WHERE id_line=@id AND codew = @codew ORDER BY last_update_time DESC;", (object)pro_prod_unit);
                tempContainer = con.QuerySingleOrDefault("SELECT COUNT(*) [Quantity], MAX(Aproved) [ApprovalID] FROM TRAZAB.dbo.Temp_pack_WB WHERE linea=@comments and num_p=@modelo;", (object)pro_prod_unit);
            }

            PrintWipLabelRequest request = new PrintWipLabelRequest
            {
                LineCode = lineCode,
                //ApprovalDate = master.aprov_date,
                //Approver = master.aprov_user,
                Customer = pro_production.client_name,
                CustomerPartNo = pro_production.ref_ext,
                Date = DateTime.Now,
                JulianDate = $"{DateTime.Now.Year - 2000}{DateTime.Now.DayOfYear:000}",
                PartDescription = pro_production.part_desc,
                PartNo = pro_production.part_number,
                PO = "PO#",
                Quantity = tempContainer.Quantity,
                Revision = pro_production.rev,
                IsWip = true
            };

            return Task.CompletedTask;
        }
    }
}