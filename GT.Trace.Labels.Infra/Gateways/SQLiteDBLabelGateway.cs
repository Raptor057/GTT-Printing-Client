using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using GT.Trace.Labels.Infra.DataStores.SqlDB;
using GT.Trace.Labels.Infra.DataStores.SqlDB.Entities;
using GT.Trace.Labels.Infra.Extensions;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GT.Trace.Labels.Infra.Gateways
{
    internal sealed class SQLiteDBLabelGateway : ILabelGateway
    {
        private readonly ISQLiteDBConnectionFactory _connections;

        public SQLiteDBLabelGateway(ISQLiteDBConnectionFactory connections)
        {
            _connections = connections;
            using (SQLiteConnection con = _connections.GetOpenConnection())
            {
                _ = con.CreateTable<Label>();
                _ = con.CreateTable<ContainerLabel>();
                _ = con.CreateTable<ReturnLabel>();
                _ = con.CreateTable<PickingLabel>();
                _ = con.CreateTable<SubAssemblyLabel>();
                if (con.GetTableInfo(nameof(LabelType))?.Count == 0)
                {
                    _ = con.CreateTable<LabelType>();
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Ateq, Name = "ATEQ" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Individual, Name = "Individual" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Junior, Name = "Junior" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Master, Name = "Master" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Partial, Name = "Parcial" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Picking, Name = "Picking" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Return, Name = "Retorno" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.SubAssembly, Name = "Sub Ensamble" });
                    _ = con.Insert(new LabelType { LabelTypeID = (int)LabelTypes.Wip, Name = "WIP" });
                }
            }
        }

        public IEnumerable<LabelDto> FetchLabelsWithFailure()
        {
            using (SQLiteConnection con = _connections.GetOpenConnection())
            {
                return con.Table<Label>()
                    .Where(item => item.LastUtcPrintingTime != null && (!(item.LastPrintingSuccessStatus ?? false)))
                    .Select(item => item.ToDto())
                    .ToList();
            }
        }

        public IEnumerable<LabelDto> FetchNewLabels()
        {
            using (SQLiteConnection con = _connections.GetOpenConnection())
            {
                return con.Table<Label>()
                    .Where(item => item.LastUtcPrintingTime == null)
                    .Select(item => item.ToDto())
                    .ToList();
            }
        }

        public IEnumerable<LabelDto> Find(DateTime date, IEnumerable<LabelTypes> labelTypes)
        {
            DateTime dateA = date.ToUniversalTime().Date;
            DateTime dateB = dateA.AddDays(1);
            IEnumerable<int> labelTypeIDs = labelTypes.Select(t => (int)t);

            using (SQLiteConnection con = _connections.GetOpenConnection())
            {
                return con.Table<Label>()
                    .Where(item => item.LastUtcPrintingTime != null)
                    .Where(item => dateA <= item.UtcCreationTime && item.UtcCreationTime < dateB)
                    .Where(item => labelTypeIDs.Contains(item.LabelTypeID))
                    .ToList()
                    .Select(item => item.ToDto());
            }
        }

        public object FindLabel(long labelID)
        {
            using (SQLiteConnection con = _connections.GetOpenConnection())
            {
                Label label = con.Table<Label>().FirstOrDefault(item => item.LabelID == labelID);
                if (label == null)
                {
                    return null;
                }
                LabelTypes labelType = (LabelTypes)label.LabelTypeID;
                switch (labelType)
                {
                    case LabelTypes.Ateq:
                    case LabelTypes.Junior:
                    case LabelTypes.Master:
                    case LabelTypes.Partial:
                    case LabelTypes.Wip:
                        ContainerLabel container = con.Table<ContainerLabel>().FirstOrDefault(item => item.LabelID == labelID);
                        switch (labelType)
                        {
                            case LabelTypes.Ateq:
                                return new AteqLabelDto
                                {
                                    ApprovalDate = container.ApprovalDate,
                                    Approver = container.Approver,
                                    CreationTime = label.UtcCreationTime.ToLocalTime(),
                                    Customer = container.Customer,
                                    CustomerPartNo = container.CustomerPartNo,
                                    Date = container.Date,
                                    JulianDate = container.JulianDate,
                                    LabelID = labelID,
                                    LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                                    LastPrintingTime = label.LastUtcPrintingTime,
                                    LineCode = label.LineCode,
                                    PartDescription = container.PartDescription,
                                    Revision = container.Revision,
                                    PartNo = container.PartNo,
                                    PurchaseOrderNo = container.PurchaseOrderNo,
                                    Quantity = label.Quantity,
                                    MasterID = container.MasterID,
                                    LineName = label.LineName
                                    
                                };

                            case LabelTypes.Junior:
                                return new JuniorLabelDto
                                {
                                    ApprovalDate = container.ApprovalDate,
                                    Approver = container.Approver,
                                    CreationTime = label.UtcCreationTime.ToLocalTime(),
                                    Customer = container.Customer,
                                    CustomerPartNo = container.CustomerPartNo,
                                    Date = container.Date,
                                    JulianDate = container.JulianDate,
                                    LabelID = labelID,
                                    LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                                    LastPrintingTime = label.LastUtcPrintingTime,
                                    LineCode = label.LineCode,
                                    PartDescription = container.PartDescription,
                                    PartNo = container.PartNo,
                                    PurchaseOrderNo = container.PurchaseOrderNo,
                                    Quantity = label.Quantity,
                                    Revision = container.Revision,
                                    LineName = label.LineName
                                };

                            case LabelTypes.Master:
                                return new MasterLabelDto
                                {
                                    ApprovalDate = container.ApprovalDate,
                                    Approver = container.Approver,
                                    CreationTime = label.UtcCreationTime.ToLocalTime(),
                                    Customer = container.Customer,
                                    CustomerPartNo = container.CustomerPartNo,
                                    Date = container.Date,
                                    JulianDate = container.JulianDate,
                                    LabelID = labelID,
                                    LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                                    LastPrintingTime = label.LastUtcPrintingTime,
                                    LineCode = label.LineCode,
                                    PartDescription = container.PartDescription,
                                    PartNo = container.PartNo,
                                    PurchaseOrderNo = container.PurchaseOrderNo,
                                    Quantity = label.Quantity,
                                    Revision = container.Revision,
                                    MasterID = container.MasterID.Value,
                                    LineName = label.LineName,
                                    Origen = label.Origen //Se agrego Campo Origen Faltante RA: 04 / 19 /2023

                                };

                            case LabelTypes.Partial:
                                return new PartialLabelDto
                                {
                                    ApprovalDate = container.ApprovalDate,
                                    Approver = container.Approver,
                                    CreationTime = label.UtcCreationTime.ToLocalTime(),
                                    Customer = container.Customer,
                                    CustomerPartNo = container.CustomerPartNo,
                                    Date = container.Date,
                                    JulianDate = container.JulianDate,
                                    LabelID = labelID,
                                    LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                                    LastPrintingTime = label.LastUtcPrintingTime,
                                    LineCode = label.LineCode,
                                    PartDescription = container.PartDescription,
                                    PartNo = container.PartNo,
                                    PurchaseOrderNo = container.PurchaseOrderNo,
                                    Quantity = label.Quantity,
                                    Revision = container.Revision,
                                    MasterID = container.MasterID.Value,
                                    LineName = label.LineName
                                };

                            case LabelTypes.Wip:
                                return new WipLabelDto
                                {
                                    ApprovalDate = container.ApprovalDate,
                                    Approver = container.Approver,
                                    CreationTime = label.UtcCreationTime.ToLocalTime(),
                                    Customer = container.Customer,
                                    CustomerPartNo = container.CustomerPartNo,
                                    Date = container.Date,
                                    JulianDate = container.JulianDate,
                                    LabelID = labelID,
                                    LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                                    LastPrintingTime = label.LastUtcPrintingTime,
                                    LineCode = label.LineCode,
                                    PartDescription = container.PartDescription,
                                    PartNo = container.PartNo,
                                    PurchaseOrderNo = container.PurchaseOrderNo,
                                    Quantity = label.Quantity,
                                    Revision = container.Revision,
                                    LineName = label.LineName
                                };
                        }
                        break;

                    case LabelTypes.Picking:
                        PickingLabel picking = con.Table<PickingLabel>().FirstOrDefault(item => item.LabelID == labelID);
                        return new PickingLabelDto
                        {
                            CreationTime = label.UtcCreationTime.ToLocalTime(),
                            LabelID = label.LabelID,
                            LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                            LastPrintingTime = label.LastUtcPrintingTime,
                            LineCode = label.LineCode,
                            Quantity = label.Quantity,
                            UnitID = picking.UnitID,
                            ProtoID = picking.ProtoID
                        };

                    case LabelTypes.Return:
                        ReturnLabel returnLabel = con.Table<ReturnLabel>().FirstOrDefault(item => item.LabelID == labelID);
                        return new ReturnLabelDto
                        {
                            CreationTime = label.UtcCreationTime.ToLocalTime(),
                            LabelID = label.LabelID,
                            LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                            LastPrintingTime = label.LastUtcPrintingTime,
                            LineCode = label.LineCode,
                            Quantity = label.Quantity,
                            ComponentNo = returnLabel.ComponentNo,
                            EmployeeName = returnLabel.EmployeeName,
                            EtiNo = returnLabel.EtiNo,
                            PointOfUseCode = returnLabel.PointOfUseCode,
                        };

                    case LabelTypes.SubAssembly:
                        SubAssemblyLabel subAssembly = con.Table<SubAssemblyLabel>().FirstOrDefault(item => item.LabelID == labelID);
                        return new SubAssemblyLabelDto
                        {
                            CreationTime = label.UtcCreationTime.ToLocalTime(),
                            LabelID = label.LabelID,
                            LastPrintingSuccessStatus = label.LastPrintingSuccessStatus,
                            LastPrintingTime = label.LastUtcPrintingTime,
                            LineCode = label.LineCode,
                            Quantity = label.Quantity,
                            PartDescription = subAssembly.PartDescription,
                            Revision = subAssembly.Revision,
                            PartNo = subAssembly.PartNo,
                            EtiID = subAssembly.EtiID
                        };
                }
            }
            return null;
        }

        public bool SaveLabel<T>(T label)
        {
            using (SQLiteConnection con = _connections.GetOpenConnection())
            {
                con.BeginTransaction();
                if (label is LabelDto baseLabel)
                {
                    Label dbLabel = new Label
                    {
                        UtcCreationTime = baseLabel.CreationTime.ToUniversalTime(),
                        LabelID = baseLabel.LabelID,
                        LastPrintingSuccessStatus = baseLabel.LastPrintingSuccessStatus,
                        LastUtcPrintingTime = baseLabel.LastPrintingTime?.ToUniversalTime(),
                        LineCode = baseLabel.LineCode,
                        LineName = baseLabel.LineName,
                        Quantity = baseLabel.Quantity,
                        LabelTypeID = (int)baseLabel.Type,
                        Origen = baseLabel.Origen //se agrego esto a ver si jala, la verdad no lo se
                        //Update: esto si jalo.
                    };
                    _ = con.Insert(dbLabel);
                    baseLabel.LabelID = dbLabel.LabelID;
                    //(label as LabelDto).LabelID = dbLabel.LabelID;
                }

                if (label is ContainerLabelDto container)
                {
                    _ = con.Insert(new ContainerLabel
                    {
                        ApprovalDate = container.ApprovalDate,
                        Approver = container.Approver,
                        Customer = container.Customer,
                        CustomerPartNo = container.CustomerPartNo,
                        Date = container.Date,
                        JulianDate = container.JulianDate,
                        LabelID = container.LabelID,
                        PartDescription = container.PartDescription,
                        PartNo = container.PartNo,
                        PurchaseOrderNo = container.PurchaseOrderNo,
                        Revision = container.Revision,
                        MasterID = container.MasterID
                    });
                }
                else if (label is PickingLabelDto picking)
                {
                    _ = con.Insert(new PickingLabel
                    {
                        LabelID = picking.LabelID,
                        ProtoID = picking.ProtoID,
                        UnitID = picking.UnitID
                    });
                }
                else if (label is ReturnLabelDto returnLabel)
                {
                    _ = con.Insert(new ReturnLabel
                    {
                        ComponentNo = returnLabel.ComponentNo,
                        EmployeeName = returnLabel.EmployeeName,
                        EtiNo = returnLabel.EtiNo,
                        LabelID = returnLabel.LabelID,
                        PointOfUseCode = returnLabel.PointOfUseCode
                    });
                }
                else if (label is SubAssemblyLabelDto subAssemblyLabel)
                {
                    _ = con.Insert(new SubAssemblyLabel
                    {
                        LabelID = subAssemblyLabel.LabelID,
                        PartDescription = subAssemblyLabel.PartDescription,
                        PartNo = subAssemblyLabel.PartNo,
                        Revision = subAssemblyLabel.Revision,
                        EtiID = subAssemblyLabel.EtiID
                    });
                }
                con.Commit();
            }
            return true;
        }

        public bool UpdateLabelPrintingStatus(long labelID, bool isSuccess)
        {
            using (SQLiteConnection con = _connections.GetOpenConnection())
            {
                Label label = con.Get<Label>(labelID);
                if (label == null)
                {
                    return false;
                }
                label.LastPrintingSuccessStatus = isSuccess;
                label.LastUtcPrintingTime = DateTime.UtcNow;
                return con.Update(label) > 0;
            }
        }
    }
}