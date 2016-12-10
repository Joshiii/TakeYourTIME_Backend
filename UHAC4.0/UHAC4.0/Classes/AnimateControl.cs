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
using UHAC4._0.Properties;

namespace UHAC4._0
{
    class AnimateControl
    {
        MetroPanel mPanel;
        int mPanelHeight = 0;
        int mPanelHeightIncrement = 0;

        int mPanelWidth = 0;
        int mPanelWidthIncrement = 0;

        Timer SlideDownTimer = new Timer();
        Timer SlideUpTimer = new Timer();
        Timer SlideLeftTimer = new Timer();
        Timer SlideRightTimer = new Timer();

        public void AnimatePanel(MetroPanel metroPanel, int Height, int Increment, string Action)
        {
            mPanel = metroPanel;
            mPanelHeight = Height;
            mPanelHeightIncrement = Increment;

            if (Action == "Expand")
            {
                SlideDownTimer.Interval = 1;
                SlideDownTimer.Tick += new EventHandler(SlideDownTimer_Tick);
                SlideDownTimer.Enabled = true;
            }
            else if (Action == "Collapse")
            {
                SlideUpTimer.Interval = 1;
                SlideUpTimer.Tick += new EventHandler(SlideUpTimer_Tick);
                SlideUpTimer.Enabled = true;
            }
        }

        public void AnimatePanelSideward(MetroPanel metroPanel, int width, int Increment, string Action)
        {
            mPanel = metroPanel;
            mPanelWidth = width;
            mPanelWidthIncrement = Increment;

            if (Action == "Expand")
            {
                SlideRightTimer.Interval = 1;
                SlideRightTimer.Tick += new EventHandler(SlideRightTimer_Tick);
                SlideRightTimer.Enabled = true;
            }
            else if (Action == "Collapse")
            {
                SlideLeftTimer.Interval = 1;
                SlideLeftTimer.Tick += new EventHandler(SlideLeftTimer_Tick);
                SlideLeftTimer.Enabled = true;
            }
        }

        public void SlideDownTimer_Tick(object sender, EventArgs e)
        {
            if (mPanel.Height != mPanelHeight)
            {
                mPanel.Height += mPanelHeightIncrement;
            }
            if (mPanel.Height == mPanelHeight)
            {
                SlideDownTimer.Enabled = false;
            }
        }

        public void SlideUpTimer_Tick(object sender, EventArgs e)
        {
            if (mPanel.Height != mPanelHeight)
            {
                mPanel.Height -= mPanelHeightIncrement;
            }
            if (mPanel.Height == mPanelHeight)
            {
                SlideUpTimer.Enabled = false;
            }
        }

        public void SlideRightTimer_Tick(object sender, EventArgs e)
        {
            if (mPanel.Width != mPanelWidth)
            {
                mPanel.Width += mPanelWidthIncrement;
            }
            if (mPanel.Width == mPanelWidth)
            {
                SlideRightTimer.Enabled = false;
            }
        }

        public void SlideLeftTimer_Tick(object sender, EventArgs e)
        {
            if (mPanel.Width != mPanelWidth)
            {
                mPanel.Width -= mPanelWidthIncrement;
            }
            if (mPanel.Width == mPanelWidth)
            {
                SlideLeftTimer.Enabled = false;
            }
        }

        public void SelectButton(object sender)
        {

        }
    }
}
