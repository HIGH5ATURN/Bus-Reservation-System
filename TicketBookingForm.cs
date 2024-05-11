using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation_System
{
    public partial class TicketBookingForm : Form
    {
        Database db = Database.GetInstance();
        public TicketBookingForm()
        {
            InitializeComponent();
        }
        //This Form will Show the Available Schedule
        //based on Departure Date which will be greater and equal to current Date
        //based on if the driver isnt assigned to any other schedule on that particular time segment
        //based on if the bus is available

        //then there will be reservations on that schedule.
        private void TicketBookingForm_Load(object sender, EventArgs e)
        {
            //the gridview will show schedule ID, origin, Destination, departureTime, Arrivaltime,Fare,busName

            db.ShowFilteredSchedule(dataGridView1);
        }
    }
}
