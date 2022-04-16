namespace WebBrowser.UI
{
    partial class PageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backBtn = new System.Windows.Forms.ToolStripButton();
            this.forwardBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.homeBtn = new System.Windows.Forms.ToolStripButton();
            this.addressBox = new System.Windows.Forms.ToolStripTextBox();
            this.goBtn = new System.Windows.Forms.ToolStripButton();
            this.bookmarksBtn = new System.Windows.Forms.ToolStripButton();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.urlStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Font = new System.Drawing.Font("Apercu Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBtn,
            this.forwardBtn,
            this.refreshBtn,
            this.homeBtn,
            this.addressBox,
            this.goBtn,
            this.bookmarksBtn,
            this.searchBox,
            this.searchBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 1, 10);
            this.toolStrip1.Size = new System.Drawing.Size(886, 47);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backBtn
            // 
            this.backBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 24);
            this.backBtn.Text = "Go Back";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtn.Image")));
            this.forwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(23, 24);
            this.forwardBtn.Text = "Go Forward";
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(23, 24);
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeBtn.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(23, 24);
            this.homeBtn.Text = "Go Home";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(600, 27);
            this.addressBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addressBox_KeyUp);
            // 
            // goBtn
            // 
            this.goBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBtn.Image = ((System.Drawing.Image)(resources.GetObject("goBtn.Image")));
            this.goBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBtn.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(23, 24);
            this.goBtn.Text = "Go";
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // bookmarksBtn
            // 
            this.bookmarksBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarksBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookmarksBtn.Image")));
            this.bookmarksBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarksBtn.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.bookmarksBtn.Name = "bookmarksBtn";
            this.bookmarksBtn.Size = new System.Drawing.Size(23, 24);
            this.bookmarksBtn.Text = "Bookmarks";
            this.bookmarksBtn.Click += new System.EventHandler(this.bookmarksBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Apercu Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Margin = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 23);
            this.searchBox.Text = "search";
            this.searchBox.ToolTipText = "enter search topic here";
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(23, 20);
            this.searchBtn.Text = "toolStripButton1";
            this.searchBtn.ToolTipText = "search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(886, 518);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip.BackgroundImage")));
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLbl,
            this.urlStatusLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(886, 27);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Font = new System.Drawing.Font("Apercu Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.progressBar.MarqueeAnimationSpeed = 80;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 15);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // statusLbl
            // 
            this.statusLbl.ActiveLinkColor = System.Drawing.Color.PeachPuff;
            this.statusLbl.Font = new System.Drawing.Font("Apercu Pro Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(49, 22);
            this.statusLbl.Text = "status";
            // 
            // urlStatusLbl
            // 
            this.urlStatusLbl.Font = new System.Drawing.Font("Apercu Pro Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlStatusLbl.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.urlStatusLbl.Name = "urlStatusLbl";
            this.urlStatusLbl.Size = new System.Drawing.Size(28, 22);
            this.urlStatusLbl.Text = "url";
            // 
            // PageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PageControl";
            this.Size = new System.Drawing.Size(886, 565);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripButton backBtn;
        public System.Windows.Forms.ToolStripButton forwardBtn;
        public System.Windows.Forms.ToolStripButton refreshBtn;
        public System.Windows.Forms.ToolStripButton homeBtn;
        public System.Windows.Forms.ToolStripTextBox addressBox;
        public System.Windows.Forms.ToolStripButton goBtn;
        public System.Windows.Forms.ToolStripButton bookmarksBtn;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.ToolStripStatusLabel urlStatusLbl;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripButton searchBtn;
    }
}