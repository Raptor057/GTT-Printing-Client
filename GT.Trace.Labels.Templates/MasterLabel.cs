using System;

namespace GT.Trace.Labels.Templates
{
    public partial class MasterLabel
    {
        public MasterLabel(string po, string julianDate, string customerPartNo, string revision, string partNo, string customer, string partDescription, DateTime date, int quantity, string lineName, long masterID, string approver, DateTime? approvalDate, string Origen)
        {
            InitializeComponent();

            var RS = Convert.ToChar(30);
            var GS = Convert.ToChar(29);
            var EOT = Convert.ToChar(4);
            POLabel.Text = po;
            JulianDateLabel.Text = julianDate;

            CustomerPartNoLabel.Text = customerPartNo;
            RevisionLabel.Text = revision;
            PartNoLabel.Text = partNo;
            CustomerLabel.Text = customer;
            PartDescriptionLabel.Text = partDescription;
            DateLabel.Text = date.ToString("dd-MMM-yyy HH:mm:ss");
            QuantityLabel.Text = quantity.ToString();
            LineNameLabel.Text = $"{lineName} \n {Origen}";
            //LineNameLabel.Text = $"{lineName}";
            FolioLabel.Text = $"M{masterID}";
            ApproverLabel.Text = approver;
            ApprovalDateLabel.Text = approvalDate?.ToString("dd-MMM-yy");
            SerialCodeLabel.Text = $"[)>{RS}06{GS}SM{masterID}{GS}P{customerPartNo}{GS}ZGT{GS}1T{partNo}2T{revision}Q{quantity}/{customer}/{partDescription}/{date}/{po}/{julianDate}{RS}{EOT}";
            QC.Visible = approvalDate.HasValue;
        }
    }
}