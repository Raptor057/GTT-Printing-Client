
using System.Windows.Forms;

namespace GT.Trace.Labels.Templates
{
    partial class MaterialReturnLabel
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

        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.winControlContainer6 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.WinControlContainer5 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.Label11 = new System.Windows.Forms.Label();
            this.bareti = new DevExpress.XtraReports.UI.XRBarCode();
            this.WinControlContainer4 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.lblempleado = new System.Windows.Forms.Label();
            this.WinControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.LBLcomponente = new System.Windows.Forms.Label();
            this.WinControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.lblmotivo = new System.Windows.Forms.Label();
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
            this.winControlContainer6,
            this.WinControlContainer5,
            this.bareti,
            this.WinControlContainer4,
            this.WinControlContainer3,
            this.WinControlContainer2,
            this.WinControlContainer1});
            this.Detail.HeightF = 312.5F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // winControlContainer6
            // 
            this.winControlContainer6.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 267.1667F);
            this.winControlContainer6.Name = "winControlContainer6";
            this.winControlContainer6.SizeF = new System.Drawing.SizeF(259.9999F, 20.25F);
            this.winControlContainer6.WinControl = this.label1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 19);
            this.label1.TabIndex = 203;
            this.label1.Text = "LUBRICAR FLECHA O TSG MQ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinControlContainer5
            // 
            this.WinControlContainer5.LocationFloat = new DevExpress.Utils.PointFloat(170F, 287.4167F);
            this.WinControlContainer5.Name = "WinControlContainer5";
            this.WinControlContainer5.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.WinControlContainer5.WinControl = this.Label11;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(166, 336);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(96, 22);
            this.Label11.TabIndex = 202;
            this.Label11.Text = "ETI-024 Rev. A";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bareti
            // 
            this.bareti.AutoModule = true;
            this.bareti.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 59.79168F);
            this.bareti.Name = "bareti";
            this.bareti.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.bareti.SizeF = new System.Drawing.SizeF(259.9999F, 63.29168F);
            this.bareti.Symbology = dataMatrixGS1Generator1;
            // 
            // WinControlContainer4
            // 
            this.WinControlContainer4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 165.6668F);
            this.WinControlContainer4.Name = "WinControlContainer4";
            this.WinControlContainer4.SizeF = new System.Drawing.SizeF(259.9999F, 101.4999F);
            this.WinControlContainer4.WinControl = this.lblempleado;
            // 
            // lblempleado
            // 
            this.lblempleado.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblempleado.ForeColor = System.Drawing.Color.Black;
            this.lblempleado.Location = new System.Drawing.Point(5, 238);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(250, 97);
            this.lblempleado.TabIndex = 133;
            // 
            // WinControlContainer3
            // 
            this.WinControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 128.0834F);
            this.WinControlContainer3.Name = "WinControlContainer3";
            this.WinControlContainer3.SizeF = new System.Drawing.SizeF(260F, 37.58336F);
            this.WinControlContainer3.WinControl = this.LBLcomponente;
            // 
            // LBLcomponente
            // 
            this.LBLcomponente.Font = new System.Drawing.Font("Tahoma", 15F);
            this.LBLcomponente.ForeColor = System.Drawing.Color.Black;
            this.LBLcomponente.Location = new System.Drawing.Point(12, 171);
            this.LBLcomponente.Name = "LBLcomponente";
            this.LBLcomponente.Size = new System.Drawing.Size(250, 36);
            this.LBLcomponente.TabIndex = 132;
            // 
            // WinControlContainer2
            // 
            this.WinControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(79.58333F, 0F);
            this.WinControlContainer2.Name = "WinControlContainer2";
            this.WinControlContainer2.SizeF = new System.Drawing.SizeF(190.4166F, 43.41668F);
            this.WinControlContainer2.WinControl = this.lblmotivo;
            // 
            // lblmotivo
            // 
            this.lblmotivo.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblmotivo.Location = new System.Drawing.Point(-5, 38);
            this.lblmotivo.Name = "lblmotivo";
            this.lblmotivo.Size = new System.Drawing.Size(183, 42);
            this.lblmotivo.TabIndex = 5;
            this.lblmotivo.Text = "RETORNO";
            this.lblmotivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinControlContainer1
            // 
            this.WinControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(20.41666F, 10.00001F);
            this.WinControlContainer1.Name = "WinControlContainer1";
            this.WinControlContainer1.SizeF = new System.Drawing.SizeF(46.87501F, 33.41667F);
            this.WinControlContainer1.WinControl = this.PictureBox7;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = global::GT.Trace.Labels.Templates.Properties.Resources.LOGO_GT2;
            this.PictureBox7.Location = new System.Drawing.Point(17, 3);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(45, 32);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 201;
            this.PictureBox7.TabStop = false;
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
            this.BottomMargin.HeightF = 1.041667F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // MaterialReturnLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 1);
            this.PageHeight = 320;
            this.PageWidth = 280;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;

        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.WinControlContainer WinControlContainer1;
        private PictureBox PictureBox7;

        private DevExpress.XtraReports.UI.WinControlContainer WinControlContainer2;
        private Label lblmotivo;

        private DevExpress.XtraReports.UI.WinControlContainer WinControlContainer3;
        private Label LBLcomponente;

        private DevExpress.XtraReports.UI.WinControlContainer WinControlContainer4;
        private Label lblempleado;

        private DevExpress.XtraReports.UI.XRBarCode bareti;
        private DevExpress.XtraReports.UI.WinControlContainer WinControlContainer5;
        private Label Label11;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer6;
        private Label label1;
    }
}