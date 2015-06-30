using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryWebApp.Model;

namespace LibraryWebApp.DAL
{
    public class BookEntryGateWay

    {
        private string connectionString =
           WebConfigurationManager.ConnectionStrings["ConnectionStringforLibraryDB"].ConnectionString;
        public string SaveBookEntry(Book aEntry)
        {
            string massege = " ";
            string query = "INSERT INTO tbl_book VALUES ('" + aEntry.Title + "','" + aEntry.Author + "', '"+aEntry.Publisher+"');";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffected = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return massege = aEntry.Title + " Has Been Added";
        }

        public int BookExits(Book aEntry)
        {

            int rowAffected = 0;
            string query = "SELECT * FROM tbl_book WHERE Title='" + aEntry.Title + "' ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                rowAffected = 1;

            }
            aReader.Close();
            connection.Close();
            return rowAffected;

        }
    }
}