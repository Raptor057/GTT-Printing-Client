
using System.Windows.Forms;

namespace GT.Trace.Labels.Templates
{
    partial class SubAssemblyEtiLabel
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.EAN128Generator eaN128Generator1 = new DevExpress.XtraPrinting.BarCode.EAN128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.accountEmpl = new DevExpress.XtraReports.UI.XRLabel();
            this.PartDescriptionLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.SupplierLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.EtiIDLabel = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.printedText = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.QuantityLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.MfgDateLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.RevisionLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.txtRevAnt = new DevExpress.XtraReports.UI.XRLabel();
            this.txtRevBy = new DevExpress.XtraReports.UI.XRLabel();
            this.PartNoLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.LotNoLabel = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.HeightF = 483.125F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.LotNoLabel,
            this.xrLabel6,
            this.xrLabel5,
            this.accountEmpl,
            this.PartDescriptionLabel,
            this.SupplierLabel,
            this.xrLabel4,
            this.EtiIDLabel,
            this.xrLabel36,
            this.xrLabel12,
            this.printedText,
            this.xrLabel9,
            this.QuantityLabel,
            this.MfgDateLabel,
            this.xrLabel3,
            this.xrLabel2,
            this.RevisionLabel,
            this.txtRevAnt,
            this.txtRevBy,
            this.PartNoLabel,
            this.xrLabel1});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(285F, 479.3749F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 389.5334F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(263.9584F, 16.08319F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "CUENTA - # EMPLEADO";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // accountEmpl
            // 
            this.accountEmpl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.accountEmpl.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold);
            this.accountEmpl.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 405.6166F);
            this.accountEmpl.Name = "accountEmpl";
            this.accountEmpl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.accountEmpl.SizeF = new System.Drawing.SizeF(263.9584F, 22.0419F);
            this.accountEmpl.StylePriority.UseBorders = false;
            this.accountEmpl.StylePriority.UseFont = false;
            this.accountEmpl.StylePriority.UseTextAlignment = false;
            this.accountEmpl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtPartDesc
            // 
            this.PartDescriptionLabel.CanGrow = false;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 135.3253F);
            this.PartDescriptionLabel.Name = "txtPartDesc";
            this.PartDescriptionLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.PartDescriptionLabel.SizeF = new System.Drawing.SizeF(267.0804F, 17.16661F);
            this.PartDescriptionLabel.StylePriority.UseFont = false;
            this.PartDescriptionLabel.StylePriority.UseTextAlignment = false;
            this.PartDescriptionLabel.Text = "Part Desc";
            this.PartDescriptionLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.PartDescriptionLabel.WordWrap = false;
            // 
            // txtSupplier
            // 
            this.SupplierLabel.CanGrow = false;
            this.SupplierLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLabel.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 305.8667F);
            this.SupplierLabel.Name = "txtSupplier";
            this.SupplierLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.SupplierLabel.SizeF = new System.Drawing.SizeF(263.9584F, 29.83328F);
            this.SupplierLabel.StylePriority.UseFont = false;
            this.SupplierLabel.StylePriority.UseTextAlignment = false;
            this.SupplierLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SupplierLabel.WordWrap = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(7.919598F, 284.3668F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(263.9584F, 21.49994F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "PROVEEDOR";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.EtiIDLabel.AutoModule = true;
            this.EtiIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiIDLabel.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 10.00001F);
            this.EtiIDLabel.Module = 1F;
            this.EtiIDLabel.Name = "txtID";
            this.EtiIDLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.EtiIDLabel.SizeF = new System.Drawing.SizeF(267.0804F, 61.08375F);
            this.EtiIDLabel.StylePriority.UseFont = false;
            this.EtiIDLabel.StylePriority.UseTextAlignment = false;
            this.EtiIDLabel.Symbology = eaN128Generator1;
            this.EtiIDLabel.Text = "E123456";
            this.EtiIDLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel36
            // 
            this.xrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel36.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 427.6584F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(71.47926F, 18.75F);
            this.xrLabel36.StylePriority.UseBorders = false;
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = "IMPRESION";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(156.0352F, 446.4084F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(115.8428F, 20.20831F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "ETI - Rev. -";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // printedText
            // 
            this.printedText.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.printedText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedText.LocationFloat = new DevExpress.Utils.PointFloat(79.39886F, 427.6586F);
            this.printedText.Name = "printedText";
            this.printedText.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printedText.SizeF = new System.Drawing.SizeF(192.4792F, 18.74994F);
            this.printedText.StylePriority.UseBorders = false;
            this.printedText.StylePriority.UseFont = false;
            this.printedText.StylePriority.UseTextAlignment = false;
            this.printedText.Text = "12:00 PM";
            this.printedText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 335.7F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(263.9584F, 18.16644F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "CANTIDAD";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtTQty
            // 
            this.QuantityLabel.CanGrow = false;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.QuantityLabel.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 353.8665F);
            this.QuantityLabel.Name = "txtTQty";
            this.QuantityLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.QuantityLabel.SizeF = new System.Drawing.SizeF(263.9584F, 35.66705F);
            this.QuantityLabel.StylePriority.UseFont = false;
            this.QuantityLabel.StylePriority.UseTextAlignment = false;
            this.QuantityLabel.Text = "150000";
            this.QuantityLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.QuantityLabel.WordWrap = false;
            // 
            // txtMFDate
            // 
            this.MfgDateLabel.CanGrow = false;
            this.MfgDateLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.MfgDateLabel.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 193.0747F);
            this.MfgDateLabel.Name = "txtMFDate";
            this.MfgDateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.MfgDateLabel.SizeF = new System.Drawing.SizeF(263.9584F, 28.79205F);
            this.MfgDateLabel.StylePriority.UseFont = false;
            this.MfgDateLabel.StylePriority.UseTextAlignment = false;
            this.MfgDateLabel.Text = "15-OCT-17 9:48:52 PM";
            this.MfgDateLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.MfgDateLabel.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 162.5329F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(263.9584F, 30.54175F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "FECHA DE MANUFACTURA";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(194.4596F, 71.08377F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(80.54041F, 13.87503F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "REV";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtRev
            // 
            this.RevisionLabel.CanGrow = false;
            this.RevisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.RevisionLabel.LocationFloat = new DevExpress.Utils.PointFloat(195.918F, 84.95878F);
            this.RevisionLabel.Name = "txtRev";
            this.RevisionLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.RevisionLabel.SizeF = new System.Drawing.SizeF(79.08203F, 26.20844F);
            this.RevisionLabel.StylePriority.UseFont = false;
            this.RevisionLabel.StylePriority.UseTextAlignment = false;
            this.RevisionLabel.Text = "XC010";
            this.RevisionLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.RevisionLabel.WordWrap = false;
            // 
            // txtRevAnt
            // 
            this.txtRevAnt.CanGrow = false;
            this.txtRevAnt.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold);
            this.txtRevAnt.LocationFloat = new DevExpress.Utils.PointFloat(195.918F, 111.1672F);
            this.txtRevAnt.Name = "txtRevAnt";
            this.txtRevAnt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtRevAnt.SizeF = new System.Drawing.SizeF(42.07318F, 24.1581F);
            this.txtRevAnt.StylePriority.UseFont = false;
            this.txtRevAnt.StylePriority.UseTextAlignment = false;
            this.txtRevAnt.Text = "REV_AN";
            this.txtRevAnt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.txtRevAnt.Visible = false;
            this.txtRevAnt.WordWrap = false;
            // 
            // txtRevBy
            // 
            this.txtRevBy.CanGrow = false;
            this.txtRevBy.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold);
            this.txtRevBy.LocationFloat = new DevExpress.Utils.PointFloat(237.9912F, 111.1672F);
            this.txtRevBy.Name = "txtRevBy";
            this.txtRevBy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtRevBy.SizeF = new System.Drawing.SizeF(37.00879F, 24.1581F);
            this.txtRevBy.StylePriority.UseFont = false;
            this.txtRevBy.StylePriority.UseTextAlignment = false;
            this.txtRevBy.Text = "CHBY";
            this.txtRevBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.txtRevBy.Visible = false;
            this.txtRevBy.WordWrap = false;
            // 
            // PartNoLabel
            // 
            this.PartNoLabel.AutoWidth = true;
            this.PartNoLabel.CanGrow = false;
            this.PartNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.PartNoLabel.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 84.95881F);
            this.PartNoLabel.Name = "PartNoLabel";
            this.PartNoLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.PartNoLabel.SizeF = new System.Drawing.SizeF(186.54F, 50.36654F);
            this.PartNoLabel.StylePriority.UseFont = false;
            this.PartNoLabel.StylePriority.UseTextAlignment = false;
            this.PartNoLabel.Text = "AEM5-636-2101303-1";
            this.PartNoLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 71.08377F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(186.54F, 13.87505F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "NUMERO DE PARTE";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 4.999987F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 221.8668F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(263.9584F, 30.54175F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "LOTE";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // LotNoLabel
            // 
            this.LotNoLabel.CanGrow = false;
            this.LotNoLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.LotNoLabel.LocationFloat = new DevExpress.Utils.PointFloat(7.919574F, 252.4085F);
            this.LotNoLabel.Name = "LotNoLabel";
            this.LotNoLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LotNoLabel.SizeF = new System.Drawing.SizeF(263.9584F, 28.79205F);
            this.LotNoLabel.StylePriority.UseFont = false;
            this.LotNoLabel.StylePriority.UseTextAlignment = false;
            this.LotNoLabel.Text = "2022123";
            this.LotNoLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.LotNoLabel.WordWrap = false;
            // 
            // SubAssemblyEtiLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(0, 3, 0, 5);
            this.PageHeight = 500;
            this.PageWidth = 292;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRBarCode EtiIDLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel36;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel printedText;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel QuantityLabel;
        private DevExpress.XtraReports.UI.XRLabel MfgDateLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel RevisionLabel;
        private DevExpress.XtraReports.UI.XRLabel txtRevAnt;
        private DevExpress.XtraReports.UI.XRLabel txtRevBy;
        private DevExpress.XtraReports.UI.XRLabel PartNoLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel SupplierLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel PartDescriptionLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel accountEmpl;
        private DevExpress.XtraReports.UI.XRLabel LotNoLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    }
}