using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation_System
{
    public partial class TicketBookingForm : Form
    {
        Database db = Database.GetInstance();
        DataTable dt;
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



            //load all the free seats in the comboBox
            dt = db.ShowFilteredSchedule();


            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    txt_ScheduleID.Text = row.Cells["SCHEDULE_ID"].Value.ToString();
                    txt_Origin.Text = row.Cells["ORIGIN"].Value.ToString();
                    txt_Destination.Text = row.Cells["DESTINATION"].Value.ToString();
                    txt_DeptTime.Text = row.Cells["DEPARTURE_TIME"].Value.ToString();
                    txt_ArrivalTime.Text = row.Cells["ARRIVAL_TIME"].Value.ToString();
                    txt_Fare.Text = row.Cells["FARE"].Value.ToString();
                    txt_Driver.Text = row.Cells["DRIVER_NAME"].Value.ToString();
                    txt_BusNo.Text = row.Cells["BUS_NUMBER"].Value.ToString();
                    Bus bus = db.FindBusCapacity(txt_BusNo.Text);

                    cmb_selectSeat.Items.Clear();
                    ;
                    for (int i = 1; i <= bus.Capacity; i++)
                    {

                        //now I will add seats in the seatcombobox except those seats who are already reserved for that schedule

                        if (db.IsThisSeatFree(i.ToString(), txt_ScheduleID.Text))
                        {
                            //then add it to the comboBox
                            cmb_selectSeat.Items.Add(i);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_BookTicket_Click(object sender, EventArgs e)
        {
            //this method will call the book ticket function from database, which will check if the passenger is on the DB if he is then it will just use the passenger ID
            //create a passenger object & ticket object

            Passenger passenger = new Passenger(txt_PassengerName.Text, txt_PassengerEmail.Text, txt_PassengerPhone.Text);


            Reservation reservation = new Reservation(cmb_selectSeat.Text, DateTime.Now, Convert.ToInt32(txt_ScheduleID.Text), Utility.ReceptionistID);

            db.BookTicket(passenger, reservation);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_Dest_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_Search_Dest_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;

            dv.RowFilter = "DESTINATION LIKE '%" + txt_Search_Dest.Text + "'";

            dataGridView1.DataSource = dv;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            
            txt_PassengerName.Clear();
            txt_PassengerEmail.Clear();
            txt_PassengerPhone.Clear();
            
        }
    }
}
