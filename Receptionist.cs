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
        public string name { get; set; }

        public string contactNumber { get;set; }

        public DateOnly Dob { get; set; }


        public Receptionist(string name, string contactNumber, DateOnly dob) 
        {
            this.name = name;
            this.contactNumber = contactNumber;
            this.Dob = dob;
        }

        
    }
}
