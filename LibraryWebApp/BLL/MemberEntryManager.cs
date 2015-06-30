using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryWebApp.DAL;
using LibraryWebApp.Model;

namespace LibraryWebApp.BLL
{
    public class MemberEntryManager
    {
        MemberEntryGateway aGateway=new MemberEntryGateway();

        public string SaveMemberEntry(Member aMember)
        {
            int rowAffected = aGateway.MemberExits(aMember);
            if (rowAffected > 0)
            {
                return "Member Already Exists!!";
            }
            else
            {

            return aGateway.SaveMemberEntry(aMember);    
            }
            
        }

        public List<Member> GetAllMembers()
        {
            return aGateway.GetAllMembers();
        }
    }
}