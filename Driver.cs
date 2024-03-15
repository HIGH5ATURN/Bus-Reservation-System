using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public class Driver
    {
        public string DriverID { get;set; }


        public string DriverName { get;set; }

        public int licenceNumber { get;set; }

        public string contactNumber { get;set; }

        public DateOnly Dob { get;set; }

        public Driver(string driverID, string driverName, int licenceNumber, string contactNumber,DateOnly dob)
        {
            DriverID = driverID;
            DriverName = driverName;
            this.licenceNumber = licenceNumber;
            this.contactNumber = contactNumber;
            this.Dob = dob;
        }

        public Driver( string driverName, int licenceNumber, string contactNumber, DateOnly dob)
        {
            DriverID = "";
            DriverName = driverName;
            this.licenceNumber = licenceNumber;
            this.contactNumber = contactNumber;
            Dob = dob;
        }
    }
}
