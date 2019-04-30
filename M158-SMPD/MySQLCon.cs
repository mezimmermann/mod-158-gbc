using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD
{
    class MySQLCon
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;



        //Constructor

        public MySQLCon()
        {
            Initialize();
        }

        //Initialize values

        private void Initialize()

        {

            server = "192.168.2.88";
            database = "access";
            uid = "remote";
            password = "remote";
            
            
            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +

            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }

            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                    default:
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        //Insert statement
        public void setSQLStatement(string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }



        //Select statement

        public DataTable getSQLStatement(string query)
        {
            DataTable data = new DataTable();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                dataAdapter.Fill(data);

                //close connection
                this.CloseConnection();

                return data;
            }
            else
            {
                return data;
            }
        }
    }
}
