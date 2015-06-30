using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryWebApp.Model;
using BorrowBook = LibraryWebApp.UI.BorrowBook;

namespace LibraryWebApp.DAL
{
    public class BorrowBookGateWay
    {
        private string connectionString =
           WebConfigurationManager.ConnectionStrings["ConnectionStringforLibraryDB"].ConnectionString;

        public BookBorrow ShowInTextBox(string bookName)
        {

            List<BookBorrow> aBookList = new List<BookBorrow>();
            string query = "SELECT * FROM tbl_book WHERE Title='"+bookName+"'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            BookBorrow aBook = new BookBorrow();
            if (aReader.HasRows)
            {
                aReader.Read();
                // Setup DataReader
                // Set DR values to Text fields
                aBook.Author = aReader["author"].ToString();
                aBook.Publisher = aReader["publisher"].ToString();
                
                
            }
            
            aReader.Close();
            aConnection.Close();
            return aBook;
        }

        public string BorrowBookEntry(BookBorrow aEntry)
        {
            string massege = " ";
            string query = "INSERT INTO tbl_borrow VALUES ('" + aEntry.Title + "','" + aEntry.Author + "', '" + aEntry.Publisher + "','"+aEntry.MemberNo+"');";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffected = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return massege = "A Book Has Been Borrowed By " +aEntry.MemberNo ;
        }

        public List<BookBorrow> ShowBorrowedBooks(int memberNo)
        {
            List<BookBorrow> aBookList = new List<BookBorrow>();
            string query = "SELECT * FROM tbl_borrow WHERE MemberNo='" + memberNo + "'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            
            while (aReader.Read())
            {
                
                // Setup DataReader
                // Set DR values to Text fields
                BookBorrow aBook = new BookBorrow();
                aBook.Title = aReader["selectabook"].ToString();
                
                aBookList.Add(aBook);

            }

            aReader.Close();
            aConnection.Close();
            return aBookList;
        }

        public string ReturnBorrowedBook(BookBorrow aEntry)
        {
            string massege = " ";
            string query = "DELETE FROM tbl_borrow WHERE Title='" + aEntry.Title + "'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            int rowAffected = aCommand.ExecuteNonQuery();
            aConnection.Close();
            return massege = "A Book Has Been Returned By " + aEntry.MemberNo;
        }
    }
}