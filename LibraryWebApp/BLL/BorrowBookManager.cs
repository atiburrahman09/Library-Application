using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryWebApp.DAL;
using LibraryWebApp.Model;

namespace LibraryWebApp.BLL
{
    public class BorrowBookManager
    {
       BorrowBookGateWay aGateWay=new BorrowBookGateWay();

        public BookBorrow ShowInTextBox(string bookName)
        {
            return aGateWay.ShowInTextBox(bookName);
        }

        public string BorrowBookEntry(BookBorrow aEntry)
        {
            return aGateWay.BorrowBookEntry(aEntry);
        }

        public List<BookBorrow> ShowBorrowedBooks(int memberNo)
        {
            return aGateWay.ShowBorrowedBooks(memberNo);
        }

        public string ReturnBorrowedBook(BookBorrow aEntry)
        {
            return aGateWay.ReturnBorrowedBook(aEntry);
        }
    }
}