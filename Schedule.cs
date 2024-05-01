using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public class Schedule
    {
        public int scheduleID { get; set; }

        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }

        public double fare { get; set; }

        public int RouteID { get; set; }

        public string busNumber { get; set; }

        public string driverID { get; set; }

        public Schedule(int scheduleID, DateTime departureTime, DateTime arrivalTime, double fare, int routeID, string busNumber, string driverID)
        {
            this.scheduleID = scheduleID;
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
            this.fare = fare;
            RouteID = routeID;
            this.busNumber = busNumber;
            this.driverID = driverID;
        }

        public Schedule(DateTime departureTime, DateTime arrivalTime, double fare, int routeID, string busNumber, string driverID)
        {
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
            this.fare = fare;
            RouteID = routeID;
            this.busNumber = busNumber;
            this.driverID = driverID;
        }
    }
}
