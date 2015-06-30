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
    public partial class MemberEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        MemberEntryManager aManager=new MemberEntryManager();
        protected void memberSaveButton_Click(object sender, EventArgs e)
        {
            
            Member aMember = new Member();
            aMember.Number = Convert.ToInt32(numberTextBox.Text);
            aMember.Name = nameTextBox.Text;
            msgLabel.Text = aManager.SaveMemberEntry(aMember);
        }
    }
}