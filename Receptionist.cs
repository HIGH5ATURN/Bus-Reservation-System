using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public class Receptionist
    {
        public string receptionistID { get; set; }

        public string name { get; set; }

        public string contactNumber { get;set; }

        public DateOnly Dob { get; set; }

        public string password { get; set; }
        public Receptionist(string name, string contactNumber, DateOnly Dob,string password) 
        {
            this.name = name;
            this.contactNumber = contactNumber;
            this.Dob = Dob;
            this.password = password;
            receptionistID = "";
        }


        public Receptionist(string receptionistID, string name, string contactNumber, DateOnly Dob, string password)
        {
            this.receptionistID = receptionistID;
            this.name = name;
            this.contactNumber = contactNumber;
            this.Dob = Dob;
            this.password = password;
        }

    }
}
