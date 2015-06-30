using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryWebApp.BLL;
using LibraryWebApp.Model;

namespace LibraryWebApp.UI
{
    public partial class BorrowBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BorrowBookManager aManager=new BorrowBookManager();
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<BookBorrow> aBook=new List<BookBorrow>();
            BookBorrow aBook = new BookBorrow();
            string bookName = Convert.ToString(bookDropDownList.SelectedItem);
            //
            aBook = aManager.ShowInTextBox(bookName);
            authorTextBox.Text = aBook.Author;
            publisherTextBox.Text = aBook.Publisher;
            aBook.MemberNo = Convert.ToInt32(memberNoTextBox.Text);

            

        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            BookBorrow aBook = new BookBorrow();
            aBook.Author = authorTextBox.Text;
            aBook.Publisher = publisherTextBox.Text;
            aBook.MemberNo = Convert.ToInt32(memberNoTextBox.Text);
            aBook.Title = Convert.ToString(bookDropDownList.SelectedItem);

            if (memberNoTextBox.Text==string.Empty)
            {
                msgLabel.Text = "Please Enter a Member ID";
            }
            else
            {
                msgLabel.Text = aManager.BorrowBookEntry(aBook);
            }
            
        }
    }
}