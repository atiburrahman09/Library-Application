using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryWebApp.BLL;
using LibraryWebApp.Model;

namespace LibraryWebApp.UI
{
    public partial class BookEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BookEntryManager aManager=new BookEntryManager();
        protected void saveBookButton_Click(object sender, EventArgs e)
        {
            Book aBook=new Book();
            aBook.Title = titleTextBox.Text;
            aBook.Author = authorTextBox.Text;
            aBook.Publisher = publisherTextBox.Text;
            msgLabel.Text = aManager.SaveBookEntry(aBook);


        }
    }
}