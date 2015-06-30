using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryWebApp.BLL;

namespace LibraryWebApp.UI
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BorrowBookManager aBookManager=new BorrowBookManager();
        protected void showBorrowedBooksButton_Click(object sender, EventArgs e)
        {
            int memberNo = Convert.ToInt32(memberTextBox.Text);

            borrowedDropDownList.DataSource = aBookManager.ShowBorrowedBooks(memberNo);
            borrowedDropDownList.DataTextField = "title";
            borrowedDropDownList.DataValueField = "memberNo";
            borrowedDropDownList.DataBind();
        }

        protected void returnButton_Click(object sender, EventArgs e)
        {

        }
    }
}