using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;


namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void addItem(BookmarkItem item)
        {
            var adapter = new BookmarkTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        public static List<BookmarkItem> getItems()
        {
            var adapter = new BookmarkTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                //item.Id = row.Id;
                item.URL = row.URL;
                item.Title = row.Title;

                results.Add(item);

            }
            return results;
        }
    }
}
