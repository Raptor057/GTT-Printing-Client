using System;

namespace GT.Trace.Labels.Templates
{
    public partial class KitSavLabel
    {
        public KitSavLabel(string customerPartNo, string partNo,string partDescription, string www)
        {
            InitializeComponent();

            CustomerPartNoLabel.Text = customerPartNo;
            PartNoLabel.Text = partNo;
            PartDescriptionLabel.Text = partDescription;
            SerialCodeLabel.Text = $"{www}";
        }
    }
}