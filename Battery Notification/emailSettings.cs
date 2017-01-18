using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Battery_Notification
{
    public partial class emailSettings : Form
    {
        logWriter logging = new logWriter();
        StringEncryption encryptedPW = new StringEncryption();
        string logFileLocationWithoutTxt;

        public emailSettings()
        {
            InitializeComponent();
            selectTab(1);
            // Populate data from settings
            // Email Tab
            txtBox_host.Text = Properties.Settings.Default.Host;
            txtBox_port.Text = Properties.Settings.Default.Port.ToString();
            txtBox_username.Text = Properties.Settings.Default.Username;
            txtBox_pw.Text = encryptedPW.Decrypt(Properties.Settings.Default.Password);
            txtBox_displayName.Text = Properties.Settings.Default.displayName;
            txtBox_sendTo.Text = Properties.Settings.Default.sendTo;
            chkBox_SSL.Checked = Properties.Settings.Default.SSL;
            // Program Tab
            txtBox_logLocation.Text = Properties.Settings.Default.logLocation;
            // About Tab
            lbl_version.Text = "Version: " + Application.ProductVersion;

            this.ActiveControl = txtBox_host;

            if (Properties.Settings.Default.firstRun)
            {
                tabControl1.SelectedIndex = 1;
            }

        }

        public void selectTab(int tabNumber)
        {
            tabControl1.SelectedIndex = tabNumber;
        }

        private void saveEmailSettings()
        {
            // Saves email settings
            Properties.Settings.Default.Host = txtBox_host.Text;
            Properties.Settings.Default.Port = Int32.Parse(txtBox_port.Text);
            Properties.Settings.Default.Username = txtBox_username.Text;
            Properties.Settings.Default.displayName = txtBox_displayName.Text;
            Properties.Settings.Default.Password = encryptedPW.Encrypt(txtBox_pw.Text);
            Properties.Settings.Default.SSL = chkBox_SSL.Checked;
            Properties.Settings.Default.sendTo = txtBox_sendTo.Text;
            Properties.Settings.Default.Save();
        }

        private void progressIsMoving(bool startMoving)
        {
            if (startMoving)
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 25;
                progressBar1.Update();
            }
            else
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = 0;
                progressBar1.Update();
            }
        }

        private void testEmail()
        {
            this.Invoke(new Action<bool>(progressIsMoving), true);
            sendMail mail = new sendMail();
            try
            {
                mail.sendNow("Battery Notification Email Test","Test email from Battery Notification");
                logging.writeLog("Sent test email");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email.\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                logging.writeLog("Error sending email.\n" + ex.Message);
            }
            this.Invoke(new Action<bool>(progressIsMoving), false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Save button on E-Mail tab pressed
            if (Properties.Settings.Default.logLocation == "")
            {
                MessageBox.Show("Please configure the log location first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                saveEmailSettings();
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            // Test email button 
            if(Properties.Settings.Default.logLocation == "")
            {
                MessageBox.Show("Please configure the log location first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                saveEmailSettings();
                Task.Run(new Action(testEmail));
                /* Older Method
                Thread t2 = new Thread(testEmail);
                t2.IsBackground = true;
                t2.Start(); */
            }

        }

        private void btn_saveLogLocation_Click(object sender, EventArgs e)
        {
            // Save button pressed under Program Settings
            if (logging.checkValidityLocation(logFileLocationWithoutTxt))
            {
                Properties.Settings.Default.logLocation = txtBox_logLocation.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Unable to write to given directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox_logLocation.Clear();
            }
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog odf = new FolderBrowserDialog();
            if (odf.ShowDialog() == DialogResult.OK)
            {
                string lastItem = odf.SelectedPath.Substring(odf.SelectedPath.Length - 1, 1);
                if (lastItem == "\\")
                {
                    txtBox_logLocation.Text = odf.SelectedPath + "batteryLog.txt";
                }
                else
                {
                    txtBox_logLocation.Text = odf.SelectedPath + "\\batteryLog.txt";
                }
                logFileLocationWithoutTxt = odf.SelectedPath;
            }
        }

        private void emailSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check to see if the log location & Email PW is set.
            /*if (Properties.Settings.Default.Password == "")
            {
                //MessageBox.Show("You must specify an SMTP Account Password to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel = true;
                //return;
                Properties.Settings.Default.Password = encryptedPW.Encrypt("Password");
                Properties.Settings.Default.Save();
            }*/
            // UPDATE THIS TO REFLEC TTHE NEW CHANGES
            if (Properties.Settings.Default.logLocation != "")
            {
                Properties.Settings.Default.firstRun = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                // Cancel the form close operation
                e.Cancel = true;
                MessageBox.Show("You must specify a log location before exiting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btn_viewLog_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.logLocation != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(txtBox_logLocation.Text);
                }
                catch
                {
                    MessageBox.Show("Error opening log. Please set a log location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBox_logLocation.Clear();
                    Properties.Settings.Default.logLocation = "";
                    Properties.Settings.Default.Save();
                }

            }
        }

        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.logLocation != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(Directory.GetParent(txtBox_logLocation.Text).ToString());
                }
                catch
                {
                    MessageBox.Show("Error opening log folder. Please set a log location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBox_logLocation.Clear();
                    Properties.Settings.Default.logLocation = "";
                    Properties.Settings.Default.Save();
                }

            }
        }

        private void emailSet_Enter(object sender, EventArgs e)
        {
            // UPDATE THIS
            if (Properties.Settings.Default.logLocation == "")
            {
                tabControl1.SelectedIndex = 1;
                MessageBox.Show("Please set a log location first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBox_host_Enter(object sender, EventArgs e)
        {
            txtBox_host.SelectionStart = 0;
            txtBox_host.SelectionLength = txtBox_host.Text.Length;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.georgebabichev.com");
        }
    }
}
