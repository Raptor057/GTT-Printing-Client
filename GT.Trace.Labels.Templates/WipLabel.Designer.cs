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
            this.XrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.RestPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picwip = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picpartial = new DevExpress.XtraReports.UI.XRPictureBox();
            this.FolioLabel = new DevExpress.XtraReports.UI.XRBarCode();
            this.WinControlContainer22 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer21 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.CustomerPartNoLabel = new System.Windows.Forms.Label();
            this.WinControlContainer20 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label18 = new System.Windows.Forms.Label();
            this.WinControlContainer19 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.LineNameLabel = new System.Windows.Forms.Label();
            this.WinControlContainer18 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label16 = new System.Windows.Forms.Label();
            this.WinControlContainer17 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.WinControlContainer16 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label14 = new System.Windows.Forms.Label();
            this.WinControlContainer15 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.JulianDateLabel = new System.Windows.Forms.Label();
            this.WinControlContainer14 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.POLabel = new System.Windows.Forms.Label();
            this.WinControlContainer13 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WinControlContainer12 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PartDescriptionLabel = new System.Windows.Forms.Label();
            this.WinControlContainer11 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label9 = new System.Windows.Forms.Label();
            this.WinControlContainer10 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label8 = new System.Windows.Forms.Label();
            this.WinControlContainer9 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label7 = new System.Windows.Forms.Label();
            this.WinControlContainer8 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label6 = new System.Windows.Forms.Label();
            this.WinControlContainer7 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label5 = new System.Windows.Forms.Label();
            this.WinControlContainer6 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.WinControlContainer5 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.RevisionLabel = new System.Windows.Forms.Label();
            this.WinControlContainer4 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label3 = new System.Windows.Forms.Label();
            this.WinControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.WinControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label2 = new System.Windows.Forms.Label();
            this.WinControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label1 = new System.Windows.Forms.Label();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
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
            this.Detail.HeightF = 692.7083F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XrPictureBox1
            // 
            this.XrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("XrPictureBox1.Image")));
            this.XrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 351.912F);
            this.XrPictureBox1.Name = "XrPictureBox1";
            this.XrPictureBox1.SizeF = new System.Drawing.SizeF(599.7917F, 329.4629F);
            this.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // RestPicture
            // 
            this.RestPicture.Image = ((System.Drawing.Image)(resources.GetObject("RestPicture.Image")));
            this.RestPicture.LocationFloat = new DevExpress.Utils.PointFloat(445.9167F, 6.944434F);
            this.RestPicture.Name = "RestPicture";
            this.RestPicture.SizeF = new System.Drawing.SizeF(461.69F, 68.63425F);
            this.RestPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.RestPicture.Visible = false;
            // 
            // picwip
            // 
            this.picwip.Image = ((System.Drawing.Image)(resources.GetObject("picwip.Image")));
            this.picwip.LocationFloat = new DevExpress.Utils.PointFloat(445.9167F, 6.944434F);
            this.picwip.Name = "picwip";
            this.picwip.SizeF = new System.Drawing.SizeF(461.69F, 68.63425F);
            this.picwip.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picwip.Visible = false;
            // 
            // picpartial
            // 
            this.picpartial.Image = ((System.Drawing.Image)(resources.GetObject("picpartial.Image")));
            this.picpartial.LocationFloat = new DevExpress.Utils.PointFloat(445.9167F, 6.944434F);
            this.picpartial.Name = "picpartial";
            this.picpartial.SizeF = new System.Drawing.SizeF(461.69F, 68.63425F);
            this.picpartial.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picpartial.Visible = false;
            // 
            // FolioLabel
            // 
            this.FolioLabel.AutoModule = true;
            this.FolioLabel.LocationFloat = new DevExpress.Utils.PointFloat(10.00012F, 151.4954F);
            this.FolioLabel.Name = "FolioLabel";
            this.FolioLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.FolioLabel.SizeF = new System.Drawing.SizeF(234.1667F, 40.70833F);
            this.FolioLabel.Symbology = code128Generator1;
            // 
            // WinControlContainer22
            // 
            this.WinControlContainer22.LocationFloat = new DevExpress.Utils.PointFloat(349.3751F, 161.9954F);
            this.WinControlContainer22.Name = "WinControlContainer22";
            this.WinControlContainer22.SizeF = new System.Drawing.SizeF(573.9584F, 53.2083F);
            this.WinControlContainer22.WinControl = this.PartNoLabel;
            // 
            // PartNoLabel
            // 
            this.PartNoLabel.BackColor = System.Drawing.Color.White;
            this.PartNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNoLabel.Location = new System.Drawing.Point(800, 76);
            this.PartNoLabel.Name = "PartNoLabel";
            this.PartNoLabel.Size = new System.Drawing.Size(551, 51);
            this.PartNoLabel.TabIndex = 1;
            this.PartNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer21
            // 
            this.WinControlContainer21.LocationFloat = new DevExpress.Utils.PointFloat(349.375F, 103.5788F);
            this.WinControlContainer21.Name = "WinControlContainer21";
            this.WinControlContainer21.SizeF = new System.Drawing.SizeF(573.9583F, 58.41666F);
            this.WinControlContainer21.WinControl = this.CustomerPartNoLabel;
            // 
            // CustomerPartNoLabel
            // 
            this.CustomerPartNoLabel.BackColor = System.Drawing.Color.White;
            this.CustomerPartNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPartNoLabel.Location = new System.Drawing.Point(800, 76);
            this.CustomerPartNoLabel.Name = "CustomerPartNoLabel";
            this.CustomerPartNoLabel.Size = new System.Drawing.Size(551, 56);
            this.CustomerPartNoLabel.TabIndex = 1;
            this.CustomerPartNoLabel.Text = "GT41857U";
            this.CustomerPartNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer20
            // 
            this.WinControlContainer20.LocationFloat = new DevExpress.Utils.PointFloat(788.9585F, 658.3749F);
            this.WinControlContainer20.Name = "WinControlContainer20";
            this.WinControlContainer20.SizeF = new System.Drawing.SizeF(134.375F, 23F);
            this.WinControlContainer20.WinControl = this.Label18;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.White;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(800, 76);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(129, 22);
            this.Label18.TabIndex = 1;
            this.Label18.Text = "ETI 025 REV. A";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer19
            // 
            this.WinControlContainer19.LocationFloat = new DevExpress.Utils.PointFloat(609.792F, 596.0872F);
            this.WinControlContainer19.Name = "WinControlContainer19";
            this.WinControlContainer19.SizeF = new System.Drawing.SizeF(313.5416F, 41.5F);
            this.WinControlContainer19.WinControl = this.LineNameLabel;
            // 
            // LineNameLabel
            // 
            this.LineNameLabel.BackColor = System.Drawing.Color.White;
            this.LineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNameLabel.Location = new System.Drawing.Point(800, 76);
            this.LineNameLabel.Name = "LineNameLabel";
            this.LineNameLabel.Size = new System.Drawing.Size(301, 40);
            this.LineNameLabel.TabIndex = 1;
            this.LineNameLabel.Text = "SERVICE PARTS";
            this.LineNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer18
            // 
            this.WinControlContainer18.LocationFloat = new DevExpress.Utils.PointFloat(609.792F, 558.5037F);
            this.WinControlContainer18.Name = "WinControlContainer18";
            this.WinControlContainer18.SizeF = new System.Drawing.SizeF(313.5415F, 37.58337F);
            this.WinControlContainer18.WinControl = this.Label16;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.White;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(800, 76);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(301, 36);
            this.Label16.TabIndex = 1;
            this.Label16.Text = "ASSEMBLY LINE:";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer17
            // 
            this.WinControlContainer17.LocationFloat = new DevExpress.Utils.PointFloat(609.7917F, 500.1704F);
            this.WinControlContainer17.Name = "WinControlContainer17";
            this.WinControlContainer17.SizeF = new System.Drawing.SizeF(313.5416F, 58.33337F);
            this.WinControlContainer17.WinControl = this.QuantityLabel;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.BackColor = System.Drawing.Color.White;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(800, 76);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(301, 56);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "60";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer16
            // 
            this.WinControlContainer16.LocationFloat = new DevExpress.Utils.PointFloat(609.7917F, 458.4203F);
            this.WinControlContainer16.Name = "WinControlContainer16";
            this.WinControlContainer16.SizeF = new System.Drawing.SizeF(313.5416F, 41.74994F);
            this.WinControlContainer16.WinControl = this.Label14;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(800, 76);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(301, 40);
            this.Label14.TabIndex = 1;
            this.Label14.Text = "PARTS PER PALLET:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer15
            // 
            this.WinControlContainer15.LocationFloat = new DevExpress.Utils.PointFloat(609.7917F, 416.6703F);
            this.WinControlContainer15.Name = "WinControlContainer15";
            this.WinControlContainer15.SizeF = new System.Drawing.SizeF(313.5416F, 41.74994F);
            this.WinControlContainer15.WinControl = this.JulianDateLabel;
            // 
            // JulianDateLabel
            // 
            this.JulianDateLabel.BackColor = System.Drawing.Color.White;
            this.JulianDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JulianDateLabel.Location = new System.Drawing.Point(800, 76);
            this.JulianDateLabel.Name = "JulianDateLabel";
            this.JulianDateLabel.Size = new System.Drawing.Size(301, 40);
            this.JulianDateLabel.TabIndex = 1;
            this.JulianDateLabel.Text = "1150";
            this.JulianDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer14
            // 
            this.WinControlContainer14.LocationFloat = new DevExpress.Utils.PointFloat(609.7917F, 310.162F);
            this.WinControlContainer14.Name = "WinControlContainer14";
            this.WinControlContainer14.SizeF = new System.Drawing.SizeF(313.5417F, 40.70837F);
            this.WinControlContainer14.WinControl = this.POLabel;
            // 
            // POLabel
            // 
            this.POLabel.BackColor = System.Drawing.Color.White;
            this.POLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POLabel.Location = new System.Drawing.Point(800, 76);
            this.POLabel.Name = "POLabel";
            this.POLabel.Size = new System.Drawing.Size(301, 39);
            this.POLabel.TabIndex = 1;
            this.POLabel.Text = "-";
            this.POLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer13
            // 
            this.WinControlContainer13.LocationFloat = new DevExpress.Utils.PointFloat(124.5834F, 310.162F);
            this.WinControlContainer13.Name = "WinControlContainer13";
            this.WinControlContainer13.SizeF = new System.Drawing.SizeF(346.6667F, 41.74994F);
            this.WinControlContainer13.WinControl = this.DateLabel;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.White;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(800, 76);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(333, 40);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "24-APRIL-2020";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer12
            // 
            this.WinControlContainer12.LocationFloat = new DevExpress.Utils.PointFloat(244.1668F, 262.162F);
            this.WinControlContainer12.Name = "WinControlContainer12";
            this.WinControlContainer12.SizeF = new System.Drawing.SizeF(679.1667F, 46.95834F);
            this.WinControlContainer12.WinControl = this.PartDescriptionLabel;
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.Location = new System.Drawing.Point(800, 76);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(652, 45);
            this.PartDescriptionLabel.TabIndex = 1;
            this.PartDescriptionLabel.Text = "SEALS";
            this.PartDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer11
            // 
            this.WinControlContainer11.LocationFloat = new DevExpress.Utils.PointFloat(609.792F, 374.9204F);
            this.WinControlContainer11.Name = "WinControlContainer11";
            this.WinControlContainer11.SizeF = new System.Drawing.SizeF(234.1667F, 41.75F);
            this.WinControlContainer11.WinControl = this.Label9;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(800, 76);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(225, 40);
            this.Label9.TabIndex = 1;
            this.Label9.Text = "LOT NUMBER:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer10
            // 
            this.WinControlContainer10.LocationFloat = new DevExpress.Utils.PointFloat(471.25F, 309.1203F);
            this.WinControlContainer10.Name = "WinControlContainer10";
            this.WinControlContainer10.SizeF = new System.Drawing.SizeF(138.5417F, 40.70837F);
            this.WinControlContainer10.WinControl = this.Label8;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(800, 76);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(133, 39);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "P.O. # :";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer9
            // 
            this.WinControlContainer9.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 310.162F);
            this.WinControlContainer9.Name = "WinControlContainer9";
            this.WinControlContainer9.SizeF = new System.Drawing.SizeF(114.5833F, 41.75F);
            this.WinControlContainer9.WinControl = this.Label7;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(800, 76);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(110, 40);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "DATE:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer8
            // 
            this.WinControlContainer8.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 262.162F);
            this.WinControlContainer8.Name = "WinControlContainer8";
            this.WinControlContainer8.SizeF = new System.Drawing.SizeF(234.1667F, 46.95834F);
            this.WinControlContainer8.WinControl = this.Label6;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(800, 76);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(225, 45);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "DESCRIPTION:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer7
            // 
            this.WinControlContainer7.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 215.2037F);
            this.WinControlContainer7.Name = "WinControlContainer7";
            this.WinControlContainer7.SizeF = new System.Drawing.SizeF(159.375F, 45.91669F);
            this.WinControlContainer7.WinControl = this.Label5;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(800, 76);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(153, 44);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "SHIP TO:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer6
            // 
            this.WinControlContainer6.LocationFloat = new DevExpress.Utils.PointFloat(169.375F, 215.2037F);
            this.WinControlContainer6.Name = "WinControlContainer6";
            this.WinControlContainer6.SizeF = new System.Drawing.SizeF(753.9585F, 45.91669F);
            this.WinControlContainer6.WinControl = this.DestinationLabel;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.BackColor = System.Drawing.Color.White;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(800, 76);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(724, 44);
            this.DestinationLabel.TabIndex = 1;
            this.DestinationLabel.Text = "GTINC";
            this.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinControlContainer5
            // 
            this.WinControlContainer5.LocationFloat = new DevExpress.Utils.PointFloat(823.3334F, 78.5787F);
            this.WinControlContainer5.Name = "WinControlContainer5";
            this.WinControlContainer5.SizeF = new System.Drawing.SizeF(100F, 25.00009F);
            this.WinControlContainer5.WinControl = this.RevisionLabel;
            // 
            // RevisionLabel
            // 
            this.RevisionLabel.BackColor = System.Drawing.Color.White;
            this.RevisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisionLabel.Location = new System.Drawing.Point(800, 76);
            this.RevisionLabel.Name = "RevisionLabel";
            this.RevisionLabel.Size = new System.Drawing.Size(96, 24);
            this.RevisionLabel.TabIndex = 1;
            this.RevisionLabel.Text = "B";
            this.RevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer4
            // 
            this.WinControlContainer4.LocationFloat = new DevExpress.Utils.PointFloat(349.3751F, 78.5787F);
            this.WinControlContainer4.Name = "WinControlContainer4";
            this.WinControlContainer4.SizeF = new System.Drawing.SizeF(473.9583F, 25.00009F);
            this.WinControlContainer4.WinControl = this.Label3;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(429, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(455, 24);
            this.Label3.TabIndex = 89;
            this.Label3.Text = "PART NUMBER:                                       REV.";
            // 
            // WinControlContainer3
            // 
            this.WinControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(66.13432F, 36.54168F);
            this.WinControlContainer3.Name = "WinControlContainer3";
            this.WinControlContainer3.SizeF = new System.Drawing.SizeF(103.2407F, 78.49544F);
            this.WinControlContainer3.WinControl = this.PictureBox7;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = global::GT.Trace.Labels.Templates.Properties.Resources.LOGO_GT2;
            this.PictureBox7.Location = new System.Drawing.Point(60, 57);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(99, 75);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 183;
            this.PictureBox7.TabStop = false;
            // 
            // WinControlContainer2
            // 
            this.WinControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 116.625F);
            this.WinControlContainer2.Name = "WinControlContainer2";
            this.WinControlContainer2.SizeF = new System.Drawing.SizeF(232.4074F, 34.87047F);
            this.WinControlContainer2.WinControl = this.Label2;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.Location = new System.Drawing.Point(1, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(223, 33);
            this.Label2.TabIndex = 87;
            this.Label2.Text = "302 Lorenaly Drive, Suite E.\nBrownsville, Tx. 78526 USA\n";
            // 
            // WinControlContainer1
            // 
            this.WinControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.WinControlContainer1.Name = "WinControlContainer1";
            this.WinControlContainer1.SizeF = new System.Drawing.SizeF(416.0417F, 36.54167F);
            this.WinControlContainer1.WinControl = this.Label1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(399, 35);
            this.Label1.TabIndex = 87;
            this.Label1.Text = "ASSEMBLED IN MEXICO BY";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // WipLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(80, 80, 50, 50);
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
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer1;
        internal Label Label1;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer2;
        internal Label Label2;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer3;
        internal PictureBox PictureBox7;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer4;
        internal Label Label3;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer5;
        internal Label RevisionLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer6;
        internal Label DestinationLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer7;
        internal Label Label5;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer8;
        internal Label Label6;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer9;
        internal Label Label7;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer10;
        internal Label Label8;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer11;
        internal Label Label9;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer12;
        internal Label PartDescriptionLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer15;
        internal Label JulianDateLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer14;
        internal Label POLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer13;
        internal Label DateLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer16;
        internal Label Label14;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer17;
        internal Label QuantityLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer18;
        internal Label Label16;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer20;
        internal Label Label18;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer19;
        internal Label LineNameLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer22;
        internal Label PartNoLabel;
        internal DevExpress.XtraReports.UI.WinControlContainer WinControlContainer21;
        internal Label CustomerPartNoLabel;
        internal DevExpress.XtraReports.UI.XRBarCode FolioLabel;
        internal DevExpress.XtraReports.UI.XRPictureBox picpartial;
        internal DevExpress.XtraReports.UI.XRPictureBox picwip;
        internal DevExpress.XtraReports.UI.XRPictureBox RestPicture;
        internal DevExpress.XtraReports.UI.XRPictureBox XrPictureBox1;
    }

}