using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using xDialog;

namespace UHAC4._0
{
    public partial class AttendanceSituation : Form
    {
        public String usertype;
        public Mainform mainForm;
        public ScanNFC ScanNFCForm;
        public string ClassID = string.Empty;
        public string SubjectID = string.Empty;

        public AttendanceSituation()
        {
            InitializeComponent();
        }


        private void openTimer_Tick(object sender, EventArgs e)
        {
            if (this.Width >= 623)
            {
                openTimer.Enabled = false;
            }
            if (this.Width <= 623)
            {
                this.Width += 50;

            }
        }
        private void ManageAccount_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadStatus();
            openTimer.Enabled = true;
        }
        private void LoadStatus()
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT * from classattendance_table WHERE ClassID = '" + ClassID + "' AND " +
                "Day = '" + lblDay.Text + "' AND Date = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblStatus.Text = dr["Status"].ToString();
            }
            cn.Close();
            dr.Close();
        }
        private void LoadStudents()
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT studentinformation_table.StudentNumber, " + 
	                              "CONCAT (studentinformation_table.FirstName, ' ', studentinformation_table.LastName) AS 'StudentFullName' " + 
                           "FROM studentinformation_table " + 
                           "LEFT JOIN classstudents_table " + 
                           "ON studentinformation_table.StudentNumber = classstudents_table.StudentNumber " + 
                           "LEFT JOIN classes_table " + 
                           "ON classstudents_table.ClassID = classes_table.ClassID " + 
                           "LEFT JOIN subjects_table " +
                           "ON classes_table.SubjectID = subjects_table.SubjectID " + 
                           "WHERE classes_table.ClassID = " + ClassID;
            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStudentList.DataSource = dt;
            cn.Close();
        }
        private void closeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Width <= 10)
            {
                openTimer.Enabled = false;
                this.Close();
            }
            if (this.Width >= 0)
            {
                this.Width -= 150; //280, 30
            }   
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDismissClass_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Are you sure you want to dismiss the class?", "Class Dismiss | Take Your Time", CustomMessageBox.Buttons.YesNo, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
            if (result == DialogResult.Yes)
            {
                MySqlConnection cn = new MySqlConnection(new Login().connectionString);
                cn.Open();
                string query = "UPDATE classattendance_table SET Status = 'Dismissed' WHERE ClassID = '" + ClassID + "' AND Day = '" + lblDay.Text + "' AND Date = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                CustomMessageBox.Show("Class successfully dismiss.", "Class Dismiss | Take Your Time", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
                btnDismissClass.Enabled = false;
                btnDismissClass.Visible = false;
                LoadStatus();
                LoadStudents();
            }
            else
            {
                return;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblClassName_Click(object sender, EventArgs e)
        {

        }

        private void lblStartTime_Click(object sender, EventArgs e)
        {

        }

        private void lblEndTime_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lblTeacherName_Click(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomName_Click(object sender, EventArgs e)
        {

        }

        private void lblSubjectName_Click(object sender, EventArgs e)
        {

        }

        private void lblNFCSerialNumber_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
