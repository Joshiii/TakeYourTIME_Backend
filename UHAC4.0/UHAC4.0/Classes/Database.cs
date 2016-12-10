using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Data.SqlClient;
using xDialog;

namespace UHAC4._0
{
    class Database
    {
        public static String connectionString = File.ReadAllText(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Classes\\ConnectionString.txt");
        public String cns = connectionString;
        public MySqlConnection cn = new MySqlConnection(connectionString);
        private MySqlDataAdapter ap;
        private DataTable dt;

        public string ConString { 
            get
            {
                return connectionString;
            }
            set
            {

            }
        }

        public String QUERY { get; set; }

        public Database()
        {
            try
            {
                connectionString = File.ReadAllText(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Classes\\ConnectionString.txt");
                cn = new MySqlConnection(connectionString);

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
            }
        }

        public bool IsConnectionEstablished()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool IsConnectionEstablished(string ServerName)
        {
            try
            {
                cn = new MySqlConnection("SERVER = " + ServerName + "; UID = root; PASSWORD = ; DATABASE = takeyourtime_db;");
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ExecuteReader(String query)
        {
            dt = new DataTable();
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    ap = new MySqlDataAdapter(query, cn);
                    ap.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return null;
            }
        }

        public bool ExecuteNonQuery(String query)
        {
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                    return false;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return false;
            }
        }

        public DataTable ReadAllData(String table)
        {
            String query = "SELECT * FROM " + table;
            dt = new DataTable();
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    ap = new MySqlDataAdapter(query, cn);
                    ap.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                    return null;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return null;
            }
        }

        public DataTable ReadData(String table, String columns, String conditionalColumn, String conditionalValue)
        {
            String query = "SELECT " + columns + " FROM " + table + " WHERE " + conditionalColumn + " = " + conditionalValue;
            dt = new DataTable();
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    ap = new MySqlDataAdapter(query, cn);
                    ap.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                    return null;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return null;
            }
        }

        public DataTable ReadData(String table, String columns, String conditionalColumn, String conditionalValue, String orderByColumn, String orderByType)
        {
            String query = "SELECT " + columns + " FROM " + table + " WHERE " + conditionalColumn + " = " + conditionalValue + " ORDER BY " + orderByColumn + " " + orderByType;
            dt = new DataTable();
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    ap = new MySqlDataAdapter(query, cn);
                    ap.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                    return null;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return null;
            }
        }

        public bool InsertData(String table, String columns, String values)
        {
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    String query = "INSERT INTO " + table + " (" + columns + ") VALUES (" + values + ")";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                    return false;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return false;
            }
        }

        public bool UpdateData(String table, String columns, String values, String conditionalColumn, String conditionalValue)
        {
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    String query = "UPDATE " + table + " SET " + columns + " = " + values + " WHERE " + conditionalColumn + " = " + conditionalValue;
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                    return false;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return false;
            }
        }

        public bool DeleteData(String table, String conditionalColumn, String conditionalValue)
        {
            if (cn.State == ConnectionState.Open)
            {
                try
                {
                    String query = "DELETE FROM " + table + " WHERE " + conditionalColumn + " = " + conditionalValue;
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                    return false;
                }
            }
            else
            {
                CustomMessageBox.Show("Contact your System Administrator", "Initialize Database Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
                return false;
            }
        }

        public string LocalIPAddress
        {
            get{
                IPHostEntry host;
                string localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
                return localIP;
            }
        }
    }
}
