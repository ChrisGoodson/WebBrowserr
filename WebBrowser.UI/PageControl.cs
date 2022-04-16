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
        // Back links field
        public Stack<string> backLinks = new Stack<string>();
        // Forward links field
        public Stack<string> forwardLinks = new Stack<string>();
        // Uri field for history comparison
        public Uri myUri = new Uri("http://www.christinahehe.com");
        public static string SetTab = "";

        public PageControl()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            // Load URL when pressed
            webBrowser1.Navigate(addressBox.Text);
        }

        private void addressBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Load URL when enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                goBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // Refresh page
            webBrowser1.Refresh();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Go back a page
            webBrowser1.GoBack();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            // Go forward a page
            webBrowser1.GoForward();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Update URL in address box upon navigation
            addressBox.Text = webBrowser1.Url.ToString();

            // URL Status update
            this.webBrowser1.StatusTextChanged += new EventHandler(webBrowser1_StatusTextChanged);
        }
        private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            // Show URL in the Statu Strip
            this.urlStatusLbl.Text = this.webBrowser1.StatusText;
        }
        private void bookmarksBtn_Click(object sender, EventArgs e)
        {
            // Add to bookmarks
            var bookmark = new BookmarkItem();
            bookmark.URL = addressBox.Text;
            bookmark.Title = webBrowser1.DocumentTitle;

            // Get bookmarks for comparison
            var items = BookmarkManager.GetItems();

            // If database is NOT empty, check to see if URL exists
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
                // If not found, add bookmark
                BookmarkManager.AddItem(bookmark);
            }
            else
            {
                // If found, pop up message
                MessageBox.Show("SITE ALREADY BOOKMARKED ★");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            SetTab = webBrowser1.DocumentTitle;
            if (System.Windows.Forms.Application.OpenForms["MainWindow"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MainWindow"] as MainWindow).SetTabs();
            }

            // Compare current browser URL to Uri
            if (webBrowser1.Document.Url == myUri)
            {
                return;
            }
            else
            {
                // Add to history
                var history = new HistoryItem();
                history.URL = addressBox.Text;
                history.Title = webBrowser1.DocumentTitle;
                history.Date = DateTime.Now;
                HistoryManager.AddItem(history);

                // Make sure page doesn't fire again (see URl & uri are equal)
                myUri = webBrowser1.Document.Url;
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                // Set progress bar values
                progressBar.Value = (int)e.CurrentProgress;
                progressBar.Maximum = (int)e.MaximumProgress;
            }
            catch
            {

            }
            // Still loading
            if (progressBar.Value < e.MaximumProgress)
            {
                statusLbl.Text = "loading...";
            }
            // Done loading
            else
            {
                statusLbl.Text = "done";
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            string home = settingsForm.HomePage;
            // Homepage for now
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
            // Load URL when enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
        }
    }
}