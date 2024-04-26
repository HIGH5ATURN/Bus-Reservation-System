using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public class Route
    {
        public int ID { get; set; }

        public string origin { get; set; }

        public string destination { get; set; }

        public int distance { get; set; }

        public int hour { get; set; }

        public int minute { get; set; }


        public Route(int iD, string origin, string destination, int distance, int hour, int minute)
        {
            ID = iD;
            this.origin = origin;
            this.destination = destination;
            this.distance = distance;
            this.hour = hour;
            this.minute = minute;
        }

        public Route( string origin, string destination, int distance, int hour, int minute)
        {
          
            this.origin = origin;
            this.destination = destination;
            this.distance = distance;
            this.hour = hour;
            this.minute = minute;
        }
    }
}
