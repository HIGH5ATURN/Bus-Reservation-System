using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation_System
{
    public partial class ReceptionistList : Form
    {
        Database db = Database.GetInstance();
        public ReceptionistList()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void ReceptionistList_Load(object sender, EventArgs e)
        {
            db.LoadReceptionist(dataGridView1);

        }
    }
}
