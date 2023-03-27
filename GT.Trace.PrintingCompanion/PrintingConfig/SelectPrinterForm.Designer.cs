
namespace GT.Trace.PrintingCompanion
{
    partial class SelectPrinterForm
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
            this.InstalledPrintersListBox = new System.Windows.Forms.ListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstalledPrintersListBox
            // 
            this.InstalledPrintersListBox.FormattingEnabled = true;
            this.InstalledPrintersListBox.Location = new System.Drawing.Point(12, 12);
            this.InstalledPrintersListBox.Name = "InstalledPrintersListBox";
            this.InstalledPrintersListBox.Size = new System.Drawing.Size(335, 147);
            this.InstalledPrintersListBox.TabIndex = 0;
            this.InstalledPrintersListBox.SelectedIndexChanged += new System.EventHandler(this.InstalledPrintersListBox_SelectedIndexChanged);
            this.InstalledPrintersListBox.DoubleClick += new System.EventHandler(this.InstalledPrintersListBox_DoubleClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 180);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(272, 180);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(12, 162);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(335, 15);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "label1";
            // 
            // SelectPrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 215);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InstalledPrintersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectPrinterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Printer";
            this.Load += new System.EventHandler(this.SelectPrinterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InstalledPrintersListBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}