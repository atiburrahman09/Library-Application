using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryWebApp.DAL;
using LibraryWebApp.Model;

namespace LibraryWebApp.BLL
{
    public class BookEntryManager
    {
        BookEntryGateWay aGateWay=new BookEntryGateWay();

        public string SaveBookEntry(Book aEntry)
        {
            int rowAffected = aGateWay.BookExits(aEntry);
            if (rowAffected > 0)
            {
                return "Member Already Exists!!";
            }
            else
            {

                return aGateWay.SaveBookEntry(aEntry);
            }

        }

    }
}