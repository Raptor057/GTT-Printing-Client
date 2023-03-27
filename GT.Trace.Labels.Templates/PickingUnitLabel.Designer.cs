
namespace GT.Trace.Labels.Templates
{
    partial class PickingUnitLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickingUnitLabel));
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblserial = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BARCODE = new DevExpress.XtraReports.UI.XRBarCode();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrLabel1,
            this.lblserial,
            this.xrPictureBox1,
            this.BARCODE});
            this.TopMargin.HeightF = 83.34004F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XrLabel1
            // 
            this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", 5F, System.Drawing.FontStyle.Bold);
            this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(31.70168F, 18.50667F);
            this.XrLabel1.Name = "XrLabel1";
            this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel1.SizeF = new System.Drawing.SizeF(69.79156F, 16F);
            this.XrLabel1.StylePriority.UseFont = false;
            this.XrLabel1.Text = "PICKING DE PRUEBA";
            // 
            // lblserial
            // 
            this.lblserial.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.lblserial.LocationFloat = new DevExpress.Utils.PointFloat(9.999935F, 34.50667F);
            this.lblserial.Name = "lblserial";
            this.lblserial.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblserial.SizeF = new System.Drawing.SizeF(91.49332F, 23F);
            this.lblserial.StylePriority.UseFont = false;
            this.lblserial.Text = "WB145623/LH/18";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 18.50667F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(17.49666F, 16.00001F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // BARCODE
            // 
            this.BARCODE.AutoModule = true;
            this.BARCODE.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.BARCODE.LocationFloat = new DevExpress.Utils.PointFloat(101.4932F, 18.50665F);
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.BARCODE.SizeF = new System.Drawing.SizeF(60.72167F, 28.58335F);
            this.BARCODE.StylePriority.UseFont = false;
            this.BARCODE.Symbology = dataMatrixGS1Generator1;
            this.BARCODE.Text = "1234";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PickingUnitLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(2, 3, 83, 100);
            this.PageHeight = 295;
            this.PageWidth = 276;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }


        internal DevExpress.XtraReports.UI.DetailBand Detail;
        internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        internal DevExpress.XtraReports.UI.XRBarCode BARCODE;
        internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
        internal DevExpress.XtraReports.UI.XRLabel lblserial;

        #endregion
    }
}