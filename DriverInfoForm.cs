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
    public partial class DriverInfoForm : Form
    {
        Database db = Database.GetInstance();
        public DriverInfoForm()
        {
            InitializeComponent();
        }

        private void DriverInfoForm_Load(object sender, EventArgs e)
        {
            db.LoadDriverInfo(dataGridView1);
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Hide();

            new Form2().Show();
        }
    }
}
