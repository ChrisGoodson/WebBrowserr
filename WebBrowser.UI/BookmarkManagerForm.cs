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
using WebBrowser.Data;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {

        public static string SetURL = "";

        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            // Get items from the bookmarks database
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                // Display bookmark items in the list box
                listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void bookSrchBtn_Click(object sender, EventArgs e)
        {
            // Search for item in bookmarks
            var items = BookmarkManager.GetItems();
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                bool result = item.Title.IndexOf(bookSrchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                bool result2 = item.URL.IndexOf(bookSrchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                if (result == true || result2 == true)
                {
                    listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }

        private void bookSrchBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Search if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                bookSrchBtn_Click(sender, e);
            }
        }

        private void bookDelBtn_Click(object sender, EventArgs e)
        {
            // Delete selected item from bookmarks
            try
            {
                string item = listBox1.GetItemText(listBox1.SelectedItem);
                BookmarkManager.DeleteBookmark(item);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("please select something to delete ♥.");
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();

            // Clear current list
            listBox1.Items.Clear();

            foreach (var item in items)
            {
                // Display bookmark items in the list box
                listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // double click to open the web page
                var adapter = new BookmarksTableAdapter();
                var list = adapter.GetData();
                var item = listBox1.SelectedItem.ToString();
                foreach (var bitem in list)
                {
                    if (item.Contains(bitem.URL))
                    {
                        SetURL = bitem.URL;
                        if (System.Windows.Forms.Application.OpenForms["MainWindow"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["MainWindow"] as MainWindow).BookmarkLinkTo();
                        }
                        this.Close();
                    }
                }
            }
            catch
            {
                // do nothing
            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // change highlight color of list box
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.LightPink);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}