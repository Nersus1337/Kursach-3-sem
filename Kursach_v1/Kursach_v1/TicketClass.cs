using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_v1
{
    [Serializable]
    public class AllTickets : List <TicketClass>
    { }



    [Serializable]
    public class TicketClass
    {
        public string name;
        public string passport;
        public string address;
        public string email;
        public string phone;

        public int id;

        public TicketClass(string name, string passport, string address, string email, string phone, int id)
        {
            this.name = name;
            this.passport = passport;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.id = id;
        }
        //[Serializable]
        //public class AllIssues : List<IssueClass>
        //{ }
        //[Serializable]
        /*
        public partial class IssueClass
        {
            public string DateIssue;
            public string DateReturn;
            public int IssueBookId;
            //public int TicketId;
            //public int NumberIssue;

        }*/

        public string[] DateIssue = new string[10];
        public string[] DateReturn = new string[10];
        public int[] IssueBookId = new int[10];
        public string[] IssueBookTitle = new string[10];

    }
}
