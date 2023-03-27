using System;

namespace GT.Trace.Labels.Templates
{
    public partial class WipLabel
    {
        public WipLabel(string po, string julianDate, string customerPartNo, string revision, string partNo, string destination, string partDescription, DateTime date, int quantity, string lineName, long masterID, bool isPartial, bool isWip, bool isAteq)
        {
            InitializeComponent();

            JulianDateLabel.Text = julianDate;
            POLabel.Text = po;
            CustomerPartNoLabel.Text = customerPartNo;
            RevisionLabel.Text = revision;
            PartNoLabel.Text = partNo;
            DestinationLabel.Text = destination;
            PartDescriptionLabel.Text = partDescription;
            DateLabel.Text = date.ToString("dd-MMM-yyy HH:mm:ss");
            QuantityLabel.Text = quantity.ToString();
            LineNameLabel.Text = lineName;
            if (isWip)
            {
                picwip.Visible = true;
                FolioLabel.Visible = false;
            }
            else if (isPartial)
            {
                picpartial.Visible = true;
                FolioLabel.Text = $"M{masterID}";
            }
            else if (isAteq)
            {
                RestPicture.Visible = true;
                FolioLabel.Text = $"M{masterID}";
            }
        }
    }
}