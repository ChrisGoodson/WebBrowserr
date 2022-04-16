using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

/**
 * @author Christina Liu
 * @version 4/9/2021
 */

namespace WebBrowser.UI
{
    public partial class PageControl : UserControl
    {

        public Stack<string> backLinks = new Stack<string>();
        public Stack<string> forwardLinks = new Stack<string>();
        public Uri myUri = new Uri("http://www.christinahehe.com");
        public static string SetTab = "";

        public PageControl()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressBox.Text);
        }

        private void addressBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressBox.Text = webBrowser1.Url.ToString();
            this.webBrowser1.StatusTextChanged += new EventHandler(webBrowser1_StatusTextChanged);
        }
        private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            this.urlStatusLbl.Text = this.webBrowser1.StatusText;
        }
        private void bookmarksBtn_Click(object sender, EventArgs e)
        {
            var bookmark = new BookmarkItem();
            bookmark.URL = addressBox.Text;
            bookmark.Title = webBrowser1.DocumentTitle;

            var items = BookmarkManager.GetItems();
            int count = 0;
            foreach (var item in items)
            {
                if (item.URL.Contains(addressBox.Text))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                BookmarkManager.AddItem(bookmark);
            }
            else
            {
                MessageBox.Show("Already");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            SetTab = webBrowser1.DocumentTitle;
            if (System.Windows.Forms.Application.OpenForms["MainWindow"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MainWindow"] as MainWindow).SetTabs();
            }

            if (webBrowser1.Document.Url == myUri)
            {
                return;
            }
            else
            {
                var history = new HistoryItem();
                history.URL = addressBox.Text;
                history.Title = webBrowser1.DocumentTitle;
                history.Date = DateTime.Now;
                HistoryManager.AddItem(history);
                myUri = webBrowser1.Document.Url;
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar.Value = (int)e.CurrentProgress;
                progressBar.Maximum = (int)e.MaximumProgress;
            }
            catch
            {

            }
            if (progressBar.Value < e.MaximumProgress)
            {
                statusLbl.Text = "loading...";
            }
            else
            {
                statusLbl.Text = "Done";
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            string home = settingsForm.HomePage;
            webBrowser1.Navigate(home);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = settingsForm.SearchEngine;
            webBrowser1.Navigate(search + searchBox.Text);
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
        }
    }
}