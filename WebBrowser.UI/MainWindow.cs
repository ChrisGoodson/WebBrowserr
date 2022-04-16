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



namespace WebBrowser.UI
{
    public partial class MainWindow : Form
    {
        private TabPage dragTab;
        int tab = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            // Exit web browser
            Application.Exit();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            // About message that pop ups 
            MessageBox.Show("Chris Goodson, fzg0021");
        }

        private void newTabItem_Click(object sender, EventArgs e)
        {
            // Create new tab page
            TabPage newTab = new TabPage(string.Format("TAB {0}", tab));

            // Set tab location
            int lastTab = tabControl1.TabCount - 1;

            // Insert tab before the + tab
            tabControl1.TabPages.Insert(lastTab, newTab);

            // Add page control
            PageControl newTabCtrl = new PageControl();
            newTabCtrl.Dock = DockStyle.Fill;
            newTab.Controls.Add(newTabCtrl);

            // Make new tab the active tab
            tabControl1.SelectedTab = newTab;

            string home = settingsForm.HomePage;
            PageControl pc = (PageControl)tabControl1.SelectedTab.Controls[0];
            pc.webBrowser1.Navigate(home);

            // Increase tab for header
            tab++;
        }

        private void closeTabItem_Click(object sender, EventArgs e)
        {
            // Close current tab
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void manageHistoryToolStrip_Click(object sender, EventArgs e)
        {
            // Open History manager
            var history = new HistoryManagerForm();
            history.ShowDialog();
        }

        private void manageBookmarksToolStrip_Click(object sender, EventArgs e)
        {
            // Open Bookmarks manager
            var bookmarks = new BookmarkManagerForm();
            bookmarks.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear History
            HistoryManager.ClearHistory();
        }

        private TabPage TabAt(Point position)
        {
            // Make sure + tab can't be moved
            int count = tabControl1.TabCount - 1;

            for (int i = 0; i < count; i++)
            {
                if (tabControl1.GetTabRect(i).Contains(position))
                {
                    return tabControl1.TabPages[i];
                }
            }

            return null;
        }

        private void Swap(TabPage a, TabPage b)
        {
            // Swap tabs when dragged
            int i = tabControl1.TabPages.IndexOf(a);
            int j = tabControl1.TabPages.IndexOf(b);
            tabControl1.TabPages[i] = b;
            tabControl1.TabPages[j] = a;
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            dragTab = TabAt(e.Location);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Makes sure that the + tab can't be selected
            if (e.TabPageIndex == this.tabControl1.TabCount - 1)
            {
                e.Cancel = true;
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // Create new tab page
            TabPage newTab = new TabPage(string.Format("TAB {0}", tab));

            // Set tab location
            var lastTab = this.tabControl1.TabCount - 1;

            // Page control object
            PageControl newTabCtrl = new PageControl();

            if (this.tabControl1.GetTabRect(lastTab).Contains(e.Location))
            {

                // Insert tab before + tab
                this.tabControl1.TabPages.Insert(lastTab, newTab);
                newTabCtrl.Dock = DockStyle.Fill;
                newTab.Controls.Add(newTabCtrl);
                tabControl1.SelectedTab = newTab;

                string home = settingsForm.HomePage;
                PageControl pc = (PageControl)tabControl1.SelectedTab.Controls[0];
                pc.webBrowser1.Navigate(home);

                tab++;
            }
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // Drag tabs when mouse is moved
            if (e.Button != MouseButtons.Left || dragTab == null)
            {
                return;
            }

            TabPage tab = TabAt(e.Location);

            if (tab == null || tab == dragTab)
            {
                return;
            }

            Swap(dragTab, tab);
            tabControl1.SelectedTab = dragTab;
        }

        private void printItem_Click(object sender, EventArgs e)
        {
            PageControl pc = (PageControl)tabControl1.SelectedTab.Controls[0];
            pc.webBrowser1.ShowPrintPreviewDialog();

        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            PageControl pc = (PageControl)tabControl1.SelectedTab.Controls[0];
            pc.webBrowser1.ShowSaveAsDialog();
        }

        public void BookmarkLinkTo()
        {
            string url = BookmarkManagerForm.SetURL;
            PageControl pc = (PageControl)tabControl1.SelectedTab.Controls[0];
            pc.webBrowser1.Navigate(url);
        }

        public void HistoryLinkTo()
        {
            string url = HistoryManagerForm.SetURL;
            PageControl pc = (PageControl)tabControl1.SelectedTab.Controls[0];
            pc.webBrowser1.Navigate(url);
        }

        public void SetTabs()
        {
            tabControl1.SelectedTab.Text = PageControl.SetTab;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string home = settingsForm.HomePage;
            PageControl pc = (PageControl)tabControl1.SelectedTab.Controls[0];
            pc.webBrowser1.Navigate(home);
        }

        private void prefItem_Click(object sender, EventArgs e)
        {
            var p = new settingsForm();
            p.ShowDialog();
        }

        private void tabPages1_Load(object sender, EventArgs e)
        {

        }
    }
}