using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryWebApp.Model;

namespace LibraryWebApp.DAL
{
    public class MemberEntryGateway
    {
        private string connectionString =
           WebConfigurationManager.ConnectionStrings["ConnectionStringforLibraryDB"].ConnectionString;

        public string SaveMemberEntry(Member aMember)
        {
            string massege = " ";
            string query = "INSERT INTO tbl_member VALUES ('" + aMember.Number + "','" + aMember.Name + "');";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int rowAffected = aCommand.ExecuteNonQuery();
            aConnection.Close();

            return massege = aMember.Name + " Has Been Added";
        }

        public int MemberExits(Member aMember)
        {
           
            int rowAffected = 0;
            string query = "SELECT * FROM tbl_member WHERE Number='" + aMember.Number + "' ";
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
        public List<Member> GetAllMembers()
        {
            List<Member> memberList = new List<Member>();
            string query = "SELECT * FROM tbl_member";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                Member aMember=new Member();
                aMember.Id = (int)aReader["Id"];
                aMember.Number = Convert.ToInt32(aReader["number"]);
                aMember.Name = Convert.ToString(aReader["name"]);
                
                
                memberList.Add(aMember);
            }

            aReader.Close();
            aConnection.Close();
            return memberList;
        }
    }
}