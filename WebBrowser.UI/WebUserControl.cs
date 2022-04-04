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
    public partial class WebUserControl : UserControl
    {
        public WebUserControl()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            //webBrowser.GoHome();
            Navigate("www.auburn.com");
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Navigate(AddressTextBox.Text);
        }


        private void webBrowser1_Navigated(object sender,
            WebBrowserNavigatedEventArgs e)
        {
            AddressTextBox.Text = webBrowser.Url.ToString();
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {

        }

        public void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyValue == (char)Keys.Return)
            {
                Navigate(AddressTextBox.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void AddressTextBox_Click_1(object sender, EventArgs e)
        {

        }
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                    !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void BookmarkButton_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
