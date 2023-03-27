using System;

namespace GT.Trace.Labels.Templates
{
    public partial class SubAssemblyEtiLabel : LabelBase
    {
        public SubAssemblyEtiLabel(long etiID, string partNo, string revision, string partDescription, int quantity, DateTime creationTime)
        {
            InitializeComponent();

            EtiIDLabel.Text = $"SA{etiID:00000000}";
            PartNoLabel.Text = partNo;
            RevisionLabel.Text = revision;
            PartDescriptionLabel.Text = partDescription;

            MfgDateLabel.Text = creationTime.ToString("dd-MMM-yy hh:mm tt").ToUpper();
            LotNoLabel.Text = $"{creationTime.Year}{creationTime.DayOfYear:000}-{etiID:00000000}";

            SupplierLabel.Text = "GT";// e.supplier;
            //txtLotBarCode.Text = txtLot.Text;
            QuantityLabel.Text = quantity.ToString();
            accountEmpl.Text = "";// new BussinessLogic.UserController().GetUser(e.created_by).user;
            //Prev Rev
            //if (e.pre_rev != null)
            //{
            //    txtRevAnt.Visible = true;
            //    txtRevBy.Visible = true;

            //    txtRevAnt.Text = e.pre_rev.TrimEnd();
            //    txtRevBy.Text = lu.Where(w => w.id_user
            //    .Equals(e.id_user_changed_rev)).First().user;
            //}
            printedText.Text = MfgDateLabel.Text;

            ShowPrintMarginsWarning = false;
        }
    }
}