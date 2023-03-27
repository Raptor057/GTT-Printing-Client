using System;

namespace GT.Trace.PrintingCompanion.Labels
{
    public partial class WipLabel
    {
        public WipLabel(string po, string julianDate, string customerPartNo, string revision, string partNo, string customer, string partDescription, DateTime date, int quantity, string lineCode, long masterID)
        {
            InitializeComponent();

            POLabel.Text = po;
            JulianDateLabel.Text = julianDate;
            CustomerPartNoLabel.Text = customerPartNo;
            RevisionLabel.Text = revision;
            PartNoLabel.Text = partNo;
            CustomerLabel.Text = customer;
            PartDescriptionLabel.Text = partDescription;
            DateLabel.Text = date.ToString("dd-MMM-yyyy");
            QuantityLabel.Text = quantity.ToString();
            LineCodeLabel.Text = lineCode;
            FolioLabel.Text = $"M{masterID}";
            RestPicture.Visible = true;
        }
    }
}