using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace UHAC4._0
{
    class AnimateForm
    {
        MetroForm mForm;

        Timer ShowFormTimer = new Timer();
        Timer CloseFormTimer = new Timer();

        public void ShowByFadeIn(MetroForm metroForm)
        {
            mForm = metroForm;
            ShowFormTimer.Interval = 2;
            ShowFormTimer.Tick +=new EventHandler(ShowFormTimer_Tick);
            mForm.Opacity = 0;
            mForm.Show();
            ShowFormTimer.Enabled = true;
        }

        public void ShowByFadeIn(MetroForm metroForm, IWin32Window owner)
        {
            mForm = metroForm;
            ShowFormTimer.Interval = 2;
            ShowFormTimer.Tick += new EventHandler(ShowFormTimer_Tick);
            mForm.Opacity = 0;
            mForm.Show(owner);
            ShowFormTimer.Enabled = true;
        }

        public void ShowByFadeIn(IWin32Window sender)
        {
            mForm = sender as MetroForm;
            ShowFormTimer.Interval = 2;
            ShowFormTimer.Tick += new EventHandler(ShowFormTimer_Tick);
            mForm.Opacity = 0;
            mForm.Show();
            ShowFormTimer.Enabled = true;
        }

        public void CloseByFadeIn(IWin32Window sender)
        {
            mForm = sender as MetroForm;
            CloseFormTimer.Interval = 2;
            CloseFormTimer.Tick += new EventHandler(CloseFormTimer_Tick);
            CloseFormTimer.Enabled = true;
        }

        public void ShowDialogByFadeIn(MetroForm metroForm)
        {
            mForm = metroForm;
            ShowFormTimer.Interval = 2;
            ShowFormTimer.Tick += new EventHandler(ShowFormTimer_Tick);
            mForm.Opacity = 0;
            mForm.ShowDialog();
            ShowFormTimer.Enabled = true;
        }

        public void ShowDialogByFadeIn(MetroForm metroForm, IWin32Window owner)
        {
            mForm = metroForm;
            ShowFormTimer.Interval = 2;
            ShowFormTimer.Tick += new EventHandler(ShowFormTimer_Tick);
            mForm.Opacity = 0;
            mForm.ShowDialog(owner);
            ShowFormTimer.Enabled = true;
        }

        private void ShowFormTimer_Tick(object sender, EventArgs e)
        {
            if (mForm.Opacity != 1)
            {
                mForm.Opacity += 0.1;
            }
            if (mForm.Opacity == 1)
            {
                ShowFormTimer.Enabled = false;
            }
        }

        private void CloseFormTimer_Tick(object sender, EventArgs e)
        {
            if (mForm.Opacity != 0)
            {
                mForm.Opacity -= 0.1;
            }
            if (mForm.Opacity == 0)
            {
                mForm.Close();
            }
        }
    }
}
