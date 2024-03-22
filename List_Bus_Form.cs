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
    public partial class List_Bus_Form : Form
    {
        public List_Bus_Form()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }

        Database db = Database.GetInstance();

        private void List_Bus_Form_Load(object sender, EventArgs e)
        {
            db.LoadBusInfo(dataGridView1);
        }
    }
}
