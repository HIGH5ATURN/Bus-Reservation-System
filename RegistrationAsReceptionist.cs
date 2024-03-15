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
    public partial class RegistrationAsReceptionist : Form
    {
        Database db = Database.GetInstance();
        public RegistrationAsReceptionist()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            DateOnly date = DateOnly.Parse(calender_Dob.SelectionRange.Start.ToShortDateString(), CultureInfo.InvariantCulture);
            if (txt_ConfPass.Text != txt_pass.Text)
            {
                MessageBox.Show("Password mismatch!");
                txt_name.Clear();
                txt_Contact.Clear();
                txt_pass.Clear();
                txt_ConfPass.Clear();

            }
            else
            {
                try
                {

                    //create a receptionist object

                    Receptionist receptionist = new Receptionist(txt_name.Text, txt_Contact.Text, date, Encryption.EncryptPassword(txt_pass.Text));

                    if (db.newReceptionist(receptionist))
                    {
                        this.Hide();
                        new Form1().Show();
                    }
                    else
                    {
                        txt_name.Clear();
                        txt_Contact.Clear();
                        txt_pass.Clear();
                        txt_ConfPass.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Form1().Show(); 
        }
    }
}
