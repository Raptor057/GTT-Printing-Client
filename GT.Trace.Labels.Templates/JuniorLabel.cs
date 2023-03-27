using System;

namespace GT.Trace.Labels.Templates
{
    public partial class JuniorLabel
    {
        public JuniorLabel(string po, string julianDate, string customerPartNo, string revision, string partNo, string customer, string partDescription, DateTime date, int quantity, string lineName, long masterID, string approver, DateTime? approvalDate)
        {
            InitializeComponent();

            char RS = Convert.ToChar(30);
            char GS = Convert.ToChar(29);
            char EOT = Convert.ToChar(4);
            POLabel.Text = po;
            JulianDateLabel.Text = julianDate;
            CustomerPartNoLabel.Text = customerPartNo;
            RevisionLabel.Text = revision;
            PartNoLabel.Text = partNo;
            CustomerLabel.Text = customer;
            PartDescriptionLabel.Text = partDescription;
            DateLabel.Text = date.ToString("dd-MMM-yyy HH:mm:ss");
            QuantityLabel.Text = quantity.ToString();
            LineNameLabel.Text = lineName;
            ApproverLabel.Text = approver;
            ApprovalDateLabel.Text = approvalDate?.ToString("dd-MMM-yy");
            SerialCodeLabel.Text = $"[)>{RS}06{GS}SM{masterID}{GS}P{customerPartNo}{GS}ZGT{GS}1T{partNo}2T{revision}Q{quantity}/{customer}/{partDescription}/{date}/{po}/{julianDate}{RS}{EOT}";
            QC.Visible = approvalDate.HasValue;
        }
    }
}