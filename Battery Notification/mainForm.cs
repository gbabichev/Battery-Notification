/// <summary>
/// This program notifies you via email, log, and notification if a power state change is detected. 
/// 
/// George Babichev, 2017.
/// http://www.georgebabichev.com
/// 
/// TODO:
/// - Implement general email provider presets (Google, Yahoo, Bing)
/// - Allow users to save their email information into a preset.
/// - Add a 'enable/disable' email option, so the program can just write to the local log
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace Battery_Notification
{
    public partial class mainForm : Form
    {
        
        logWriter logging = new logWriter();
        sendMail mail = new sendMail();

        public mainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            // If it's the first time the program has run, specify a default password into the config, 
            // And display an informational message.
			/* If you have downloaded this from GitHub, please modify StringEncryption.cs, and provide
			* an encryption key. Then modify the next line of code with Password using a password generated
			* with your key! Otherwise the program won't be able to decrypt it.
			*/
            if (Properties.Settings.Default.firstRun == true)
            {
                Properties.Settings.Default.Password = ""; // <--- Modify this!
                Properties.Settings.Default.Save();
                DialogResult results = MessageBox.Show("You must configure settings before running this application", "Battery Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (results == DialogResult.OK)
                {
                    // If the "OK" button is pressed.
                    emailSettings eS = new emailSettings();
                    eS.ShowDialog();
                }
                else
                {
                    // If the 'Cancel' button is pressed'.
                    Environment.Exit(0);
                }
            }
            // Set the initial power status label.
            if(System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
            {
                lbl_status.Text = "Battery Power";
                logging.writeLog("Application started, computer on battery power.");
            }
            else
            {
                lbl_status.Text = "Main Power";
                logging.writeLog("Application started, computer on main power");
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Start checking battery status in a new thread which runs in the background.
            Thread t = new Thread(checkBatteryStatus);
            t.IsBackground = true;
            t.Start();
        }

        private void actionOnPowerChange(string color)
        {
            // Changes the color of the icon depending on what the battery state is.
            // Also sends the email, and records the data into a log.

            DateTime today = DateTime.Now;
            string mailBody = Environment.MachineName
                + " is reporting a battery state change at "
                + today.ToString("M/d/yyyy h:mm:ss tt");
            string mailSubjectBat = Environment.MachineName + " On Battery Power";
            string mailSubjectMain = Environment.MachineName + " On Main Power";

            if (color == "red")
            {
                this.Icon = Properties.Resources.iconRed;
                notifyIcon1.Icon = Properties.Resources.iconRed;
                lbl_status.Text = "Battery Power";
                Task.Run(new Action(() => mail.sendNow(mailSubjectBat, mailBody)));
                /*
                try
                {
                    //Task.Run(new Action(() => mail.sendNow(mailSubjectBat,mailBody)));
                    //mail.sendNow(mailSubjectBat, mailBody);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending email.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                logging.writeLog(mailSubjectBat);
            }
            else
            {
                this.Icon = Properties.Resources.icon;
                notifyIcon1.Icon = Properties.Resources.icon;
                lbl_status.Text = "Main Power";
                Task.Run(new Action(() => mail.sendNow(mailSubjectMain, mailBody)));
                /*
                try
                {
                    Task.Run(new Action(() => mail.sendNow(mailSubjectMain, mailBody)));
                    //mail.sendNow(mailSubjectMain, mailBody);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending email.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
                logging.writeLog(mailSubjectMain);
            }
        }

        private void checkBatteryStatus()
        {
            // Main function to check the battery status, running in background on thread 't'.
            bool previousStatus = false;
            while (0 == 0)
            {
                // Loop indefinitely
                Boolean isRunningOnBattery =
                    (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus ==
                    PowerLineStatus.Offline);
                // Check current status, against previous status to see if there was a change.
                if (isRunningOnBattery != previousStatus)
                {
                    if (isRunningOnBattery)
                    {
                        // We are on battery power
                        this.Invoke(new Action<string>(actionOnPowerChange), "red");
                    }
                    else
                    {
                        // We are on line power
                        this.Invoke(new Action<string>(actionOnPowerChange), "black");
                    }
                }
                previousStatus = isRunningOnBattery;
                System.Threading.Thread.Sleep(5000);
            }
        }
        // ------------------------------------------------------------------------------------------- // 
        private void btn_emailSettings_Click(object sender, EventArgs e)
        {
            // Settings button pressed
            Form eS = new emailSettings();
            eS.ShowDialog();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            // Hide the window into tray if the minimize button is pressed & show a balloon tip.
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                if (Properties.Settings.Default.ballonTipCount < 1)
                {
                    notifyIcon1.ShowBalloonTip(500, "Battery Notification", "You can find me in the tray here!", ToolTipIcon.Info);
                    Properties.Settings.Default.ballonTipCount++;
                    Properties.Settings.Default.Save();
                }
                this.Hide();
            }

            /*else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }*/
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // If right click, show the menu, otherwise bring the window back.
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
            else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void quitBatteryNotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailSettings es2 = new emailSettings();
            es2.selectTab(2);
            es2.ShowDialog();
        }

        private void emailSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailSettings es2 = new emailSettings();
            es2.selectTab(0);
            es2.ShowDialog();
        }
    }
}
