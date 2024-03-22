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
    public partial class AddBusForm : Form
    {
        Database database = Database.GetInstance();
        public AddBusForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddBus_Click(object sender, EventArgs e)
        {
            try
            {
                Bus bus = new Bus(txt_Bus_Number.Text, txt_Model.Text, txt_capacity.Text);

                if (database.AddBus(bus))
                {
                    this.Hide();
                    new Form2().Show();
                }
                else
                {
                    txt_Bus_Number.Clear();
                    txt_Model.Clear();
                    txt_capacity.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }
    }
}
