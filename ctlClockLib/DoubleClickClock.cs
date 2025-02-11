﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ctlClockLib
{
    public partial class DoubleClickClock : ctlClockLib.ctlClock
    {
        private DateTime dteAlarmTime;
        private bool blnAlarmSet;
        // These properties will be declared as public to allow future
        // developers to access them.
        public DateTime AlarmTime
        {
            get
            {
                return dteAlarmTime;
            }
            set
            {
                dteAlarmTime = value;
            }
        }
        public bool AlarmSet
        {
            get
            {
                return blnAlarmSet;
            }
            set
            {
                blnAlarmSet = value;
            }
        }
        private bool blnColorTicker;
        public DoubleClickClock()
        {
            InitializeComponent();
        }

        protected override void timer1_Tick(object sender, System.EventArgs e)
        {
            // Calls the Timer1_Tick method of ctlClock.
            base.timer1_Tick(sender, e);
            // Checks to see if the alarm is set.
            if (AlarmSet == false)
                return;
            else
            // If the date, hour, and minute of the alarm time are the same as
            // the current time, flash an alarm.
            {
                if (AlarmTime.Date == DateTime.Now.Date && AlarmTime.Hour ==
                    DateTime.Now.Hour && AlarmTime.Minute == DateTime.Now.Minute)
                {
                    // Sets lblAlarmVisible to true, and changes the background color based on
                    // the value of blnColorTicker. The background color of the label
                    // will flash once per tick of the clock.
                    lblAlarm.Visible = true;
                    if (blnColorTicker == false)
                    {
                        lblAlarm.BackColor = Color.Red;
                        blnColorTicker = true;
                    }
                    else
                    {
                        lblAlarm.BackColor = Color.Blue;
                        blnColorTicker = false;
                    }
                }
                else
                {
                    // Once the alarm has sounded for a minute, the label is made
                    // invisible again.
                    lblAlarm.Visible = false;
                }
            }
        }

        private void btnAlarmOff_Click(object sender, System.EventArgs e)
        {
            // Turns off the alarm.
            AlarmSet = false;
            // Hides the flashing label.
            lblAlarm.Visible = false;
        }
    }
}
