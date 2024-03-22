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
    public partial class Form2 : Form
    {
        Database db = Database.GetInstance();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_AddNewDriver_Click(object sender, EventArgs e)
        {
            Hide();

            new DriverForm().Show();
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void btn_ViewAllDriver_Click(object sender, EventArgs e)
        {
            Hide();
            new DriverInfoForm().Show();
        }

        private void btn_AddNewStation_Click(object sender, EventArgs e)
        {
            new AddNewStationForm().Show();
        }

        private void btn_AddNewRoute_Click(object sender, EventArgs e)
        {
            Hide();

            new AddRouteForm().Show();
        }

        private void btn_AddnewBus_Click(object sender, EventArgs e)
        {
            Hide();

            new AddBusForm().Show();

        }

        private void btn_viewAll_Bus_Click(object sender, EventArgs e)
        {
            Hide();
            new List_Bus_Form().Show();
        }
    }
}
