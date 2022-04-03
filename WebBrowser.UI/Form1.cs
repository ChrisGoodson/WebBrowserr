using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser;


namespace WebBrowser.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AboutTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chris Goodson, fzg0021");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           webBrowser1.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            string url = AddressTextBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                TabPage.Text = url;
                WebBrowserControl.Navigate(url);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = AddressTextBox.Text;

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    TabPage.Text = url;
                    webBrowser1.Navigate(url);
                }
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string url = AddressTextBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                TabPage.Text = url;
                WebBrowserControl.Navigate(url);
            }
        }

        private void BookmarkButton_Click(object sender, EventArgs e)
        {

        }

        private void TabControl_Click(object sender, EventArgs e)
        {

        }

        private void WebBrowserControl_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void AddressTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
