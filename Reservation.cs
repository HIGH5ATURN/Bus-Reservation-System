using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public class Reservation
    {
        public int reservationID { get; set; }

        public int PassengerID { get; set; }

        public string SeatNo { get; set; }

        public DateTime ReservationTime { get; set; }   


        public int ScheduleID { get; set; }

        public string ReceptionistID { get; set; }

        public Reservation(int passengerID, string seatNo, DateTime reservationTime, int scheduleID, string receptionistID)
        {
            PassengerID = passengerID;
            SeatNo = seatNo;
            ReservationTime = reservationTime;
            ScheduleID = scheduleID;
            ReceptionistID = receptionistID;
        }

        public Reservation(int reservationID, int passengerID, string seatNo, DateTime reservationTime, int scheduleID, string receptionistID)
        {
            this.reservationID = reservationID;
            PassengerID = passengerID;
            SeatNo = seatNo;
            ReservationTime = reservationTime;
            ScheduleID = scheduleID;
            ReceptionistID = receptionistID;
        }

        public Reservation(string seatNo, DateTime reservationTime, int scheduleID, string receptionistID)
        {
            SeatNo = seatNo;
            ReservationTime = reservationTime;
            ScheduleID = scheduleID;
            ReceptionistID = receptionistID;
        }
    }
}
