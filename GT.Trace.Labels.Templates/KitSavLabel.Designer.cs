using System.Windows.Forms;

namespace GT.Trace.Labels.Templates
{
    public partial class KitSavLabel : LabelBase
    {

        // XtraReport overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        // Required by the Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Designer
        // It can be modified using the Designer.  
        // Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SerialCodeLabel = new DevExpress.XtraReports.UI.XRBarCode();
            this.WinControlContainer23 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label20 = new System.Windows.Forms.Label();
            this.WinControlContainer17 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label14 = new System.Windows.Forms.Label();
            this.WinControlContainer15 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PartDescriptionLabel = new System.Windows.Forms.Label();
            this.WinControlContainer13 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer10 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label6 = new System.Windows.Forms.Label();
            this.WinControlContainer9 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label5 = new System.Windows.Forms.Label();
            this.WinControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.CustomerPartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label1 = new System.Windows.Forms.Label();
            this.WinControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.SerialCodeLabel,
            this.WinControlContainer23,
            this.WinControlContainer17,
            this.WinControlContainer15,
            this.WinControlContainer13,
            this.WinControlContainer10,
            this.WinControlContainer9,
            this.WinControlContainer3,
            this.WinControlContainer2,
            this.WinControlContainer1});
            this.Detail.HeightF = 390.6251F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SerialCodeLabel
            // 
            this.SerialCodeLabel.AutoModule = true;
            this.SerialCodeLabel.LocationFloat = new DevExpress.Utils.PointFloat(170.8333F, 177.9167F);
            this.SerialCodeLabel.Name = "SerialCodeLabel";
            this.SerialCodeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.SerialCodeLabel.ShowText = false;
            this.SerialCodeLabel.SizeF = new System.Drawing.SizeF(214.8883F, 181.0834F);
            this.SerialCodeLabel.Symbology = qrCodeGenerator1;
            this.SerialCodeLabel.Text = "M15157";
            // 
            // WinControlContainer23
            // 
            this.WinControlContainer23.LocationFloat = new DevExpress.Utils.PointFloat(451.9451F, 346F);
            this.WinControlContainer23.Name = "WinControlContainer23";
            this.WinControlContainer23.SizeF = new System.Drawing.SizeF(94.05505F, 13.00003F);
            this.WinControlContainer23.WinControl = this.Label20;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.White;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(371, 219);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(90, 12);
            this.Label20.TabIndex = 161;
            this.Label20.Text = "ETI 000 Rev. X";
            // 
            // WinControlContainer17
            // 
            this.WinControlContainer17.LocationFloat = new DevExpress.Utils.PointFloat(100.1894F, 108.5F);
            this.WinControlContainer17.Name = "WinControlContainer17";
            this.WinControlContainer17.SizeF = new System.Drawing.SizeF(359.0208F, 69.41665F);
            this.WinControlContainer17.WinControl = this.Label14;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(371, 219);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(345, 67);
            this.Label14.TabIndex = 161;
            this.Label14.Text = "SCAN ME FOR REPAIR INSTRUCTIONS";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer15
            // 
            this.WinControlContainer15.LocationFloat = new DevExpress.Utils.PointFloat(332.6061F, 85.50002F);
            this.WinControlContainer15.Name = "WinControlContainer15";
            this.WinControlContainer15.SizeF = new System.Drawing.SizeF(126.604F, 23F);
            this.WinControlContainer15.WinControl = this.PartDescriptionLabel;
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.Location = new System.Drawing.Point(371, 219);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(122, 22);
            this.PartDescriptionLabel.TabIndex = 161;
            this.PartDescriptionLabel.Text = "TRANSMISION";
            this.PartDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer13
            // 
            this.WinControlContainer13.LocationFloat = new DevExpress.Utils.PointFloat(332.6061F, 49.04167F);
            this.WinControlContainer13.Name = "WinControlContainer13";
            this.WinControlContainer13.SizeF = new System.Drawing.SizeF(126.604F, 23F);
            this.WinControlContainer13.WinControl = this.PartNoLabel;
            // 
            // PartNoLabel
            // 
            this.PartNoLabel.BackColor = System.Drawing.Color.White;
            this.PartNoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNoLabel.Location = new System.Drawing.Point(22, 303);
            this.PartNoLabel.Name = "PartNoLabel";
            this.PartNoLabel.Size = new System.Drawing.Size(122, 22);
            this.PartNoLabel.TabIndex = 159;
            this.PartNoLabel.Text = "GT123456";
            this.PartNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer10
            // 
            this.WinControlContainer10.LocationFloat = new DevExpress.Utils.PointFloat(100.1894F, 85.50002F);
            this.WinControlContainer10.Name = "WinControlContainer10";
            this.WinControlContainer10.SizeF = new System.Drawing.SizeF(232.4167F, 23F);
            this.WinControlContainer10.WinControl = this.Label6;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label6.Location = new System.Drawing.Point(22, 303);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(223, 22);
            this.Label6.TabIndex = 159;
            this.Label6.Text = "DESCRIPTION:";
            // 
            // WinControlContainer9
            // 
            this.WinControlContainer9.LocationFloat = new DevExpress.Utils.PointFloat(100.1894F, 49.04167F);
            this.WinControlContainer9.Name = "WinControlContainer9";
            this.WinControlContainer9.SizeF = new System.Drawing.SizeF(232.4167F, 23F);
            this.WinControlContainer9.WinControl = this.Label5;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(22, 303);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(223, 22);
            this.Label5.TabIndex = 159;
            this.Label5.Text = "GT PART NUMBER:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer3
            // 
            this.WinControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(332.6061F, 12.10985F);
            this.WinControlContainer3.Name = "WinControlContainer3";
            this.WinControlContainer3.SizeF = new System.Drawing.SizeF(126.6041F, 23F);
            this.WinControlContainer3.WinControl = this.CustomerPartNoLabel;
            // 
            // CustomerPartNoLabel
            // 
            this.CustomerPartNoLabel.BackColor = System.Drawing.Color.White;
            this.CustomerPartNoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPartNoLabel.Location = new System.Drawing.Point(207, 31);
            this.CustomerPartNoLabel.Name = "CustomerPartNoLabel";
            this.CustomerPartNoLabel.Size = new System.Drawing.Size(122, 22);
            this.CustomerPartNoLabel.TabIndex = 162;
            this.CustomerPartNoLabel.Text = "12345-789";
            this.CustomerPartNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer2
            // 
            this.WinControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(100.1894F, 12.10985F);
            this.WinControlContainer2.Name = "WinControlContainer2";
            this.WinControlContainer2.SizeF = new System.Drawing.SizeF(232.4167F, 23F);
            this.WinControlContainer2.WinControl = this.Label1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(220, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(223, 22);
            this.Label1.TabIndex = 160;
            this.Label1.Text = "CLIENT PART NUMBER:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer1
            // 
            this.WinControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(26.04165F, 12.10985F);
            this.WinControlContainer1.Name = "WinControlContainer1";
            this.WinControlContainer1.SizeF = new System.Drawing.SizeF(74.14775F, 59.93182F);
            this.WinControlContainer1.WinControl = this.PictureBox7;
            // 
            // PictureBox7
            // 
            this.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox7.Image = global::GT.Trace.Labels.Templates.Properties.Resources.LOGO_GT2;
            this.PictureBox7.Location = new System.Drawing.Point(30, 23);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(71, 58);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 182;
            this.PictureBox7.TabStop = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 16.125F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // KitSavLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 16, 0);
            this.PageHeight = 375;
            this.PageWidth = 556;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.ShowPrintStatusDialog = false;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        internal DevExpress.XtraReports.UI.DetailBand Detail;
        internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer1;
        internal PictureBox PictureBox7;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer2;
        internal Label Label1;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer3;
        internal Label CustomerPartNoLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer9;
        internal Label Label5;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer10;
        internal Label Label6;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer13;
        internal Label PartNoLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer23;
        internal Label Label20;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer17;
        internal Label Label14;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer15;
        internal Label PartDescriptionLabel;
        internal DevExpress.XtraReports.UI.XRBarCode SerialCodeLabel;
    }
}