using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation_System
{
    public partial class Create_Schedule : Form
    {
        Database db = Database.GetInstance();
        public Create_Schedule()
        {
            InitializeComponent();
        }

        private void btn_Add_Schedule_Click(object sender, EventArgs e)
        {
            List<Route> routes = db.loadRoutes();

            List<Bus> buses = db.LoadBusInfo();

            List<Driver> drivers = db.LoadDriverInfo();

            string cmbRouteTxt = cmb_SelectRoute.Text;

            string driverInfo = cmb_Driver.Text;

            string busInfo = cmb_Bus.Text;

            string depTime = cmb_DepartureTime.Text;

            double fare = Convert.ToDouble(txt_fare.Text);

            DateOnly date = DateOnly.Parse(calender.SelectionRange.Start.ToShortDateString(), CultureInfo.InvariantCulture);

            //getting departure time
            string hour = "";

            string min = "";


            for (int i = 0; i < depTime.Length; i++)
            {
                if (i <= 1)
                {
                    hour += depTime[i];
                }

                if (i > 2 && i <= 4)
                {
                    min += depTime[i];
                }
            }

            int hr = Convert.ToInt32(hour);
            int mn = Convert.ToInt32(min);


            DateTime depdateTime = new DateTime(date.Year, date.Month, date.Day, hr, mn, 0);



            Route route = null;

            Bus bus = null;

            Driver driver = null;



            foreach (Route r in routes)
            {
                if (cmbRouteTxt.Contains(r.ID.ToString()))
                {
                    route = r;
                    break;
                }
            }

            foreach (Bus bu in buses)
            {
                if (busInfo.Contains(bu.BusNumber.ToString()))
                {
                    bus = bu;
                    break;
                }
            }


            foreach (Driver d in drivers)
            {
                if (driverInfo.Contains(d.DriverID))
                {
                    driver = d;
                    break;
                }
            }


            double hre = route.hour;

            double mne = route.minute;

            hre += mne / 60;

            DateTime ArrivaldateTime = depdateTime.AddHours(hre);



            Schedule schedule = new Schedule(depdateTime, ArrivaldateTime, fare, route.ID, bus.BusNumber, driver.DriverID);

            MessageBox.Show(schedule.arrivalTime.ToString(), "EXPECTED ARRIVAL TIME");
            db.insertSchedule(schedule);
           // db.AddNewSchedule(schedule);
        }

        private void Create_Schedule_Load(object sender, EventArgs e)
        {
            calender.MinDate = DateTime.Now;
            calender.MaxDate = DateTime.Now.AddDays(10);
            cmb_Driver.Items.Clear();
            cmb_Bus.Items.Clear();
            cmb_SelectRoute.Items.Clear();



            //load route
            foreach (Route route in db.loadRoutes())
            {
                cmb_SelectRoute.Items.Add(route.ID + " " + route.origin + " --> " + route.destination);
            }
            //load driver
            foreach (Driver driver in db.LoadDriverInfo())
            {
                cmb_Driver.Items.Add(driver.DriverID + " " + driver.DriverName);
            }
            //load bus
            foreach (Bus bus in db.LoadBusInfo())
            {
                cmb_Bus.Items.Add(bus.BusNumber + " " + bus.BusModel);
            }

            //just use the datagrid view method to load these
        }

        private void cmb_DepartureTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_SelectRoute.SelectedIndex == -1)
            {
                return;
            }

            //now I need to add drivers that are not in that specific time segment
            //I can handle this from backend-database using function--which will think if to insert or not
            //based on driver availability and bus avilability
            



        }
    }
}
