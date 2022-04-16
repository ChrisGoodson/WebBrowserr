using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;



namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        // Add Bookmark Item to database
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        // Get Bookmark Items from database
        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                // Add to list
                results.Add(item);
            }
            return results;
        }

        // Delete specific bookmark
        public static void DeleteBookmark(string item)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string checkItem = string.Format(string.Format("{0} ({1})", row.Title, row.URL));

                // Check if database matches selected item
                if (checkItem == item)
                {
                    adapter.Delete(row.Id, row.URL, row.Title);
                }
            }

        }
    }
}