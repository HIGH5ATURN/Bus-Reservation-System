using Microsoft.VisualBasic.Devices;
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
        
        //just added two lines to see if git working

        //again

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
        public List<Driver> LoadDriverInfo()
        {
            List<Driver> driverList = new List<Driver>();
            try
            {
                con.Open();
                string sql = "select * from Driver";
                OracleCommand oracleCommand = new OracleCommand();

                oracleCommand.CommandText = sql;
                oracleCommand.Connection = con;




                // Fill the DataTable with the results of the SELECT query
                OracleDataReader reader = oracleCommand.ExecuteReader();

                while (reader.Read())
                {
                    DateOnly date = Utility.ConvertToDate(reader.GetString(4));

                    Driver driver = new Driver(reader.GetString(0),reader.GetString(1),Convert.ToInt32(reader.GetString(2)),reader.GetString(3),date );

                    driverList.Add(driver);
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); con.Close();
            }

            return driverList;
        }

        public bool AddBus(Bus bus)
        {
            string insertQuery = "INSERT INTO Bus (BusNumber,model,capacity) VALUES (:bus_number,:model ,:capacity)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add(":bus_number", OracleDbType.Varchar2).Value = bus.BusNumber;
                command.Parameters.Add(":model", OracleDbType.Varchar2).Value = bus.BusModel;
                command.Parameters.Add(":capacity", OracleDbType.Varchar2).Value = bus.Capacity;

                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Successfully Added a new Bus!");

                    return true;

                }

                MessageBox.Show("Failed to add a Bus!");

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Bus Registration): " + ex.Message);
                con.Close();

                return false;
            }

        }

        public void LoadBusInfo(DataGridView dataGrid)
        {
            try
            {
                con.Open();
                string sql = "select * from Bus";
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


        public List<Bus> LoadBusInfo()
        {
            List<Bus> busList= new List<Bus>();
            try
            {
                con.Open();
                string sql = "select * from Bus";
                OracleCommand oracleCommand = new OracleCommand();

                oracleCommand.CommandText = sql;
                oracleCommand.Connection = con;


 
                OracleDataReader reader = oracleCommand.ExecuteReader();

                while(reader.Read())
                {
                    Bus bus = new Bus(reader.GetString(0),reader.GetString(1),Convert.ToInt32(reader.GetString(2)) );
                    busList.Add(bus);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); con.Close();
            }


            return busList;
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


        public void AddRoute(Route route)
        {
            string insertQuery = "INSERT INTO Route (origin,destination, distance,hour,min) VALUES (:origin,:dest ,:distance,:hour,:min)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add(":origin", OracleDbType.Varchar2).Value = route.origin;
                command.Parameters.Add(":dest", OracleDbType.Varchar2).Value = route.destination;
                command.Parameters.Add(":distance", OracleDbType.Int32).Value = route.distance;
                command.Parameters.Add(":hour", OracleDbType.Int32).Value = route.hour;
                command.Parameters.Add(":min", OracleDbType.Int32).Value = route.minute;
                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Successfully Added a new Route!");


                }
                else
                {
                    MessageBox.Show("Failed to add the Route!");
                }
                con.Close() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Route): " + ex.Message);
                con.Close();

            }
        }

        public List<Route> loadRoutes()
        {
            List<Route> Routes = new List<Route>();
            try
            {
                con.Open();
                string sql = "select * from Route";
                OracleCommand oracleCommand = new OracleCommand();

                oracleCommand.CommandText = sql;
                oracleCommand.Connection = con;




                // Fill the DataTable with the results of the SELECT query
                OracleDataReader reader = oracleCommand.ExecuteReader();


                while (reader.Read())
                {
                   int id= Convert.ToInt32( reader[0].ToString());

                    string origin= reader[1].ToString();

                    string destination= reader[2].ToString();

                    int distance= Convert.ToInt32(reader[3].ToString());

                    int hour = Convert.ToInt32(reader[4].ToString());

                    int min = Convert.ToInt32(reader[5].ToString());

                    Route route = new Route(id, origin, destination, distance, hour, min);
                    
                    Routes.Add(route);

                }



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


            return Routes;
        }


        public void AddNewSchedule(Schedule schedule)
        {
            string insertQuery = "INSERT INTO Schedule (departuretime,arrivaltime, fare,routeid,busnumber,driverid) VALUES (:depttime,:arrtime ,:fr,:rID,:bNum,:dID)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add(":depttime", OracleDbType.Date).Value = schedule.departureTime;
                command.Parameters.Add(":arrtime", OracleDbType.Date).Value = schedule.arrivalTime;
                command.Parameters.Add(":fr", OracleDbType.Double).Value = schedule.fare;
                command.Parameters.Add(":rID", OracleDbType.Int32).Value = schedule.RouteID;
                command.Parameters.Add(":bNum", OracleDbType.Varchar2).Value = schedule.busNumber;
                command.Parameters.Add(":dID", OracleDbType.Varchar2).Value = schedule.driverID;

                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Successfully Added a new Schedule!");


                }
                else
                {
                    MessageBox.Show("Failed to add the Schedule!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Route): " + ex.Message);
                con.Close();

            }
        }

        public void ShowAllSchedule(DataGridView dataGrid)
        {
            try
            {
                con.Open();
                string sql = "select SCHEDULEID as SChedule_ID, Routeid as Route_ID,Origin, Destination,DEPARTURETIME as Departure_Time ,ARRIVALTIME as Arrival_Time,Fare,Name as Driver_Name, busnumber as Bus_Number from Schedule natural join Driver natural join Route";
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

        public void ShowAllRoutes(DataGridView dataGrid)
        {
            try
            {
                con.Open();
                string sql = "select * from Route";
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

        public void ShowFilteredSchedule(DataGridView dataGrid)
        {//This Form will Show the Available Schedule
         //based on Departure Date which will be greater and equal to current Date --DONE
         //based on if the driver isnt assigned to any other schedule on that particular time segment-- not done
         //this has to be done from selection I wont let anyone select drivers that are busy in that particular time segment
         //based on if the bus is available <--//same as driver id for this one

            try
            {
                con.Open();
                string sql = "select * from Schedule where DEPARTURETIME>=Sysdate";
             
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


        public bool insertSchedule(Schedule schedule)
        {

            try
            {
                Boolean isInserted = false;
                con.Open();

                OracleCommand command = new OracleCommand();
                command.Connection = con;
                command.CommandText = "InsertSchedule";
                command.CommandType = CommandType.StoredProcedure;



                OracleParameter retval = new OracleParameter("ret", OracleDbType.Varchar2, 20);
                retval.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(retval);


                //p_depTime parameter
                OracleParameter p_depTime = new OracleParameter("p_depTime", OracleDbType.Date);
                p_depTime.Direction = ParameterDirection.Input;
                p_depTime.Value = schedule.departureTime;
                command.Parameters.Add(p_depTime);


                //p_arrival_Time parameter
                OracleParameter p_arrival_Time = new OracleParameter("p_arrival_Time", OracleDbType.Date);
                p_arrival_Time.Direction = ParameterDirection.Input;
                p_arrival_Time.Value = schedule.arrivalTime;
                command.Parameters.Add(p_arrival_Time);


                //p_fare parameter
                OracleParameter p_fare = new OracleParameter("p_fare", OracleDbType.Double);
                p_fare.Direction = ParameterDirection.Input;
                p_fare.Value = schedule.fare;
                command.Parameters.Add(p_fare);

                //p_RouteID parameter
                OracleParameter p_RouteID = new OracleParameter("p_RouteID", OracleDbType.Double);
                p_RouteID.Direction = ParameterDirection.Input;
                p_RouteID.Value = schedule.RouteID;
                command.Parameters.Add(p_RouteID);


                //p_RouteID parameter
                OracleParameter p_busNumber = new OracleParameter("p_busNumber", OracleDbType.Varchar2);
                p_busNumber.Direction = ParameterDirection.Input;
                p_busNumber.Value = schedule.busNumber;
                command.Parameters.Add(p_busNumber);


                //p_driverID parameter
                OracleParameter p_driverID = new OracleParameter("p_driverID", OracleDbType.Varchar2);
                p_driverID.Direction = ParameterDirection.Input;
                p_driverID.Value = schedule.driverID;
                command.Parameters.Add(p_driverID);



                command.ExecuteNonQuery();
                //MessageBox.Show(command.Parameters["ret"].Value.ToString());
                if (command.Parameters["ret"].Value.ToString() == "inserted")
                {
                    isInserted = true;
                    MessageBox.Show("Schedule Created Successfully!");

                }



                con.Close();
                return isInserted;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Schedule insertion error: " + ex.Message);
                con.Close();
                return false;
            }
        }
    }
}
