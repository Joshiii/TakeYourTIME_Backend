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
    public partial class AddStudent : Form
    {
        public String usertype;
        public Mainform mainForm;
        public ScanNFC ScanNFCForm;


        public AddStudent()
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
            openTimer.Enabled = true;
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

        private void btnScanNFC_Click(object sender, EventArgs e)
        {
            ScanNFCForm = new ScanNFC();
            ScanNFCForm.addstudentForm = this;
            ScanNFCForm.ShowDialog();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(new Login().connectionString);
            cn.Open();
            string query = "INSERT INTO studentinformation_table(NFCSerialNumber, StudentFullName, StudentNumber, Gender, Course, YearAndSection, " +
                           " GuardianName, GuardianContactNumber) VALUES (@NFCSerialNumber, @StudentFullName, @StudentNumber, @Gender, @Course, @YearAndSection, " +
                           " @GuardianName, @GuardianContactNumber)";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.Parameters.AddWithValue(@"NFCSerialNumber", txtNFCSerialNumber.Text);
            cmd.Parameters.AddWithValue(@"StudentFullName", txtStudentFullName.Text);
            cmd.Parameters.AddWithValue(@"StudentNumber", txtStudentNumber.Text);
            cmd.Parameters.AddWithValue(@"Gender", cboGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue(@"Course", cboCourse.Text);
            cmd.Parameters.AddWithValue(@"YearAndSection", cboYearAndSection.Text);
            cmd.Parameters.AddWithValue(@"GuardianName", txtGuardianName.Text);
            cmd.Parameters.AddWithValue(@"GuardianContactNumber",txtGuardianValidContactNumber.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            CustomMessageBox.Show("Succesfully Adding on the Database", "Adding Students", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);

        }

        private void cboChooseOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Title = "Select Employee's Photo (2x2)";
            fileChooser.Filter = "JPG Files(*.jpg)|*.jpg";
            DialogResult result = fileChooser.ShowDialog();
            string fileName = fileChooser.FileName;
            string PhotoFileName = string.Empty;
            Image img;

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else if (result == DialogResult.OK && string.IsNullOrWhiteSpace(fileName))
            {
                CustomMessageBox.Show("Invalid Location or Image. Please select a Valid Image in a JPEG(.jpg/.jpeg) File Extension.", "Location/Image Error", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Error, CustomMessageBox.AnimateStyle.FadeIn);
            }
            else
            {
                img = Image.FromFile(fileName);
                pictureBox8.Image = img;
                PhotoFileName = fileChooser.SafeFileName.ToString();
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtNFCSerialNumber.Clear();
            txtStudentFullName.Clear();
            txtStudentNumber.Clear();
            txtGuardianName.Clear();
            txtGuardianValidContactNumber.Clear();
            cboCourse.SelectedItem = "";
            cboGender.SelectedItem = "";
            cboYearAndSection.SelectedItem = "";
        }
    }
}
