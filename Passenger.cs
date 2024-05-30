using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public class Passenger
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string email {get; set; }

        public string phone { get; set; }

        public Passenger(string name, string email, string phone)
        {
            Name = name;
            this.email = email;
            this.phone = phone;
        }

        public Passenger(int id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            this.email = email;
            this.phone = phone;
        }
    }
}
