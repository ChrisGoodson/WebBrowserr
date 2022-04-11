using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Text.RegularExpressions;

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
            Navigate("www.google.com");
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

            addHistory(address);
        }

        private void BookmarkButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            var bookmarks = BookmarkManager.getItems();
            var item = new BookmarkItem();
            item.Title = webBrowser.DocumentTitle;
            item.URL = AddressTextBox.Text;

            foreach (var bookmark in bookmarks)
            {
                if (bookmark.Title.Equals(webBrowser.DocumentTitle) || bookmark.URL.Equals(AddressTextBox.Text))
                {
                    MessageBox.Show("Bookmark already added.");
                    found = true;
                }
                else
                {
                    found = false;
                }
            }
            if (!found)
            {
                BookmarkManager.addItem(item);
            }
        }
        private void addHistory(string address)
        {

            var site = new HistoryItem();
            //site.Title = webBrowser.DocumentTitle; wasn't working as expected.
            site.Title = GetPageTitle(address);
            site.URL = AddressTextBox.Text;
            site.Date = DateTime.Now;



            HistoryManager.AddItem(site);
        }

        static string GetPageTitle(string link)
        {
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                string html = wc.DownloadString(link);

                Regex x = new Regex("<title>(.*)</title>");
                MatchCollection m = x.Matches(html);

                if (m.Count > 0)
                {
                    return m[0].Value.Replace("<title>", "").Replace("</title>", "");
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not connect. Error:" + ex.Message);
                return "";
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
