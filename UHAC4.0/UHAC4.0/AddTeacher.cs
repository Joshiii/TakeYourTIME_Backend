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
    public partial class AddTeacher : Form
    {
        public String usertype;
        public Mainform mainForm;
        public ScanNFC ScanNFCForm;


        public AddTeacher()
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ScanNFCForm = new ScanNFC();
            ScanNFCForm.AddTeacherForm = this;
            ScanNFCForm.ShowDialog();
        }
    }
}
