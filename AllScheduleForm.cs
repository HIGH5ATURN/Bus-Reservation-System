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
    public partial class AllScheduleForm : Form
    {
        public AllScheduleForm()
        {
            InitializeComponent();
        }

        Database db = Database.GetInstance();
        private void AllScheduleForm_Load(object sender, EventArgs e)
        {
            //will show all the schedules past , present , future
            //and there should also be a button to find out the present & future and also be a system to find by date -->infos.

            db.ShowAllSchedule(dataGridView1);
        }
    }
}
