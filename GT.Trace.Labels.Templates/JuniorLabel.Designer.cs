using System.Windows.Forms;

namespace GT.Trace.Labels.Templates
{

    public partial class JuniorLabel : LabelBase
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
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SerialCodeLabel = new DevExpress.XtraReports.UI.XRBarCode();
            this.QC = new DevExpress.XtraReports.UI.XRPanel();
            this.WinControlContainer28 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.ApprovalDateLabel = new System.Windows.Forms.Label();
            this.WinControlContainer27 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.ApproverLabel = new System.Windows.Forms.Label();
            this.WinControlContainer26 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label23 = new System.Windows.Forms.Label();
            this.WinControlContainer25 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label22 = new System.Windows.Forms.Label();
            this.WinControlContainer24 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label21 = new System.Windows.Forms.Label();
            this.WinControlContainer23 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label20 = new System.Windows.Forms.Label();
            this.WinControlContainer22 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.JulianDateLabel = new System.Windows.Forms.Label();
            this.WinControlContainer21 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.POLabel = new System.Windows.Forms.Label();
            this.WinControlContainer20 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WinControlContainer19 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.WinControlContainer18 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.LineNameLabel = new System.Windows.Forms.Label();
            this.WinControlContainer17 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label14 = new System.Windows.Forms.Label();
            this.WinControlContainer16 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.WinControlContainer15 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PartDescriptionLabel = new System.Windows.Forms.Label();
            this.WinControlContainer14 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label11 = new System.Windows.Forms.Label();
            this.WinControlContainer13 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer11 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label7 = new System.Windows.Forms.Label();
            this.WinControlContainer10 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label6 = new System.Windows.Forms.Label();
            this.WinControlContainer9 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label5 = new System.Windows.Forms.Label();
            this.WinControlContainer8 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label2 = new System.Windows.Forms.Label();
            this.WinControlContainer7 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label8 = new System.Windows.Forms.Label();
            this.WinControlContainer6 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.RevisionLabel = new System.Windows.Forms.Label();
            this.WinControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.CustomerPartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label1 = new System.Windows.Forms.Label();
            this.WinControlContainer4 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label3 = new System.Windows.Forms.Label();
            this.WinControlContainer5 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label4 = new System.Windows.Forms.Label();
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
            this.QC,
            this.WinControlContainer23,
            this.WinControlContainer22,
            this.WinControlContainer21,
            this.WinControlContainer20,
            this.WinControlContainer19,
            this.WinControlContainer18,
            this.WinControlContainer17,
            this.WinControlContainer16,
            this.WinControlContainer15,
            this.WinControlContainer14,
            this.WinControlContainer13,
            this.WinControlContainer11,
            this.WinControlContainer10,
            this.WinControlContainer9,
            this.WinControlContainer8,
            this.WinControlContainer7,
            this.WinControlContainer6,
            this.WinControlContainer3,
            this.WinControlContainer2,
            this.WinControlContainer4,
            this.WinControlContainer5,
            this.WinControlContainer1});
            this.Detail.HeightF = 369F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SerialCodeLabel
            // 
            this.SerialCodeLabel.AutoModule = true;
            this.SerialCodeLabel.LocationFloat = new DevExpress.Utils.PointFloat(430.487F, 100.0417F);
            this.SerialCodeLabel.Name = "SerialCodeLabel";
            this.SerialCodeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.SerialCodeLabel.ShowText = false;
            this.SerialCodeLabel.SizeF = new System.Drawing.SizeF(105.5133F, 93.58335F);
            this.SerialCodeLabel.Symbology = dataMatrixGS1Generator1;
            this.SerialCodeLabel.Text = "M15157";
            // 
            // QC
            // 
            this.QC.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.QC.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.WinControlContainer28,
            this.WinControlContainer27,
            this.WinControlContainer26,
            this.WinControlContainer25,
            this.WinControlContainer24});
            this.QC.LocationFloat = new DevExpress.Utils.PointFloat(253.125F, 232.4167F);
            this.QC.Name = "QC";
            this.QC.SizeF = new System.Drawing.SizeF(145.8334F, 98.58334F);
            this.QC.StylePriority.UseBorders = false;
            this.QC.Visible = false;
            // 
            // WinControlContainer28
            // 
            this.WinControlContainer28.LocationFloat = new DevExpress.Utils.PointFloat(61.73102F, 67.58331F);
            this.WinControlContainer28.Name = "WinControlContainer28";
            this.WinControlContainer28.SizeF = new System.Drawing.SizeF(80.35234F, 21.00001F);
            this.WinControlContainer28.WinControl = this.ApprovalDateLabel;
            // 
            // ApprovalDateLabel
            // 
            this.ApprovalDateLabel.BackColor = System.Drawing.Color.White;
            this.ApprovalDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovalDateLabel.Location = new System.Drawing.Point(371, 219);
            this.ApprovalDateLabel.Name = "ApprovalDateLabel";
            this.ApprovalDateLabel.Size = new System.Drawing.Size(75, 18);
            this.ApprovalDateLabel.TabIndex = 161;
            this.ApprovalDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer27
            // 
            this.WinControlContainer27.LocationFloat = new DevExpress.Utils.PointFloat(61.73102F, 35.49992F);
            this.WinControlContainer27.Name = "WinControlContainer27";
            this.WinControlContainer27.SizeF = new System.Drawing.SizeF(80.35234F, 21F);
            this.WinControlContainer27.WinControl = this.ApproverLabel;
            // 
            // ApproverLabel
            // 
            this.ApproverLabel.BackColor = System.Drawing.Color.White;
            this.ApproverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproverLabel.Location = new System.Drawing.Point(371, 219);
            this.ApproverLabel.Name = "ApproverLabel";
            this.ApproverLabel.Size = new System.Drawing.Size(75, 18);
            this.ApproverLabel.TabIndex = 161;
            this.ApproverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer26
            // 
            this.WinControlContainer26.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 67.58311F);
            this.WinControlContainer26.Name = "WinControlContainer26";
            this.WinControlContainer26.SizeF = new System.Drawing.SizeF(51.73092F, 21.00001F);
            this.WinControlContainer26.WinControl = this.Label23;
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.White;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(371, 219);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(48, 18);
            this.Label23.TabIndex = 161;
            this.Label23.Text = "Date:";
            // 
            // WinControlContainer25
            // 
            this.WinControlContainer25.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 35.49986F);
            this.WinControlContainer25.Name = "WinControlContainer25";
            this.WinControlContainer25.SizeF = new System.Drawing.SizeF(51.73098F, 21F);
            this.WinControlContainer25.WinControl = this.Label22;
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.White;
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(371, 219);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(48, 18);
            this.Label22.TabIndex = 161;
            this.Label22.Text = "By:";
            // 
            // WinControlContainer24
            // 
            this.WinControlContainer24.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 9.999974F);
            this.WinControlContainer24.Name = "WinControlContainer24";
            this.WinControlContainer24.SizeF = new System.Drawing.SizeF(132.0834F, 22.99999F);
            this.WinControlContainer24.WinControl = this.Label21;
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.White;
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(371, 219);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(125, 20);
            this.Label21.TabIndex = 161;
            this.Label21.Text = "Q.A APPROVED";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer23
            // 
            this.WinControlContainer23.LocationFloat = new DevExpress.Utils.PointFloat(456.0001F, 346F);
            this.WinControlContainer23.Name = "WinControlContainer23";
            this.WinControlContainer23.SizeF = new System.Drawing.SizeF(90.00009F, 13F);
            this.WinControlContainer23.WinControl = this.Label20;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.White;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(371, 219);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(86, 12);
            this.Label20.TabIndex = 161;
            this.Label20.Text = "ETI 021 Rev. B";
            // 
            // WinControlContainer22
            // 
            this.WinControlContainer22.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 336F);
            this.WinControlContainer22.Name = "WinControlContainer22";
            this.WinControlContainer22.SizeF = new System.Drawing.SizeF(385.2084F, 23F);
            this.WinControlContainer22.WinControl = this.JulianDateLabel;
            // 
            // JulianDateLabel
            // 
            this.JulianDateLabel.BackColor = System.Drawing.Color.White;
            this.JulianDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JulianDateLabel.Location = new System.Drawing.Point(371, 219);
            this.JulianDateLabel.Name = "JulianDateLabel";
            this.JulianDateLabel.Size = new System.Drawing.Size(370, 22);
            this.JulianDateLabel.TabIndex = 161;
            this.JulianDateLabel.Text = "620";
            this.JulianDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer21
            // 
            this.WinControlContainer21.LocationFloat = new DevExpress.Utils.PointFloat(76.04166F, 270.9167F);
            this.WinControlContainer21.Name = "WinControlContainer21";
            this.WinControlContainer21.SizeF = new System.Drawing.SizeF(170.8333F, 23F);
            this.WinControlContainer21.WinControl = this.POLabel;
            // 
            // POLabel
            // 
            this.POLabel.BackColor = System.Drawing.Color.White;
            this.POLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POLabel.Location = new System.Drawing.Point(371, 219);
            this.POLabel.Name = "POLabel";
            this.POLabel.Size = new System.Drawing.Size(164, 22);
            this.POLabel.TabIndex = 161;
            this.POLabel.Text = "PO#0000000";
            this.POLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer20
            // 
            this.WinControlContainer20.LocationFloat = new DevExpress.Utils.PointFloat(76.04166F, 233.4167F);
            this.WinControlContainer20.Name = "WinControlContainer20";
            this.WinControlContainer20.SizeF = new System.Drawing.SizeF(170.8333F, 23F);
            this.WinControlContainer20.WinControl = this.DateLabel;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.White;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(371, 219);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(164, 22);
            this.DateLabel.TabIndex = 161;
            this.DateLabel.Text = "6-Jan-2020";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer19
            // 
            this.WinControlContainer19.LocationFloat = new DevExpress.Utils.PointFloat(89.16667F, 165.625F);
            this.WinControlContainer19.Name = "WinControlContainer19";
            this.WinControlContainer19.SizeF = new System.Drawing.SizeF(337.7785F, 23F);
            this.WinControlContainer19.WinControl = this.CustomerLabel;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.BackColor = System.Drawing.Color.White;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(371, 219);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(324, 22);
            this.CustomerLabel.TabIndex = 161;
            this.CustomerLabel.Text = "CLIENTE DE GT";
            this.CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer18
            // 
            this.WinControlContainer18.LocationFloat = new DevExpress.Utils.PointFloat(404.0417F, 316.9166F);
            this.WinControlContainer18.Name = "WinControlContainer18";
            this.WinControlContainer18.SizeF = new System.Drawing.SizeF(141.9584F, 23F);
            this.WinControlContainer18.WinControl = this.LineNameLabel;
            // 
            // LineNameLabel
            // 
            this.LineNameLabel.BackColor = System.Drawing.Color.White;
            this.LineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNameLabel.Location = new System.Drawing.Point(371, 219);
            this.LineNameLabel.Name = "LineNameLabel";
            this.LineNameLabel.Size = new System.Drawing.Size(136, 22);
            this.LineNameLabel.TabIndex = 161;
            this.LineNameLabel.Text = "RIDER LD";
            this.LineNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer17
            // 
            this.WinControlContainer17.LocationFloat = new DevExpress.Utils.PointFloat(404.0417F, 293.9166F);
            this.WinControlContainer17.Name = "WinControlContainer17";
            this.WinControlContainer17.SizeF = new System.Drawing.SizeF(141.9584F, 23F);
            this.WinControlContainer17.WinControl = this.Label14;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(371, 219);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(136, 22);
            this.Label14.TabIndex = 161;
            this.Label14.Text = "ASSEMBLY LINE:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer16
            // 
            this.WinControlContainer16.LocationFloat = new DevExpress.Utils.PointFloat(404.0417F, 256.4167F);
            this.WinControlContainer16.Name = "WinControlContainer16";
            this.WinControlContainer16.SizeF = new System.Drawing.SizeF(141.9584F, 37.5F);
            this.WinControlContainer16.WinControl = this.QuantityLabel;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.BackColor = System.Drawing.Color.White;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(371, 219);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(136, 36);
            this.QuantityLabel.TabIndex = 161;
            this.QuantityLabel.Text = "12";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer15
            // 
            this.WinControlContainer15.LocationFloat = new DevExpress.Utils.PointFloat(135F, 199.0417F);
            this.WinControlContainer15.Name = "WinControlContainer15";
            this.WinControlContainer15.SizeF = new System.Drawing.SizeF(411.0002F, 23F);
            this.WinControlContainer15.WinControl = this.PartDescriptionLabel;
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.Location = new System.Drawing.Point(371, 219);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(395, 22);
            this.PartDescriptionLabel.TabIndex = 161;
            this.PartDescriptionLabel.Text = "TRANSMISION";
            this.PartDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer14
            // 
            this.WinControlContainer14.LocationFloat = new DevExpress.Utils.PointFloat(404.0417F, 233.4167F);
            this.WinControlContainer14.Name = "WinControlContainer14";
            this.WinControlContainer14.SizeF = new System.Drawing.SizeF(141.9584F, 22.99997F);
            this.WinControlContainer14.WinControl = this.Label11;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(371, 219);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(136, 22);
            this.Label11.TabIndex = 161;
            this.Label11.Text = "PARTS PER BOX:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer13
            // 
            this.WinControlContainer13.LocationFloat = new DevExpress.Utils.PointFloat(212.7917F, 95.04166F);
            this.WinControlContainer13.Name = "WinControlContainer13";
            this.WinControlContainer13.SizeF = new System.Drawing.SizeF(214.1535F, 47.66666F);
            this.WinControlContainer13.WinControl = this.PartNoLabel;
            // 
            // PartNoLabel
            // 
            this.PartNoLabel.BackColor = System.Drawing.Color.White;
            this.PartNoLabel.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.PartNoLabel.Location = new System.Drawing.Point(22, 303);
            this.PartNoLabel.Name = "PartNoLabel";
            this.PartNoLabel.Size = new System.Drawing.Size(206, 46);
            this.PartNoLabel.TabIndex = 159;
            this.PartNoLabel.Text = "GT123456";
            this.PartNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer11
            // 
            this.WinControlContainer11.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 165.625F);
            this.WinControlContainer11.Name = "WinControlContainer11";
            this.WinControlContainer11.SizeF = new System.Drawing.SizeF(79.16667F, 23F);
            this.WinControlContainer11.WinControl = this.Label7;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label7.Location = new System.Drawing.Point(22, 303);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(76, 22);
            this.Label7.TabIndex = 159;
            this.Label7.Text = "SHIP TO:";
            // 
            // WinControlContainer10
            // 
            this.WinControlContainer10.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 199.0417F);
            this.WinControlContainer10.Name = "WinControlContainer10";
            this.WinControlContainer10.SizeF = new System.Drawing.SizeF(125F, 23F);
            this.WinControlContainer10.WinControl = this.Label6;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label6.Location = new System.Drawing.Point(22, 303);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(120, 22);
            this.Label6.TabIndex = 159;
            this.Label6.Text = "DESCRIPTION:";
            // 
            // WinControlContainer9
            // 
            this.WinControlContainer9.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 233.4167F);
            this.WinControlContainer9.Name = "WinControlContainer9";
            this.WinControlContainer9.SizeF = new System.Drawing.SizeF(66.04166F, 23F);
            this.WinControlContainer9.WinControl = this.Label5;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label5.Location = new System.Drawing.Point(22, 303);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 22);
            this.Label5.TabIndex = 159;
            this.Label5.Text = "DATE:";
            // 
            // WinControlContainer8
            // 
            this.WinControlContainer8.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 270.9167F);
            this.WinControlContainer8.Name = "WinControlContainer8";
            this.WinControlContainer8.SizeF = new System.Drawing.SizeF(66.04166F, 23F);
            this.WinControlContainer8.WinControl = this.Label2;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.Location = new System.Drawing.Point(22, 303);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 22);
            this.Label2.TabIndex = 159;
            this.Label2.Text = "P.O. #:";
            // 
            // WinControlContainer7
            // 
            this.WinControlContainer7.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 306.3333F);
            this.WinControlContainer7.Name = "WinControlContainer7";
            this.WinControlContainer7.SizeF = new System.Drawing.SizeF(125F, 23F);
            this.WinControlContainer7.WinControl = this.Label8;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label8.Location = new System.Drawing.Point(22, 303);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(120, 22);
            this.Label8.TabIndex = 159;
            this.Label8.Text = "LOT NUMBER:";
            // 
            // WinControlContainer6
            // 
            this.WinControlContainer6.LocationFloat = new DevExpress.Utils.PointFloat(484.5416F, 0F);
            this.WinControlContainer6.Name = "WinControlContainer6";
            this.WinControlContainer6.SizeF = new System.Drawing.SizeF(51.45868F, 23F);
            this.WinControlContainer6.WinControl = this.RevisionLabel;
            // 
            // RevisionLabel
            // 
            this.RevisionLabel.BackColor = System.Drawing.Color.White;
            this.RevisionLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisionLabel.Location = new System.Drawing.Point(207, 31);
            this.RevisionLabel.Name = "RevisionLabel";
            this.RevisionLabel.Size = new System.Drawing.Size(49, 22);
            this.RevisionLabel.TabIndex = 162;
            this.RevisionLabel.Text = "A1";
            this.RevisionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer3
            // 
            this.WinControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(185.7084F, 33.41668F);
            this.WinControlContainer3.Name = "WinControlContainer3";
            this.WinControlContainer3.SizeF = new System.Drawing.SizeF(360.2916F, 61.62497F);
            this.WinControlContainer3.WinControl = this.CustomerPartNoLabel;
            // 
            // CustomerPartNoLabel
            // 
            this.CustomerPartNoLabel.BackColor = System.Drawing.Color.White;
            this.CustomerPartNoLabel.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPartNoLabel.Location = new System.Drawing.Point(207, 31);
            this.CustomerPartNoLabel.Name = "CustomerPartNoLabel";
            this.CustomerPartNoLabel.Size = new System.Drawing.Size(346, 59);
            this.CustomerPartNoLabel.TabIndex = 162;
            this.CustomerPartNoLabel.Text = "12345-789";
            this.CustomerPartNoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer2
            // 
            this.WinControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(212.7917F, 0F);
            this.WinControlContainer2.Name = "WinControlContainer2";
            this.WinControlContainer2.SizeF = new System.Drawing.SizeF(271.7499F, 23F);
            this.WinControlContainer2.WinControl = this.Label1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(220, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(261, 22);
            this.Label1.TabIndex = 160;
            this.Label1.Text = "PART NUMBER:                    REV.\n";
            // 
            // WinControlContainer4
            // 
            this.WinControlContainer4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.WinControlContainer4.Name = "WinControlContainer4";
            this.WinControlContainer4.SizeF = new System.Drawing.SizeF(206.8959F, 12.10985F);
            this.WinControlContainer4.WinControl = this.Label3;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 6);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(199, 12);
            this.Label3.TabIndex = 153;
            this.Label3.Text = "ASSEMBLED IN MEXICO BY";
            // 
            // WinControlContainer5
            // 
            this.WinControlContainer5.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 72.04167F);
            this.WinControlContainer5.Name = "WinControlContainer5";
            this.WinControlContainer5.SizeF = new System.Drawing.SizeF(159.3959F, 23F);
            this.WinControlContainer5.WinControl = this.Label4;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 67);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(153, 22);
            this.Label4.TabIndex = 154;
            this.Label4.Text = "302 Lorenaly Drive, Suite E.\nBrownsville, Tx. 78526 USA";
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
            // JuniorLabel
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
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer4;
        internal Label Label3;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer5;
        internal Label Label4;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer2;
        internal Label Label1;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer3;
        internal Label CustomerPartNoLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer6;
        internal Label RevisionLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer8;
        internal Label Label2;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer7;
        internal Label Label8;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer9;
        internal Label Label5;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer10;
        internal Label Label6;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer11;
        internal Label Label7;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer13;
        internal Label PartNoLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer23;
        internal Label Label20;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer22;
        internal Label JulianDateLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer21;
        internal Label POLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer20;
        internal Label DateLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer19;
        internal Label CustomerLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer18;
        internal Label LineNameLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer17;
        internal Label Label14;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer16;
        internal Label QuantityLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer15;
        internal Label PartDescriptionLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer14;
        internal Label Label11;
        internal DevExpress.XtraReports.UI.XRPanel QC;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer28;
        internal Label ApprovalDateLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer27;
        internal Label ApproverLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer26;
        internal Label Label23;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer25;
        internal Label Label22;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer24;
        internal Label Label21;

        internal DevExpress.XtraReports.UI.XRBarCode SerialCodeLabel;
    }
}