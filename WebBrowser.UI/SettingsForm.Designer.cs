
namespace WebBrowser.UI
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.homePageText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.dropBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // homePageText
            // 
            this.homePageText.Font = new System.Drawing.Font("Apercu Pro Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageText.Location = new System.Drawing.Point(200, 56);
            this.homePageText.Name = "homePageText";
            this.homePageText.Size = new System.Drawing.Size(316, 26);
            this.homePageText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Reservation Wide Blk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOME PAGE:";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(118, 219);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(119, 57);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Reservation Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(323, 219);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 57);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchLbl.Font = new System.Drawing.Font("Reservation Wide Blk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(113, 123);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(94, 16);
            this.searchLbl.TabIndex = 5;
            this.searchLbl.Text = "SEARCH:";
            // 
            // dropBox
            // 
            this.dropBox.Font = new System.Drawing.Font("Apercu Pro Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropBox.FormattingEnabled = true;
            this.dropBox.Items.AddRange(new object[] {
            "Google",
            "DuckDuckGo",
            "Bing",
            "Yahoo"});
            this.dropBox.Location = new System.Drawing.Point(268, 121);
            this.dropBox.Name = "dropBox";
            this.dropBox.Size = new System.Drawing.Size(179, 26);
            this.dropBox.TabIndex = 1;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 302);
            this.Controls.Add(this.dropBox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsForm";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homePageText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.ComboBox dropBox;
    }
}