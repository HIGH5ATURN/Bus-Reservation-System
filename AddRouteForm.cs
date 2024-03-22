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
    public partial class AddRouteForm : Form
    {
        Database db = Database.GetInstance();

        string previousSelectedStation="";
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void AddRouteForm_Load(object sender, EventArgs e)
        {
            cmb_From.Items.Clear();
            cmb_To.Items.Clear();


            foreach (string station in db.FetchAllStation())
            {
                cmb_From.Items.Add(station);
                cmb_To.Items.Add(station);
            }

        }

        private void cmb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    cmb_To.Items.Add(previousSelectedStation);

            //    previousSelectedStation = cmb_From.Text;

            //    if (cmb_To.Items.Count > 0)
            //    {
            //        cmb_To.Items.RemoveAt(cmb_From.SelectedIndex);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
