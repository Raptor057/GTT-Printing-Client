using GT.Trace.Labels.App;
using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using GT.Trace.Labels.App.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Infra.Services
{
    internal sealed class SignalRPackagingClient : SignalR.SignalRClient, IPackagingNotificationsService
    {
        private readonly LineCode _lineCode;

        private readonly ILabelGateway _labels;

        public SignalRPackagingClient(IConfigurationRoot configuration, IMessageBusService messageBus, LineCode lineCode, ILabelGateway labels)
            : base("Packaging Client", configuration, messageBus)
        {
            _lineCode = lineCode;
            _labels = labels;
        }

        public Task OnContainerComplete(string lineCode, string jsonData)
        {
            if (string.Compare(lineCode, _lineCode.Value, true) == 0)
            {
                ContainerJsonData junior = JsonConvert.DeserializeObject<ContainerJsonData>(jsonData);

                MessageBus.PassMessage("Etiqueta de contenedor lleno recibida.");
                DateTime date = DateTime.Now;
                _labels.SaveLabel(new JuniorLabelDto
                {
                    ApprovalDate = junior.ApprovalDate,
                    Approver = junior.Approver,
                    CreationTime = date,
                    Customer = junior.Customer,
                    CustomerPartNo = junior.CustomerPartNo,
                    Date = junior.Date,
                    JulianDate = junior.JulianDate,
                    LineCode = lineCode,
                    PartDescription = junior.PartDescription,
                    PartNo = junior.PartNo,
                    PurchaseOrderNo = junior.PurchaseOrderNo,
                    Quantity = junior.Quantity,
                    Revision = junior.Revision,
                    LineName = junior.LineName
                });
            }
            return Task.CompletedTask;
        }

        private class PalletJsonData
        {
            public string LineName { get; set; }

            public bool IsAteq { get; set; }

            public bool IsPartial { get; set; }

            public string PurchaseOrderNo { get; set; }

            public string JulianDate { get; set; }

            public string Customer { get; set; }

            public string CustomerPartNo { get; set; }

            public string PartNo { get; set; }

            public string Revision { get; set; }

            public string PartDescription { get; set; }

            public DateTime Date { get; set; }

            public string Approver { get; set; }

            public DateTime? ApprovalDate { get; set; }

            public long? MasterID { get; set; }

            public int Quantity { get; set; }
        }

        private class ContainerJsonData
        {
            public string LineName { get; set; }

            public string PurchaseOrderNo { get; set; }

            public string JulianDate { get; set; }

            public string Customer { get; set; }

            public string CustomerPartNo { get; set; }

            public string PartNo { get; set; }

            public string Revision { get; set; }

            public string PartDescription { get; set; }

            public DateTime Date { get; set; }

            public string Approver { get; set; }

            public DateTime? ApprovalDate { get; set; }

            public int Quantity { get; set; }
        }

        public Task OnPalletComplete(string lineCode, string jsonData)
        {
            if (string.Compare(lineCode, _lineCode.Value, true) == 0)
            {
                MessageBus.PassMessage("Etiqueta de tarima llena recibida.");
                PalletJsonData master = JsonConvert.DeserializeObject<PalletJsonData>(jsonData);
                DateTime date = DateTime.Now;
                if (master.IsPartial)
                {
                    _labels.SaveLabel(new PartialLabelDto
                    {
                        ApprovalDate = master.ApprovalDate,
                        Approver = master.Approver,
                        CreationTime = date,
                        Customer = master.Customer,
                        CustomerPartNo = master.CustomerPartNo,
                        Date = master.Date,
                        JulianDate = master.JulianDate,
                        LineCode = lineCode,
                        MasterID = master.MasterID,
                        PartDescription = master.PartDescription,
                        PartNo = master.PartNo,
                        PurchaseOrderNo = master.PurchaseOrderNo,
                        Quantity = master.Quantity,
                        Revision = master.Revision,
                        LineName = master.LineName
                    });
                }
                else if (master.IsAteq)
                {
                    _labels.SaveLabel(new AteqLabelDto
                    {
                        LineCode = lineCode,
                        ApprovalDate = master.ApprovalDate,
                        Approver = master.Approver,
                        CreationTime = date,
                        Customer = master.Customer,
                        CustomerPartNo = master.CustomerPartNo,
                        Date = master.Date,
                        JulianDate = master.JulianDate,
                        MasterID = master.MasterID,
                        PartDescription = master.PartDescription,
                        PartNo = master.PartNo,
                        PurchaseOrderNo = master.PurchaseOrderNo,
                        Quantity = master.Quantity,
                        Revision = master.Revision,
                        LineName = master.LineName
                    });
                }
                else
                {
                    _labels.SaveLabel(new MasterLabelDto
                    {
                        LineCode = lineCode,
                        ApprovalDate = master.ApprovalDate,
                        Approver = master.Approver,
                        CreationTime = date,
                        Customer = master.Customer,
                        CustomerPartNo = master.CustomerPartNo,
                        Date = master.Date,
                        JulianDate = master.JulianDate,
                        MasterID = master.MasterID,
                        PartDescription = master.PartDescription,
                        PartNo = master.PartNo,
                        PurchaseOrderNo = master.PurchaseOrderNo,
                        Quantity = master.Quantity,
                        Revision = master.Revision,
                        LineName = master.LineName
                    });
                }
            }
            return Task.CompletedTask;
        }

        public Task OnUnitPicked(string lineCode, long unitID)
        {
            if (string.Compare(lineCode, _lineCode.Value, true) == 0)
            {
                MessageBus.PassMessage("Etiqueta de picking de pruebas recibida.");
                DateTime date = DateTime.Now;
                _labels.SaveLabel(new PickingLabelDto
                {
                    CreationTime = date,
                    LineCode = lineCode,
                    ProtoID = unitID,
                    Quantity = 1,
                    UnitID = unitID
                });
            }
            return Task.CompletedTask;
        }

        public Task OnWip(string lineCode, string jsonData)
        {
            if (string.Compare(lineCode, _lineCode.Value, true) == 0)
            {
                MessageBus.PassMessage("Etiqueta WIP recibida.");
                PalletJsonData pallet = JsonConvert.DeserializeObject<PalletJsonData>(jsonData);
                _labels.SaveLabel(new WipLabelDto
                {
                    ApprovalDate = pallet.ApprovalDate,
                    Approver = pallet.Approver,
                    CreationTime = DateTime.Now,
                    Customer = pallet.Customer,
                    CustomerPartNo = pallet.CustomerPartNo,
                    Date = pallet.Date,
                    JulianDate = pallet.JulianDate,
                    LastPrintingSuccessStatus = null,
                    LastPrintingTime = null,
                    LineCode = lineCode,
                    PartDescription = pallet.PartDescription,
                    PartNo = pallet.PartNo,
                    PurchaseOrderNo = pallet.PurchaseOrderNo,
                    Quantity = pallet.Quantity,
                    Revision = pallet.Revision,
                    LineName = pallet.LineName
                });
            }
            return Task.CompletedTask;
        }

        public async Task StartAsync()
        {
            On<string, long>("UnitPicked", OnUnitPicked);
            On<string, string>("PalletComplete", OnPalletComplete);
            On<string, string>("ContainerComplete", OnContainerComplete);
            On<string, string>("PrintWip", OnWip);
            await Start().ConfigureAwait(false);
        }
    }
}