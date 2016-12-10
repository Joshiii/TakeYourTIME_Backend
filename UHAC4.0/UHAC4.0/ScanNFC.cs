using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.IO;
using MaterialSkin.Controls;
using xDialog;

namespace UHAC4._0
{
    public partial class ScanNFC : MaterialForm
    {
        public AddStudent addstudentForm;
        public AddTeacher AddTeacherForm;
        Database db = new Database();

        public String NFCSerialNumberDetected { get; set; }
        public String ConnectionID {get;set;}
        public String PIN {get; set;}

        public ScanNFC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormClosing -= ScanNFC_FormClosing;
            Close();
        }

        private void btnSetNFCConnection_Click(object sender, EventArgs e)
        {
            //Point coords = PointToScreen(btnSetNFCConnection.Location);
            //metroContextMenu1.Show(coords.X - 196, coords.Y + btnSetNFCConnection.Height);
        }

        private void ScanNFC_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void NFCConnection_TextChanged(object sender, EventArgs e)
        {
            //File.WriteAllText("NFCConnection.txt", tsConnectionID.Text + ";" + tsPIN.Text);
        }

        private void LoadNFCConnection()
        {
            string ConnectionString = File.ReadAllText("NFCConnection.txt");

            if (ConnectionString.Length == 17)
            {
                string[] split = ConnectionString.Split(':');

                txtMAC1.Text = split[0];
                txtMAC2.Text = split[1];
                txtMAC3.Text = split[2];
                txtMAC4.Text = split[3];
                txtMAC5.Text = split[4];
                txtMAC6.Text = split[5];
            }
        }

        private void ScanNFC_Load(object sender, EventArgs e)
        {
            LoadNFCConnection();
            db.ExecuteNonQuery("UPDATE scannfc_table SET NFCSerialNumberScanned = '' WHERE DeviceMACAddress = '" + MAC_Address() + "'");
            NFCSerialNumberDetected = string.Empty;
        }

        private void bwScanNFC_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable dt = db.ExecuteReader("SELECT * FROM scannfc_table WHERE DeviceMACAddress = '" + MAC_Address() + "'");
            if (dt.Rows.Count != 0)
            {
                NFCSerialNumberDetected = dt.Rows[0][2].ToString();
            }
        }

        private void bwScanNFC_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NFCSerialNumberDetected))
            {
                db.ExecuteNonQuery("UPDATE scannfc_table SET NFCSerialNumberScanned = '' WHERE DeviceMACAddress = '" + MAC_Address() + "'");

                if (MAC_Address().Length == 17)
                {
                    File.WriteAllText("NFCConnection.txt", MAC_Address());
                }
                FormClosing -= ScanNFC_FormClosing;
                Hide();
            }
        }

        private void ScanNFCTimer_Tick(object sender, EventArgs e)
        {
            if (MAC_Address().Length == 17)
            {
                if (!bwScanNFC.IsBusy)
                    bwScanNFC.RunWorkerAsync();
            }
        }

        public string MAC_Address()
        {
            return txtMAC1.Text + ":" + txtMAC2.Text + ":" + txtMAC3.Text + ":" + txtMAC4.Text + ":" + txtMAC5.Text + ":" + txtMAC6.Text;
        }

        private void MACAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender.Equals(txtMAC1))
            {
                if (txtMAC1.Text.Length == 2)
                {
                    txtMAC2.Focus();
                }
            }
            if (sender.Equals(txtMAC2))
            {
                if (txtMAC2.Text.Length == 2)
                {
                    txtMAC3.Focus();
                }
            }
            if (sender.Equals(txtMAC3))
            {
                if (txtMAC3.Text.Length == 2)
                {
                    txtMAC4.Focus();
                }
            }
            if (sender.Equals(txtMAC4))
            {
                if (txtMAC4.Text.Length == 2)
                {
                    txtMAC5.Focus();
                }
            }
            if (sender.Equals(txtMAC5))
            {
                if (txtMAC5.Text.Length == 2)
                {
                    txtMAC6.Focus();
                }
            }

            MAC_Address();
        }
    }
}
