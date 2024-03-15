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
    public partial class DriverForm : Form
    {
        Database db = Database.GetInstance();
        public DriverForm()
        {
            InitializeComponent();
        }

        private void btn_AddDriver_Click(object sender, EventArgs e)
        {

            DateOnly date = DateOnly.Parse(calender_Dob.SelectionRange.Start.ToShortDateString(), CultureInfo.InvariantCulture);

            try
            {

                //create a receptionist object

                Driver driver = new Driver(txt_name.Text, Convert.ToInt32(txt_License.Text), txt_Contact.Text, date);

                if (db.AddDriver(driver))
                {
                    this.Hide();
                    new Form2().Show();
                }
                else
                {
                    txt_name.Clear();
                    txt_Contact.Clear();
                    txt_License.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }
    }
}
