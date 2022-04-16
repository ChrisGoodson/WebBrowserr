
namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkManagerForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bookSrchBtn = new System.Windows.Forms.Button();
            this.bookSrchBox = new System.Windows.Forms.TextBox();
            this.bookDelBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 74);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(945, 536);
            this.listBox1.TabIndex = 4;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // bookSrchBtn
            // 
            this.bookSrchBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookSrchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookSrchBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSrchBtn.Location = new System.Drawing.Point(618, 37);
            this.bookSrchBtn.Name = "bookSrchBtn";
            this.bookSrchBtn.Size = new System.Drawing.Size(101, 27);
            this.bookSrchBtn.TabIndex = 1;
            this.bookSrchBtn.Text = "search ♥";
            this.bookSrchBtn.UseVisualStyleBackColor = false;
            this.bookSrchBtn.Click += new System.EventHandler(this.bookSrchBtn_Click);
            // 
            // bookSrchBox
            // 
            this.bookSrchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookSrchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookSrchBox.Location = new System.Drawing.Point(10, 37);
            this.bookSrchBox.Name = "bookSrchBox";
            this.bookSrchBox.Size = new System.Drawing.Size(602, 27);
            this.bookSrchBox.TabIndex = 0;
            this.bookSrchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bookSrchBox_KeyUp);
            // 
            // bookDelBtn
            // 
            this.bookDelBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookDelBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDelBtn.Location = new System.Drawing.Point(725, 37);
            this.bookDelBtn.Name = "bookDelBtn";
            this.bookDelBtn.Size = new System.Drawing.Size(101, 27);
            this.bookDelBtn.TabIndex = 2;
            this.bookDelBtn.Text = "delete";
            this.bookDelBtn.UseVisualStyleBackColor = false;
            this.bookDelBtn.Click += new System.EventHandler(this.bookDelBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(832, 37);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(101, 27);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.bookDelBtn);
            this.Controls.Add(this.bookSrchBtn);
            this.Controls.Add(this.bookSrchBox);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookmarkManagerForm";
            this.Text = "bookmarks manager";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bookSrchBtn;
        private System.Windows.Forms.TextBox bookSrchBox;
        private System.Windows.Forms.Button bookDelBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}