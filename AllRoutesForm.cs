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
    public partial class AllRoutesForm : Form
    {
        public AllRoutesForm()
        {
            InitializeComponent();
        }

        Database db= Database.GetInstance();

        private void AllRoutesForm_Load(object sender, EventArgs e)
        {
            //fill the datagrid with all routes.

            db.ShowAllRoutes(dataGridView1);
        }
    }
}
