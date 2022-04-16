using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class settingsForm : Form
    {
        public static string HomePage = "https://www.google.com";
        public static string SearchEngine = "https://www.google.com/search?q=";
        public settingsForm()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(homePageText.Text))
            {
            }
            else
            {
                HomePage = homePageText.Text;
            }

            this.Close();

            DialogResult dlog = MessageBox.Show("your settings have been updated :)", "settings updated", MessageBoxButtons.OK);


        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}