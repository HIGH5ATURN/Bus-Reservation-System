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
    public partial class ReservationHistory : Form
    {

        Database db = Database.GetInstance();
        public ReservationHistory()
        {
            InitializeComponent();
        }

        private void ReservationHistory_Load(object sender, EventArgs e)
        {
            db.LoadReservationHistory(dataGridView1);
        }
    }
}
