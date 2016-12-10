using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.IO;
using MySql.Data.MySqlClient;
using xDialog;

namespace UHAC4._0
{
    public partial class Login : MaterialForm
    {
        public Mainform mainForm;
        public String connectionString = File.ReadAllText(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Classes\\ConnectionString.txt");
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void LoginMethod()
        {
            MySqlConnection cn = new MySqlConnection(connectionString);
            cn.Open();
            string query = "SELECT * FROM systemusers_table WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                this.Hide();
                mainForm = new Mainform();
                mainForm.ShowDialog();
                while (dr.Read())
                {

                }
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            LoginMethod();

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            LoginMethod();
        }
    }
}
