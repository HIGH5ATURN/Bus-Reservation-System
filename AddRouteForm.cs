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

        List<Route> routes = new List<Route>();


        string previousSelectedStation = "";
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void AddRouteForm_Load(object sender, EventArgs e)
        {
            cmb_From.Items.Clear();
            cmb_To.Items.Clear();
            //here make sure you call the loadRoute from database class

            foreach (string station in db.FetchAllStation())
            {
                cmb_From.Items.Add(station);
                cmb_To.Items.Add(station);
            }


            routes = db.loadRoutes();

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

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Hide();

            new Form2().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddRoute_Click(object sender, EventArgs e)
        {
            try
            {
                string origin = cmb_From.Text;
                string dest = cmb_To.Text;

                if (origin == dest)
                {
                    throw new Exception("Invalid Route!");
                }
                else
                {
                    //First check if there is any route that is same as this one
                    foreach(Route rte in routes)
                    {
                        if(rte.origin== origin && rte.destination == dest)
                        {
                            MessageBox.Show("Route from " + origin + " to " + dest + " already exists!");
                            txt_distance.Clear();
                            txt_Hour.Clear();
                            txt_min.Clear();
                            return;
                        }
                    }
                    //calling the database method to add the route 
                    Route route = new Route(origin, dest,Convert.ToInt32(txt_distance.Text),Convert.ToInt32(txt_Hour.Text),Convert.ToInt32(txt_min.Text));
                    db.AddRoute(route);
                    txt_distance.Clear();
                    txt_Hour.Clear();
                    txt_min.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
