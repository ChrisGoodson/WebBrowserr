
namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryManagerForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.histSrchBox = new System.Windows.Forms.TextBox();
            this.histSrchBtn = new System.Windows.Forms.Button();
            this.histDelBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(945, 536);
            this.listBox1.TabIndex = 5;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // histSrchBox
            // 
            this.histSrchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.histSrchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histSrchBox.Location = new System.Drawing.Point(10, 37);
            this.histSrchBox.Name = "histSrchBox";
            this.histSrchBox.Size = new System.Drawing.Size(421, 27);
            this.histSrchBox.TabIndex = 0;
            this.histSrchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.histSrchBox_KeyUp);
            // 
            // histSrchBtn
            // 
            this.histSrchBtn.BackColor = System.Drawing.Color.Transparent;
            this.histSrchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.histSrchBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histSrchBtn.Location = new System.Drawing.Point(437, 37);
            this.histSrchBtn.Name = "histSrchBtn";
            this.histSrchBtn.Size = new System.Drawing.Size(101, 27);
            this.histSrchBtn.TabIndex = 1;
            this.histSrchBtn.Text = "search ♥";
            this.toolTip1.SetToolTip(this.histSrchBtn, "search history");
            this.histSrchBtn.UseVisualStyleBackColor = false;
            this.histSrchBtn.Click += new System.EventHandler(this.histSrchBtn_Click);
            // 
            // histDelBtn
            // 
            this.histDelBtn.BackColor = System.Drawing.Color.Transparent;
            this.histDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.histDelBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histDelBtn.Location = new System.Drawing.Point(544, 37);
            this.histDelBtn.Name = "histDelBtn";
            this.histDelBtn.Size = new System.Drawing.Size(101, 27);
            this.histDelBtn.TabIndex = 2;
            this.histDelBtn.Text = "delete";
            this.toolTip1.SetToolTip(this.histDelBtn, "delete selected history");
            this.histDelBtn.UseVisualStyleBackColor = false;
            this.histDelBtn.Click += new System.EventHandler(this.histDelBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(651, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "clear history";
            this.toolTip1.SetToolTip(this.button1, "clear all history");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(832, 37);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(101, 27);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.Text = "refresh";
            this.toolTip1.SetToolTip(this.refreshBtn, "refresh page");
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.histDelBtn);
            this.Controls.Add(this.histSrchBtn);
            this.Controls.Add(this.histSrchBox);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistoryManagerForm";
            this.Text = "history manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox histSrchBox;
        private System.Windows.Forms.Button histSrchBtn;
        private System.Windows.Forms.Button histDelBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}