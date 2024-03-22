using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public class Bus
    {
        public string BusNumber {  get; set; }
        public string BusModel { get; set; }

        public string Capacity { get; set; }

        public Bus(string BusNumber, string BusModel, string Capacity)
        {
            this.BusNumber = BusNumber;
            this.BusModel = BusModel;
            this.Capacity = Capacity;
        }

    }
}
