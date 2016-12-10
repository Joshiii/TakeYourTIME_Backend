using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Animations;
using xDialog;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace UHAC4._0
{
    public partial class Mainform : MaterialForm
    {
        public AddStudent addstudentForm;
        public AddTeacher addteacherForm;
        public AddRoom addroomForm;
        public AddSubject addsubjectForm;
        public AttendanceSituation AttendanceSituationForm;
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            StudentInfoLoad();
            TeacherInfoLoad();
            RoomInfoLoad();
            SubjectInfoLoad();
            ClassesInfoLoad();
            dgvClasses.ClearSelection();
        }
        private void StudentInfoLoad()
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT CONCAT(FirstName,' ', LastName) AS 'StudentFullName', StudentNumber, CONCAT(Course,'-', Year,' ',Section) " +
                            " AS 'CourseYearSection', ContactNumber, CONCAT(GuardianFirstName, ' ' , GuardianLastName) AS 'GuardianFullName', " +
                            " GuardianContactNumber FROM studentinformation_table";

            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStudentList.DataSource = dt;
        }
        private void TeacherInfoLoad()
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT NFCSerialNumber, CONCAT(FirstName,' ', LastName) AS 'TeacherFullName', Username, Password, " +
                            " Gender, Address, ContactNumber, Active FROM teacherinformation_table";

            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTeachersList.DataSource = dt;
        }
        private void ClassesInfoLoad()
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT classes_table.ClassID, classes_table.SubjectID, classes_table.ClassName, classes_table.NFCSerialNumber, " +
                             "subjects_table.SubjectName, rooms_table.RoomName, classes_table.Day,classes_table.StartTime, " +
                              "classes_table.EndTime FROM classes_table left join subjects_table on classes_table.SubjectID = subjects_table.SubjectID LEFT JOIN rooms_table on classes_table.RoomID = rooms_table.RoomID";

            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClasses.DataSource = dt;
        }
        private void RoomInfoLoad()
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT RoomID, RoomCode, RoomName, RoomDescription, RoomDeviceMAC FROM rooms_table";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRoomsList.DataSource = dt;
        }
        private void SubjectInfoLoad()
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT SubjectID, SubjectName, SubjectCode, SubjectCourse FROM subjects_table";
            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSubjectList.DataSource = dt;
        }
        private void cboShowStudentSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowStudentSummary_Click(object sender, EventArgs e)
        {
            cboShowStudentSummary.DroppedDown = true;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            addstudentForm = new AddStudent();
            addstudentForm.mainForm = this;
            addstudentForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToString("hh : mm tt");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dddd | MMMM dd, yyyy");
        }
        string Status = string.Empty;
      
        string StudentNumber = string.Empty;
        private void LoadStatus(string ClassID, string Day, string Date)
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT * from classattendance_table WHERE ClassID = '" + ClassID + "' AND " +
                "Day = '" + Day +"' AND Date = '" + Date + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Status = dr["Status"].ToString();
            }
            cn.Close();
            dr.Close();
        }

        private void btnViewAttendanceSituation_Click(object sender, EventArgs e)
        {
            LoadStatus(dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString(), dgvClasses.SelectedRows[0].Cells["Day"].Value.ToString(), DateTime.Today.ToString("yyyy-MM-dd"));

            if (dgvClasses.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("You must select a class.", "Selection Error | TakeYourTime", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
            }
            else if (Status == "Dismissed")
            {
                string ClassID = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
                string SubjectID = dgvClasses.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                AttendanceSituationForm = new AttendanceSituation();
                AttendanceSituationForm.ClassID = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
                AttendanceSituationForm.SubjectID = dgvClasses.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                AttendanceSituationForm.lblNFCSerialNumber.Text = dgvClasses.SelectedRows[0].Cells["NFCSerialNumber"].Value.ToString();
                AttendanceSituationForm.lblSubjectName.Text = dgvClasses.SelectedRows[0].Cells["SubjectName3"].Value.ToString();
                AttendanceSituationForm.lblRoomName.Text = dgvClasses.SelectedRows[0].Cells["RoomID"].Value.ToString();
                AttendanceSituationForm.lblDay.Text = dgvClasses.SelectedRows[0].Cells["Day"].Value.ToString();
                AttendanceSituationForm.lblStartTime.Text = dgvClasses.SelectedRows[0].Cells["StartTime"].Value.ToString();
                AttendanceSituationForm.lblEndTime.Text = dgvClasses.SelectedRows[0].Cells["EndTime"].Value.ToString();
                AttendanceSituationForm.lblClassName.Text = dgvClasses.SelectedRows[0].Cells["ClassName"].Value.ToString();
                AttendanceSituationForm.btnDismissClass.Enabled = false;
                AttendanceSituationForm.btnDismissClass.Visible = false;
                AttendanceSituationForm.mainForm = this;
                AttendanceSituationForm.ShowDialog();
            }
            else
            {
                string ClassID = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
                string SubjectID = dgvClasses.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                AttendanceSituationForm = new AttendanceSituation();
                AttendanceSituationForm.ClassID = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
                AttendanceSituationForm.SubjectID = dgvClasses.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                AttendanceSituationForm.lblNFCSerialNumber.Text = dgvClasses.SelectedRows[0].Cells["NFCSerialNumber"].Value.ToString();
                AttendanceSituationForm.lblSubjectName.Text = dgvClasses.SelectedRows[0].Cells["SubjectName3"].Value.ToString();
                AttendanceSituationForm.lblRoomName.Text = dgvClasses.SelectedRows[0].Cells["RoomID"].Value.ToString();
                AttendanceSituationForm.lblDay.Text = dgvClasses.SelectedRows[0].Cells["Day"].Value.ToString();
                AttendanceSituationForm.lblStartTime.Text = dgvClasses.SelectedRows[0].Cells["StartTime"].Value.ToString();
                AttendanceSituationForm.lblEndTime.Text = dgvClasses.SelectedRows[0].Cells["EndTime"].Value.ToString();
                AttendanceSituationForm.lblClassName.Text = dgvClasses.SelectedRows[0].Cells["ClassName"].Value.ToString();
                AttendanceSituationForm.mainForm = this;
                AttendanceSituationForm.ShowDialog();
            }


        }

        private void btnShowListTeachers_Click(object sender, EventArgs e)
        {
            cboShowTeacherSummary.DroppedDown = true;
        }

        private void btnShowListClasses_Click(object sender, EventArgs e)
        {
            cboClassesSummary.DroppedDown = true;
        }

        private void btnShowRoomsList_Click(object sender, EventArgs e)
        {
            cboRoomsSummary.DroppedDown = true;
        }

        private void btnShowListSubjects_Click(object sender, EventArgs e)
        {
            cboSubjectsSummary.DroppedDown = true;
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            addteacherForm = new AddTeacher();
            addteacherForm.mainForm = this;
            addteacherForm.ShowDialog();
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            addroomForm = new AddRoom();
            addroomForm.mainForm = this;
            addroomForm.ShowDialog();
        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            addsubjectForm = new AddSubject();
            addsubjectForm.mainForm = this;
            addsubjectForm.ShowDialog();
        }
        private void LoadStatus1(string classa, string d, string dt)
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "SELECT * FROM classattendance_table WHERE ClassID = '" + classa + "' AND Day = '" + d + "' AND Date = '" + dt + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Status = dr["Status"].ToString();
            }
            cn.Close();
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            string Class = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
            string Day1 = dgvClasses.SelectedRows[0].Cells["Day"].Value.ToString();
            string Date1 = DateTime.Now.ToString("yyyy-MM-dd");
            LoadStatus1(Class, Day1, Date1);
            string datetime = DateTime.Now.ToString("hh:mm:ss");
            string starttime = dgvClasses.SelectedRows[0].Cells["StartTime"].Value.ToString();
            TimeSpan first = TimeSpan.Parse(datetime);
            TimeSpan second = TimeSpan.Parse(starttime);
            if (first >= second)
            {
                CustomMessageBox.Show("You cannot cancel class at this time.", "Cancelation Error | TakeYourTime", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error);
            }
            else if(Status == "Canceled")
            {
                DialogResult result = CustomMessageBox.Show("Class is already cancelled. Would You like to view? 'Yes' to Go 'No' to back", "Cancelation Error | TakeYourTime", CustomMessageBox.Buttons.YesNo, CustomMessageBox.Icon.Error);
                if (result == DialogResult.Yes)
                {
                    string ClassID = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
                    string SubjectID = dgvClasses.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                    AttendanceSituationForm = new AttendanceSituation();
                    AttendanceSituationForm.ClassID = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
                    AttendanceSituationForm.SubjectID = dgvClasses.SelectedRows[0].Cells["SubjectID"].Value.ToString();
                    AttendanceSituationForm.lblNFCSerialNumber.Text = dgvClasses.SelectedRows[0].Cells["NFCSerialNumber"].Value.ToString();
                    AttendanceSituationForm.lblSubjectName.Text = dgvClasses.SelectedRows[0].Cells["SubjectName3"].Value.ToString();
                    AttendanceSituationForm.lblRoomName.Text = dgvClasses.SelectedRows[0].Cells["RoomID"].Value.ToString();
                    AttendanceSituationForm.lblDay.Text = dgvClasses.SelectedRows[0].Cells["Day"].Value.ToString();
                    AttendanceSituationForm.lblStartTime.Text = dgvClasses.SelectedRows[0].Cells["StartTime"].Value.ToString();
                    AttendanceSituationForm.lblEndTime.Text = dgvClasses.SelectedRows[0].Cells["EndTime"].Value.ToString();
                    AttendanceSituationForm.lblClassName.Text = dgvClasses.SelectedRows[0].Cells["ClassName"].Value.ToString();
                    AttendanceSituationForm.btnDismissClass.Enabled = false;
                    AttendanceSituationForm.btnDismissClass.Visible = false;
                    AttendanceSituationForm.mainForm = this;
                    AttendanceSituationForm.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult result = CustomMessageBox.Show("Would You like to cancel the class? 'Yes' to cancel 'No' to back", "Class Cancelation | TakeYourTime", CustomMessageBox.Buttons.YesNo, CustomMessageBox.Icon.Info,CustomMessageBox.AnimateStyle.FadeIn);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection cn = new MySqlConnection(new Login().connectionString);
                    cn.Open();
                    string query = "UPDATE classattendance_table SET Status = 'Canceled' WHERE ClassID = '" + dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString() + "' AND Day = '" + dgvClasses.SelectedRows[0].Cells["Day"].Value.ToString() + "' AND Date = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    CustomMessageBox.Show("Class successfully cancelled.", "Class Cancelation | Take Your Time", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
