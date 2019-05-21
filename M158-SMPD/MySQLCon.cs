﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD
{
    class MySQLCon: IDisposable
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

            server = Properties.Settings.Default.DBServer;
            database = Properties.Settings.Default.DBName;
            uid = Properties.Settings.Default.DBUser;
            password = Properties.Settings.Default.DBPassword;


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
                        MessageBox.Show("Cannot connect to server. Please contact your administrator","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;

                    case 1042:
                        MessageBox.Show("Connection timeout. Please check connection settings.");
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
        public void SetSQLStatement(string query)
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

        public DataTable GetSqlStatement(string query)
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

        public void SendDataTable(DataTable changedTable, string table)
        {
            try
            {
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    if (changedTable == null)
                    {
                        //close connection
                        this.CloseConnection();
                        return;
                    }
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM " + table, connection);
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                    mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                    mySqlDataAdapter.Update(changedTable);

                    //close connection
                    this.CloseConnection();

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //<summary>
        //DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
        //    if (changes == null)
        //    {
        //        return;
        //    }
        //    conn.SendDataTable(changes, "tbl_semester");
        //    ((DataTable) dataGridView1.DataSource).AcceptChanges();
        //</summary>
        
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                connection.Close();
            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
