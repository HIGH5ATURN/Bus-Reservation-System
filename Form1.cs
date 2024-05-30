namespace Bus_Reservation_System
{
    public partial class Form1 : Form
    {
        Database db = Database.GetInstance();


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string encrypted = Encryption.EncryptPassword(txt_pass.Text);
            //MessageBox.Show(encrypted);
            Utility.ReceptionistID = txt_name.Text;
            if (db.ReceptionistLogin(txt_name.Text, encrypted))
            {
                Hide();
                new Form2().Show();
            }
        }

        private void link_to_RegForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationAsReceptionist registrationAsReceptionist = new RegistrationAsReceptionist();

            this.Hide();
            registrationAsReceptionist.Show();
        }

        private void link_AllReceptionistLIst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new ReceptionistList().Show();
        }
    }
}