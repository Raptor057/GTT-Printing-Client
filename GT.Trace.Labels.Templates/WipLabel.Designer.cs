using System.Windows.Forms;

namespace GT.Trace.Labels.Templates
{

    public partial class WipLabel : LabelBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WipLabel));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.XrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.RestPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picwip = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picpartial = new DevExpress.XtraReports.UI.XRPictureBox();
            this.FolioLabel = new DevExpress.XtraReports.UI.XRBarCode();
            this.PartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer22 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.CustomerPartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer21 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label18 = new System.Windows.Forms.Label();
            this.WinControlContainer20 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.LineNameLabel = new System.Windows.Forms.Label();
            this.WinControlContainer19 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label16 = new System.Windows.Forms.Label();
            this.WinControlContainer18 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.WinControlContainer17 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label14 = new System.Windows.Forms.Label();
            this.WinControlContainer16 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.JulianDateLabel = new System.Windows.Forms.Label();
            this.WinControlContainer15 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.POLabel = new System.Windows.Forms.Label();
            this.WinControlContainer14 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WinControlContainer13 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PartDescriptionLabel = new System.Windows.Forms.Label();
            this.WinControlContainer12 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label9 = new System.Windows.Forms.Label();
            this.WinControlContainer11 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label8 = new System.Windows.Forms.Label();
            this.WinControlContainer10 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label7 = new System.Windows.Forms.Label();
            this.WinControlContainer9 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label6 = new System.Windows.Forms.Label();
            this.WinControlContainer8 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label5 = new System.Windows.Forms.Label();
            this.WinControlContainer7 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.WinControlContainer6 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.RevisionLabel = new System.Windows.Forms.Label();
            this.WinControlContainer5 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label3 = new System.Windows.Forms.Label();
            this.WinControlContainer4 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.WinControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label2 = new System.Windows.Forms.Label();
            this.WinControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label1 = new System.Windows.Forms.Label();
            this.WinControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrPictureBox1,
            this.RestPicture,
            this.picwip,
            this.picpartial,
            this.FolioLabel,
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
            this.WinControlContainer12,
            this.WinControlContainer11,
            this.WinControlContainer10,
            this.WinControlContainer9,
            this.WinControlContainer8,
            this.WinControlContainer7,
            this.WinControlContainer6,
            this.WinControlContainer5,
            this.WinControlContainer4,
            this.WinControlContainer3,
            this.WinControlContainer2,
            this.WinControlContainer1});
            this.Detail.HeightF = 369F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 16F;
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
            // XrPictureBox1
            // 
            this.XrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("XrPictureBox1.Image")));
            this.XrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(471.4584F, 187.5417F);
            this.XrPictureBox1.Name = "XrPictureBox1";
            this.XrPictureBox1.SizeF = new System.Drawing.SizeF(289.6986F, 172.5822F);
            this.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // RestPicture
            // 
            this.RestPicture.Image = ((System.Drawing.Image)(resources.GetObject("RestPicture.Image")));
            this.RestPicture.LocationFloat = new DevExpress.Utils.PointFloat(676.5509F, 0F);
            this.RestPicture.Name = "RestPicture";
            this.RestPicture.SizeF = new System.Drawing.SizeF(342.5741F, 48.95832F);
            this.RestPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.RestPicture.Visible = false;
            // 
            // picwip
            // 
            this.picwip.Image = ((System.Drawing.Image)(resources.GetObject("picwip.Image")));
            this.picwip.LocationFloat = new DevExpress.Utils.PointFloat(676.5509F, 0F);
            this.picwip.Name = "picwip";
            this.picwip.SizeF = new System.Drawing.SizeF(342.5741F, 48.9583F);
            this.picwip.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picwip.Visible = false;
            // 
            // picpartial
            // 
            this.picpartial.Image = ((System.Drawing.Image)(resources.GetObject("picpartial.Image")));
            this.picpartial.LocationFloat = new DevExpress.Utils.PointFloat(676.5509F, 0F);
            this.picpartial.Name = "picpartial";
            this.picpartial.SizeF = new System.Drawing.SizeF(342.5741F, 48.95832F);
            this.picpartial.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picpartial.Visible = false;
            // 
            // FolioLabel
            // 
            this.FolioLabel.AutoModule = true;
            this.FolioLabel.LocationFloat = new DevExpress.Utils.PointFloat(471.4583F, 120.0139F);
            this.FolioLabel.Name = "FolioLabel";
            this.FolioLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.FolioLabel.SizeF = new System.Drawing.SizeF(188.4259F, 40.70833F);
            this.FolioLabel.Symbology = code128Generator1;
            // 
            // PartNoLabel
            // 
            this.PartNoLabel.BackColor = System.Drawing.Color.White;
            this.PartNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNoLabel.Location = new System.Drawing.Point(800, 76);
            this.PartNoLabel.Name = "PartNoLabel";
            this.PartNoLabel.Size = new System.Drawing.Size(279, 24);
            this.PartNoLabel.TabIndex = 1;
            this.PartNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer22
            // 
            this.WinControlContainer22.LocationFloat = new DevExpress.Utils.PointFloat(729.5142F, 85.1435F);
            this.WinControlContainer22.Name = "WinControlContainer22";
            this.WinControlContainer22.SizeF = new System.Drawing.SizeF(290.4858F, 24.50464F);
            this.WinControlContainer22.WinControl = this.PartNoLabel;
            // 
            // CustomerPartNoLabel
            // 
            this.CustomerPartNoLabel.BackColor = System.Drawing.Color.White;
            this.CustomerPartNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPartNoLabel.Location = new System.Drawing.Point(800, 76);
            this.CustomerPartNoLabel.Name = "CustomerPartNoLabel";
            this.CustomerPartNoLabel.Size = new System.Drawing.Size(279, 21);
            this.CustomerPartNoLabel.TabIndex = 1;
            this.CustomerPartNoLabel.Text = "GT41857U";
            this.CustomerPartNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer21
            // 
            this.WinControlContainer21.LocationFloat = new DevExpress.Utils.PointFloat(729.5142F, 63.65751F);
            this.WinControlContainer21.Name = "WinControlContainer21";
            this.WinControlContainer21.SizeF = new System.Drawing.SizeF(290.4858F, 21.486F);
            this.WinControlContainer21.WinControl = this.CustomerPartNoLabel;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.White;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(800, 76);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(129, 22);
            this.Label18.TabIndex = 1;
            this.Label18.Text = "ETI 025 REV. A";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer20
            // 
            this.WinControlContainer20.LocationFloat = new DevExpress.Utils.PointFloat(885.6251F, 336F);
            this.WinControlContainer20.Name = "WinControlContainer20";
            this.WinControlContainer20.SizeF = new System.Drawing.SizeF(134.375F, 23F);
            this.WinControlContainer20.WinControl = this.Label18;
            // 
            // LineNameLabel
            // 
            this.LineNameLabel.BackColor = System.Drawing.Color.White;
            this.LineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNameLabel.Location = new System.Drawing.Point(800, 76);
            this.LineNameLabel.Name = "LineNameLabel";
            this.LineNameLabel.Size = new System.Drawing.Size(232, 24);
            this.LineNameLabel.TabIndex = 1;
            this.LineNameLabel.Text = "SERVICE PARTS";
            this.LineNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer19
            // 
            this.WinControlContainer19.LocationFloat = new DevExpress.Utils.PointFloat(777.824F, 311.0823F);
            this.WinControlContainer19.Name = "WinControlContainer19";
            this.WinControlContainer19.SizeF = new System.Drawing.SizeF(241.301F, 24.76846F);
            this.WinControlContainer19.WinControl = this.LineNameLabel;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.White;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(800, 76);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(232, 22);
            this.Label16.TabIndex = 1;
            this.Label16.Text = "ASSEMBLY LINE:";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer18
            // 
            this.WinControlContainer18.LocationFloat = new DevExpress.Utils.PointFloat(777.824F, 287.9665F);
            this.WinControlContainer18.Name = "WinControlContainer18";
            this.WinControlContainer18.SizeF = new System.Drawing.SizeF(241.301F, 23.11578F);
            this.WinControlContainer18.WinControl = this.Label16;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.BackColor = System.Drawing.Color.White;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(800, 76);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(232, 21);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "60";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer17
            // 
            this.WinControlContainer17.LocationFloat = new DevExpress.Utils.PointFloat(777.824F, 266.3795F);
            this.WinControlContainer17.Name = "WinControlContainer17";
            this.WinControlContainer17.SizeF = new System.Drawing.SizeF(241.3011F, 21.58698F);
            this.WinControlContainer17.WinControl = this.QuantityLabel;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(800, 76);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(232, 28);
            this.Label14.TabIndex = 1;
            this.Label14.Text = "PARTS PER PALLET:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer16
            // 
            this.WinControlContainer16.LocationFloat = new DevExpress.Utils.PointFloat(777.824F, 237.3611F);
            this.WinControlContainer16.Name = "WinControlContainer16";
            this.WinControlContainer16.SizeF = new System.Drawing.SizeF(241.3011F, 29.01843F);
            this.WinControlContainer16.WinControl = this.Label14;
            // 
            // JulianDateLabel
            // 
            this.JulianDateLabel.BackColor = System.Drawing.Color.White;
            this.JulianDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JulianDateLabel.Location = new System.Drawing.Point(800, 76);
            this.JulianDateLabel.Name = "JulianDateLabel";
            this.JulianDateLabel.Size = new System.Drawing.Size(232, 27);
            this.JulianDateLabel.TabIndex = 1;
            this.JulianDateLabel.Text = "1150";
            this.JulianDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer15
            // 
            this.WinControlContainer15.LocationFloat = new DevExpress.Utils.PointFloat(777.824F, 209.5001F);
            this.WinControlContainer15.Name = "WinControlContainer15";
            this.WinControlContainer15.SizeF = new System.Drawing.SizeF(241.3011F, 27.86105F);
            this.WinControlContainer15.WinControl = this.JulianDateLabel;
            // 
            // POLabel
            // 
            this.POLabel.BackColor = System.Drawing.Color.White;
            this.POLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POLabel.Location = new System.Drawing.Point(800, 76);
            this.POLabel.Name = "POLabel";
            this.POLabel.Size = new System.Drawing.Size(275, 25);
            this.POLabel.TabIndex = 1;
            this.POLabel.Text = "-";
            this.POLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer14
            // 
            this.WinControlContainer14.LocationFloat = new DevExpress.Utils.PointFloat(733.7917F, 160.7222F);
            this.WinControlContainer14.Name = "WinControlContainer14";
            this.WinControlContainer14.SizeF = new System.Drawing.SizeF(286.2083F, 25.54633F);
            this.WinControlContainer14.WinControl = this.POLabel;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.White;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(800, 76);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(102, 25);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "24-APRIL-2020";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer13
            // 
            this.WinControlContainer13.LocationFloat = new DevExpress.Utils.PointFloat(553.8659F, 160.7222F);
            this.WinControlContainer13.Name = "WinControlContainer13";
            this.WinControlContainer13.SizeF = new System.Drawing.SizeF(106.0184F, 25.54633F);
            this.WinControlContainer13.WinControl = this.DateLabel;
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.Location = new System.Drawing.Point(800, 76);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(220, 21);
            this.PartDescriptionLabel.TabIndex = 1;
            this.PartDescriptionLabel.Text = "SEALS";
            this.PartDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer12
            // 
            this.WinControlContainer12.LocationFloat = new DevExpress.Utils.PointFloat(790.8519F, 138.7824F);
            this.WinControlContainer12.Name = "WinControlContainer12";
            this.WinControlContainer12.SizeF = new System.Drawing.SizeF(229.1482F, 21.93988F);
            this.WinControlContainer12.WinControl = this.PartDescriptionLabel;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(800, 76);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(232, 22);
            this.Label9.TabIndex = 1;
            this.Label9.Text = "LOT NUMBER:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer11
            // 
            this.WinControlContainer11.LocationFloat = new DevExpress.Utils.PointFloat(777.824F, 186.2686F);
            this.WinControlContainer11.Name = "WinControlContainer11";
            this.WinControlContainer11.SizeF = new System.Drawing.SizeF(241.3011F, 23.23151F);
            this.WinControlContainer11.WinControl = this.Label9;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(800, 76);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 25);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "P.O. # :";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer10
            // 
            this.WinControlContainer10.LocationFloat = new DevExpress.Utils.PointFloat(677.4258F, 160.7222F);
            this.WinControlContainer10.Name = "WinControlContainer10";
            this.WinControlContainer10.SizeF = new System.Drawing.SizeF(56.36583F, 25.54633F);
            this.WinControlContainer10.WinControl = this.Label8;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(800, 76);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(79, 25);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "DATE:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer9
            // 
            this.WinControlContainer9.LocationFloat = new DevExpress.Utils.PointFloat(471.4583F, 160.7222F);
            this.WinControlContainer9.Name = "WinControlContainer9";
            this.WinControlContainer9.SizeF = new System.Drawing.SizeF(82.40736F, 25.54633F);
            this.WinControlContainer9.WinControl = this.Label7;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(800, 76);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(109, 21);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "DESCRIPTION:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer8
            // 
            this.WinControlContainer8.LocationFloat = new DevExpress.Utils.PointFloat(676.5509F, 138.7824F);
            this.WinControlContainer8.Name = "WinControlContainer8";
            this.WinControlContainer8.SizeF = new System.Drawing.SizeF(113.4258F, 21.93987F);
            this.WinControlContainer8.WinControl = this.Label6;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(800, 76);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(146, 28);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "SHIP TO:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer7
            // 
            this.WinControlContainer7.LocationFloat = new DevExpress.Utils.PointFloat(676.5509F, 109.6481F);
            this.WinControlContainer7.Name = "WinControlContainer7";
            this.WinControlContainer7.SizeF = new System.Drawing.SizeF(152.1989F, 29.13424F);
            this.WinControlContainer7.WinControl = this.Label5;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.BackColor = System.Drawing.Color.White;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(800, 76);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(183, 28);
            this.DestinationLabel.TabIndex = 1;
            this.DestinationLabel.Text = "GTINC";
            this.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer6
            // 
            this.WinControlContainer6.LocationFloat = new DevExpress.Utils.PointFloat(829.6248F, 109.6481F);
            this.WinControlContainer6.Name = "WinControlContainer6";
            this.WinControlContainer6.SizeF = new System.Drawing.SizeF(190.3752F, 29.13424F);
            this.WinControlContainer6.WinControl = this.DestinationLabel;
            // 
            // RevisionLabel
            // 
            this.RevisionLabel.BackColor = System.Drawing.Color.White;
            this.RevisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisionLabel.Location = new System.Drawing.Point(800, 76);
            this.RevisionLabel.Name = "RevisionLabel";
            this.RevisionLabel.Size = new System.Drawing.Size(53, 14);
            this.RevisionLabel.TabIndex = 1;
            this.RevisionLabel.Text = "B";
            this.RevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer5
            // 
            this.WinControlContainer5.LocationFloat = new DevExpress.Utils.PointFloat(912.0833F, 48.95827F);
            this.WinControlContainer5.Name = "WinControlContainer5";
            this.WinControlContainer5.SizeF = new System.Drawing.SizeF(54.95352F, 14.69921F);
            this.WinControlContainer5.WinControl = this.RevisionLabel;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(429, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(226, 14);
            this.Label3.TabIndex = 89;
            this.Label3.Text = "PART NUMBER:                                       REV.";
            // 
            // WinControlContainer4
            // 
            this.WinControlContainer4.LocationFloat = new DevExpress.Utils.PointFloat(676.551F, 48.95832F);
            this.WinControlContainer4.Name = "WinControlContainer4";
            this.WinControlContainer4.SizeF = new System.Drawing.SizeF(235.5323F, 14.69917F);
            this.WinControlContainer4.WinControl = this.Label3;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = global::GT.Trace.Labels.Templates.Properties.Resources.LOGO_GT2;
            this.PictureBox7.Location = new System.Drawing.Point(60, 57);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(79, 59);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 183;
            this.PictureBox7.TabStop = false;
            // 
            // WinControlContainer3
            // 
            this.WinControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(471.4584F, 23.8102F);
            this.WinControlContainer3.Name = "WinControlContainer3";
            this.WinControlContainer3.SizeF = new System.Drawing.SizeF(82.40736F, 61.33332F);
            this.WinControlContainer3.WinControl = this.PictureBox7;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(1, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(181, 32);
            this.Label2.TabIndex = 87;
            this.Label2.Text = "302 Lorenaly Drive, Suite E.\nBrownsville, Tx. 78526 USA\n";
            // 
            // WinControlContainer2
            // 
            this.WinControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(471.4583F, 86.41663F);
            this.WinControlContainer2.Name = "WinControlContainer2";
            this.WinControlContainer2.SizeF = new System.Drawing.SizeF(188.426F, 33.59731F);
            this.WinControlContainer2.WinControl = this.Label2;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(181, 23);
            this.Label1.TabIndex = 87;
            this.Label1.Text = "ASSEMBLED IN MEXICO BY";
            // 
            // WinControlContainer1
            // 
            this.WinControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(471.4584F, 0F);
            this.WinControlContainer1.Name = "WinControlContainer1";
            this.WinControlContainer1.SizeF = new System.Drawing.SizeF(188.4259F, 23.81019F);
            this.WinControlContainer1.WinControl = this.Label1;
            // 
            // WipLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(80, 0, 16, 0);
            this.PageHeight = 850;
            this.PageWidth = 1100;
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
        internal DevExpress.XtraReports.UI.XRPictureBox XrPictureBox1;
        internal DevExpress.XtraReports.UI.XRPictureBox RestPicture;
        internal DevExpress.XtraReports.UI.XRPictureBox picwip;
        internal DevExpress.XtraReports.UI.XRPictureBox picpartial;
        internal DevExpress.XtraReports.UI.XRBarCode FolioLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer22;
        internal Label PartNoLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer21;
        internal Label CustomerPartNoLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer20;
        internal Label Label18;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer19;
        internal Label LineNameLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer18;
        internal Label Label16;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer17;
        internal Label QuantityLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer16;
        internal Label Label14;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer15;
        internal Label JulianDateLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer14;
        internal Label POLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer13;
        internal Label DateLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer12;
        internal Label PartDescriptionLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer11;
        internal Label Label9;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer10;
        internal Label Label8;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer9;
        internal Label Label7;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer8;
        internal Label Label6;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer7;
        internal Label Label5;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer6;
        internal Label DestinationLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer5;
        internal Label RevisionLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer4;
        internal Label Label3;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer3;
        internal PictureBox PictureBox7;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer2;
        internal Label Label2;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer1;
        internal Label Label1;
    }

}