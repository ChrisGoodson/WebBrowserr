namespace WebBrowser.UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookmarksToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageHistoryToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPages1 = new WebBrowser.UI.PageControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.toolsItem,
            this.helpItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabItem,
            this.closeTabItem,
            this.saveItem,
            this.printItem,
            this.exitItem});
            this.fileItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(46, 20);
            this.fileItem.Text = "FILE";
            // 
            // newTabItem
            // 
            this.newTabItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTabItem.Name = "newTabItem";
            this.newTabItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabItem.Size = new System.Drawing.Size(271, 22);
            this.newTabItem.Text = "new tab";
            this.newTabItem.Click += new System.EventHandler(this.newTabItem_Click);
            // 
            // closeTabItem
            // 
            this.closeTabItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeTabItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTabItem.Name = "closeTabItem";
            this.closeTabItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeTabItem.Size = new System.Drawing.Size(271, 22);
            this.closeTabItem.Text = "close current tab";
            this.closeTabItem.Click += new System.EventHandler(this.closeTabItem_Click);
            // 
            // saveItem
            // 
            this.saveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItem.Name = "saveItem";
            this.saveItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveItem.Size = new System.Drawing.Size(271, 22);
            this.saveItem.Text = "save page as HTML";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // printItem
            // 
            this.printItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printItem.Name = "printItem";
            this.printItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printItem.Size = new System.Drawing.Size(271, 22);
            this.printItem.Text = "print page";
            this.printItem.Click += new System.EventHandler(this.printItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitItem.Name = "exitItem";
            this.exitItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitItem.Size = new System.Drawing.Size(271, 22);
            this.exitItem.Text = "exit browser";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // toolsItem
            // 
            this.toolsItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBookmarksToolStrip,
            this.toolStripSeparator1,
            this.manageHistoryToolStrip,
            this.clearHistoryToolStripMenuItem,
            this.prefItem});
            this.toolsItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsItem.Name = "toolsItem";
            this.toolsItem.Size = new System.Drawing.Size(64, 20);
            this.toolsItem.Text = "TOOLS";
            // 
            // manageBookmarksToolStrip
            // 
            this.manageBookmarksToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageBookmarksToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBookmarksToolStrip.Name = "manageBookmarksToolStrip";
            this.manageBookmarksToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.manageBookmarksToolStrip.Size = new System.Drawing.Size(270, 22);
            this.manageBookmarksToolStrip.Text = "manage bookmarks";
            this.manageBookmarksToolStrip.Click += new System.EventHandler(this.manageBookmarksToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // manageHistoryToolStrip
            // 
            this.manageHistoryToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageHistoryToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageHistoryToolStrip.Name = "manageHistoryToolStrip";
            this.manageHistoryToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.manageHistoryToolStrip.Size = new System.Drawing.Size(270, 22);
            this.manageHistoryToolStrip.Text = "manage history";
            this.manageHistoryToolStrip.Click += new System.EventHandler(this.manageHistoryToolStrip_Click);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearHistoryToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.clearHistoryToolStripMenuItem.Text = "clear history";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // prefItem
            // 
            this.prefItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prefItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefItem.Name = "prefItem";
            this.prefItem.Size = new System.Drawing.Size(270, 22);
            this.prefItem.Text = "settings";
            this.prefItem.Click += new System.EventHandler(this.prefItem_Click);
            // 
            // helpItem
            // 
            this.helpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpItem.Name = "helpItem";
            this.helpItem.Size = new System.Drawing.Size(54, 20);
            this.helpItem.Text = "HELP";
            // 
            // aboutItem
            // 
            this.aboutItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(108, 22);
            this.aboutItem.Text = "about";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPages1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1176, 772);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TAB 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPages1
            // 
            this.tabPages1.AutoSize = true;
            this.tabPages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages1.Location = new System.Drawing.Point(3, 3);
            this.tabPages1.Name = "tabPages1";
            this.tabPages1.Size = new System.Drawing.Size(1170, 766);
            this.tabPages1.TabIndex = 0;
            this.tabPages1.Load += new System.EventHandler(this.tabPages1_Load);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(2, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 800);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            this.tabControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseMove);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1176, 772);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    ➕";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 824);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "luminati browser @_@";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem newTabItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem printItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem toolsItem;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStrip;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.TabPage tabPage1;
        public PageControl tabPages1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem prefItem;
    }
}