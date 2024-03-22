using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation_System
{
    public sealed class Database
    {
        private Database() { }

        private static Database instance;

        public static Database GetInstance()
        {
            if(instance == null)
            {
                instance = new Database();
            }
            
            return instance;
        }

        private static OracleConnection GetDBConnection(string host, int port, String sid, String user, string password)
        {
            string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=" + host + ")(PORT=" + port + "))(CONNECT_DATA=(SERVICE_NAME=" + sid + ")));User Id=" + user + ";Password=" + password;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = connString;
            return conn;
        }

        OracleConnection con = GetDBConnection("localhost", 1521, "XEPDB1", "oni", "0707");

        public bool newReceptionist(Receptionist receptionist)
        {
            string insertQuery = "INSERT INTO receptionist (name, ContactNumber,DOB, Password) VALUES (:name, :contactno,:dob, :password)";
            try
            {
                
                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;
                    
                    
                command.Parameters.Add(":name", OracleDbType.Varchar2).Value =receptionist.name;
                command.Parameters.Add(":contactno", OracleDbType.Varchar2).Value = receptionist.contactNumber;
                command.Parameters.Add(":dob",OracleDbType.Date).Value=receptionist.Dob.ToString("MM/dd/yyyy");
                command.Parameters.Add(":password", OracleDbType.Varchar2).Value = receptionist.password;

                    
                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                  MessageBox.Show("Successfully Registered as a Receptionist!");

                    return true;
                            
                }

                    MessageBox.Show("Failed to register as a receptionist!");
                        
                    return false;
              
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Registration): " + ex.Message);
                con.Close();

                return false;
            }
        }

        public Boolean ReceptionistLogin(string ID, string password)
        {
            
            try
            {
                Boolean loggedIn = false;
                con.Open();

                OracleCommand command = new OracleCommand();
                command.Connection = con;
                command.CommandText = "Receptionist_login";
                command.CommandType = CommandType.StoredProcedure;



                OracleParameter retval = new OracleParameter("ret", OracleDbType.Varchar2,20);
                retval.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(retval);
                

                //p_id parameter
                OracleParameter p_id = new OracleParameter("p_id", OracleDbType.Varchar2);
                p_id.Direction= ParameterDirection.Input;
                p_id.Value = ID;
                command.Parameters.Add(p_id);
                //MessageBox.Show(p_id.Value.ToString());
                //p_pass parameter
                OracleParameter p_password = new OracleParameter("p_password",OracleDbType.Varchar2);
                p_password.Direction= ParameterDirection.Input;
                p_password.Value = password;
                command.Parameters.Add(p_password);

                //now for return 
               
                command.ExecuteNonQuery();
                //MessageBox.Show(command.Parameters["ret"].Value.ToString());
                if (command.Parameters["ret"].Value.ToString() == "true")
                {
                    loggedIn = true;
                  
                }
              
               

                con.Close();
                return loggedIn;

            }
            catch(Exception ex)
            {
                MessageBox.Show("login error: "+ex.Message);
                con.Close();
                return false;
            }
        }


        public void LoadReceptionist(DataGridView dataGrid)
        {
            try
            {
                con.Open();
                string sql = "select ReceptionistID,name,contactNumber,Dob from receptionist";
                OracleCommand oracleCommand = new OracleCommand();

                oracleCommand.CommandText = sql;
                oracleCommand.Connection = con;


                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the SELECT query
                OracleDataReader reader = oracleCommand.ExecuteReader();

                dataTable.Load(reader);



                dataGrid.DataSource = dataTable;


                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); con.Close();
            }
        }


        public bool AddDriver(Driver driver)
        {
            string insertQuery = "INSERT INTO Driver (name,LicenseNumber, ContactNumber,DOB) VALUES (:name,:licenseno ,:contactno,:dob)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = driver.DriverName;
                command.Parameters.Add(":licenseno", OracleDbType.Varchar2).Value = driver.licenceNumber;
                command.Parameters.Add(":contactno", OracleDbType.Varchar2).Value = driver.contactNumber;
                command.Parameters.Add(":dob", OracleDbType.Date).Value = driver.Dob.ToString("MM/dd/yyyy");
           


                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Successfully Added a new Driver!");

                    return true;

                }

                MessageBox.Show("Failed to add a driver!");

                return false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Registration): " + ex.Message);
                con.Close();

                return false;
            }

        }

        public void LoadDriverInfo(DataGridView dataGrid)
        {
            try
            {
                con.Open();
                string sql = "select * from Driver";
                OracleCommand oracleCommand = new OracleCommand();

                oracleCommand.CommandText = sql;
                oracleCommand.Connection = con;


                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the SELECT query
                OracleDataReader reader = oracleCommand.ExecuteReader();

                dataTable.Load(reader);



                dataGrid.DataSource = dataTable;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); con.Close();
            }
        }

        public bool AddNewStation(string stationName)
        {
            string insertQuery = "INSERT INTO Station (StationName) VALUES (:stationname)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add(":stationname", OracleDbType.Varchar2).Value = stationName;


                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Successfully Added a new Station!");

                    return true;

                }

                MessageBox.Show("Failed to add a Station!");

                return false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Adding Station): " + ex.Message);
                con.Close();

                return false;
            }
        }


        public List<string> FetchAllStation()
        {
            List<string> Stations = new List<string>();
            try
            {
                con.Open();
                string sql = "select * from Station";
                OracleCommand oracleCommand = new OracleCommand();

                oracleCommand.CommandText = sql;
                oracleCommand.Connection = con;


                

                // Fill the DataTable with the results of the SELECT query
                OracleDataReader reader = oracleCommand.ExecuteReader();

               
                while(reader.Read())
                {
                    Stations.Add(reader[0].ToString());
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
                con.Close();
            }


            return Stations;
        }
    }
}
