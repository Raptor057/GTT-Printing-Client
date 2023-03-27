
namespace GT.Trace.PrintingCompanion
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PrintingRequestQueueList = new System.Windows.Forms.ListBox();
            this.QueueProcessingTimer = new System.Windows.Forms.Timer(this.components);
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AppNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewEventLogMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintingRequestsMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PrintingRequestList = new System.Windows.Forms.ListBox();
            this.PrintingConfigurationPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintingRequestQueueList
            // 
            this.PrintingRequestQueueList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintingRequestQueueList.FormattingEnabled = true;
            this.PrintingRequestQueueList.Location = new System.Drawing.Point(12, 61);
            this.PrintingRequestQueueList.Name = "PrintingRequestQueueList";
            this.PrintingRequestQueueList.Size = new System.Drawing.Size(242, 277);
            this.PrintingRequestQueueList.TabIndex = 3;
            // 
            // QueueProcessingTimer
            // 
            this.QueueProcessingTimer.Interval = 30000;
            this.QueueProcessingTimer.Tick += new System.EventHandler(this.QueueProcessingTimer_Tick);
            // 
            // EventsListBox
            // 
            this.EventsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(0, 346);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(884, 82);
            this.EventsListBox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AppNotifyIcon
            // 
            this.AppNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("AppNotifyIcon.Icon")));
            this.AppNotifyIcon.Text = "Printing Companion";
            this.AppNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AppNotifyIcon_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuOption});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ExitMenuOption
            // 
            this.ExitMenuOption.Name = "ExitMenuOption";
            this.ExitMenuOption.Size = new System.Drawing.Size(93, 22);
            this.ExitMenuOption.Text = "E&xit";
            this.ExitMenuOption.Click += new System.EventHandler(this.ExitMenuOption_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewEventLogMenuOption,
            this.PrintingRequestsMenuOption});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // ViewEventLogMenuOption
            // 
            this.ViewEventLogMenuOption.Name = "ViewEventLogMenuOption";
            this.ViewEventLogMenuOption.Size = new System.Drawing.Size(175, 22);
            this.ViewEventLogMenuOption.Text = "&Event log...";
            this.ViewEventLogMenuOption.Click += new System.EventHandler(this.ViewEventLogMenuOption_Click);
            // 
            // PrintingRequestsMenuOption
            // 
            this.PrintingRequestsMenuOption.Name = "PrintingRequestsMenuOption";
            this.PrintingRequestsMenuOption.Size = new System.Drawing.Size(175, 22);
            this.PrintingRequestsMenuOption.Text = "&Printing Requests...";
            this.PrintingRequestsMenuOption.Click += new System.EventHandler(this.PrintingRequestsMenuOption_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PrintingRequestList
            // 
            this.PrintingRequestList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintingRequestList.FormattingEnabled = true;
            this.PrintingRequestList.Location = new System.Drawing.Point(260, 61);
            this.PrintingRequestList.Name = "PrintingRequestList";
            this.PrintingRequestList.Size = new System.Drawing.Size(264, 277);
            this.PrintingRequestList.TabIndex = 10;
            this.PrintingRequestList.SelectedIndexChanged += new System.EventHandler(this.PrintingRequestList_SelectedIndexChanged);
            // 
            // propertyGrid1
            // 
            this.PrintingConfigurationPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintingConfigurationPropertyGrid.Location = new System.Drawing.Point(530, 52);
            this.PrintingConfigurationPropertyGrid.Name = "propertyGrid1";
            this.PrintingConfigurationPropertyGrid.Size = new System.Drawing.Size(342, 286);
            this.PrintingConfigurationPropertyGrid.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.PrintingRequestList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PrintingConfigurationPropertyGrid);
            this.Controls.Add(this.EventsListBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PrintingRequestQueueList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Printing Companion";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox PrintingRequestQueueList;
        private System.Windows.Forms.Timer QueueProcessingTimer;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PropertyGrid PrintingConfigurationPropertyGrid;
        private System.Windows.Forms.NotifyIcon AppNotifyIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuOption;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewEventLogMenuOption;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem PrintingRequestsMenuOption;
        private System.Windows.Forms.ListBox PrintingRequestList;
    }
}

