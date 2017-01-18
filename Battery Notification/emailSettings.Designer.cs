namespace Battery_Notification
{
    partial class emailSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailSettings));
            this.txtBox_host = new System.Windows.Forms.TextBox();
            this.txtBox_port = new System.Windows.Forms.TextBox();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.txtBox_pw = new System.Windows.Forms.TextBox();
            this.lbl_Host = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_PW = new System.Windows.Forms.Label();
            this.chkBox_SSL = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.lbl_displayName = new System.Windows.Forms.Label();
            this.txtBox_displayName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.emailSet = new System.Windows.Forms.TabPage();
            this.txtBox_sendTo = new System.Windows.Forms.TextBox();
            this.lbl_toAddress = new System.Windows.Forms.Label();
            this.progSet = new System.Windows.Forms.TabPage();
            this.btn_openFolder = new System.Windows.Forms.Button();
            this.btn_viewLog = new System.Windows.Forms.Button();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.btn_saveLogLocation = new System.Windows.Forms.Button();
            this.txtBox_logLocation = new System.Windows.Forms.TextBox();
            this.lbl_logLocation = new System.Windows.Forms.Label();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.emailSet.SuspendLayout();
            this.progSet.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_host
            // 
            this.txtBox_host.Location = new System.Drawing.Point(127, 6);
            this.txtBox_host.Name = "txtBox_host";
            this.txtBox_host.Size = new System.Drawing.Size(188, 20);
            this.txtBox_host.TabIndex = 0;
            this.txtBox_host.Enter += new System.EventHandler(this.txtBox_host_Enter);
            // 
            // txtBox_port
            // 
            this.txtBox_port.Location = new System.Drawing.Point(127, 32);
            this.txtBox_port.Name = "txtBox_port";
            this.txtBox_port.Size = new System.Drawing.Size(188, 20);
            this.txtBox_port.TabIndex = 1;
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(127, 58);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(188, 20);
            this.txtBox_username.TabIndex = 2;
            // 
            // txtBox_pw
            // 
            this.txtBox_pw.Location = new System.Drawing.Point(127, 84);
            this.txtBox_pw.Name = "txtBox_pw";
            this.txtBox_pw.PasswordChar = '*';
            this.txtBox_pw.Size = new System.Drawing.Size(188, 20);
            this.txtBox_pw.TabIndex = 3;
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.Location = new System.Drawing.Point(5, 9);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(62, 13);
            this.lbl_Host.TabIndex = 5;
            this.lbl_Host.Text = "SMTP Host";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(5, 35);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(66, 13);
            this.lbl_Port.TabIndex = 6;
            this.lbl_Port.Text = "Port Number";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(5, 61);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_PW
            // 
            this.lbl_PW.AutoSize = true;
            this.lbl_PW.Location = new System.Drawing.Point(5, 87);
            this.lbl_PW.Name = "lbl_PW";
            this.lbl_PW.Size = new System.Drawing.Size(53, 13);
            this.lbl_PW.TabIndex = 9;
            this.lbl_PW.Text = "Password";
            // 
            // chkBox_SSL
            // 
            this.chkBox_SSL.AutoSize = true;
            this.chkBox_SSL.Location = new System.Drawing.Point(127, 161);
            this.chkBox_SSL.Name = "chkBox_SSL";
            this.chkBox_SSL.Size = new System.Drawing.Size(15, 14);
            this.chkBox_SSL.TabIndex = 6;
            this.chkBox_SSL.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(240, 190);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(8, 189);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 7;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // lbl_displayName
            // 
            this.lbl_displayName.AutoSize = true;
            this.lbl_displayName.Location = new System.Drawing.Point(5, 113);
            this.lbl_displayName.Name = "lbl_displayName";
            this.lbl_displayName.Size = new System.Drawing.Size(72, 13);
            this.lbl_displayName.TabIndex = 13;
            this.lbl_displayName.Text = "Display Name";
            // 
            // txtBox_displayName
            // 
            this.txtBox_displayName.Location = new System.Drawing.Point(127, 110);
            this.txtBox_displayName.Name = "txtBox_displayName";
            this.txtBox_displayName.Size = new System.Drawing.Size(188, 20);
            this.txtBox_displayName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Use SSL?";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 219);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.emailSet);
            this.tabControl1.Controls.Add(this.progSet);
            this.tabControl1.Controls.Add(this.aboutPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 275);
            this.tabControl1.TabIndex = 21;
            // 
            // emailSet
            // 
            this.emailSet.Controls.Add(this.txtBox_sendTo);
            this.emailSet.Controls.Add(this.lbl_toAddress);
            this.emailSet.Controls.Add(this.txtBox_host);
            this.emailSet.Controls.Add(this.progressBar1);
            this.emailSet.Controls.Add(this.txtBox_port);
            this.emailSet.Controls.Add(this.label4);
            this.emailSet.Controls.Add(this.txtBox_username);
            this.emailSet.Controls.Add(this.txtBox_displayName);
            this.emailSet.Controls.Add(this.txtBox_pw);
            this.emailSet.Controls.Add(this.lbl_displayName);
            this.emailSet.Controls.Add(this.lbl_Host);
            this.emailSet.Controls.Add(this.btn_test);
            this.emailSet.Controls.Add(this.lbl_Port);
            this.emailSet.Controls.Add(this.btn_save);
            this.emailSet.Controls.Add(this.lbl_Username);
            this.emailSet.Controls.Add(this.chkBox_SSL);
            this.emailSet.Controls.Add(this.lbl_PW);
            this.emailSet.Location = new System.Drawing.Point(4, 22);
            this.emailSet.Name = "emailSet";
            this.emailSet.Padding = new System.Windows.Forms.Padding(3);
            this.emailSet.Size = new System.Drawing.Size(323, 249);
            this.emailSet.TabIndex = 0;
            this.emailSet.Text = "Email Settings";
            this.emailSet.UseVisualStyleBackColor = true;
            this.emailSet.Enter += new System.EventHandler(this.emailSet_Enter);
            // 
            // txtBox_sendTo
            // 
            this.txtBox_sendTo.Location = new System.Drawing.Point(127, 136);
            this.txtBox_sendTo.Name = "txtBox_sendTo";
            this.txtBox_sendTo.Size = new System.Drawing.Size(188, 20);
            this.txtBox_sendTo.TabIndex = 5;
            // 
            // lbl_toAddress
            // 
            this.lbl_toAddress.AutoSize = true;
            this.lbl_toAddress.Location = new System.Drawing.Point(5, 139);
            this.lbl_toAddress.Name = "lbl_toAddress";
            this.lbl_toAddress.Size = new System.Drawing.Size(76, 13);
            this.lbl_toAddress.TabIndex = 22;
            this.lbl_toAddress.Text = "Who to notify?";
            // 
            // progSet
            // 
            this.progSet.Controls.Add(this.btn_openFolder);
            this.progSet.Controls.Add(this.btn_viewLog);
            this.progSet.Controls.Add(this.btn_SelectFile);
            this.progSet.Controls.Add(this.btn_saveLogLocation);
            this.progSet.Controls.Add(this.txtBox_logLocation);
            this.progSet.Controls.Add(this.lbl_logLocation);
            this.progSet.Location = new System.Drawing.Point(4, 22);
            this.progSet.Name = "progSet";
            this.progSet.Padding = new System.Windows.Forms.Padding(3);
            this.progSet.Size = new System.Drawing.Size(323, 249);
            this.progSet.TabIndex = 1;
            this.progSet.Text = "Program Settings";
            this.progSet.UseVisualStyleBackColor = true;
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.Location = new System.Drawing.Point(132, 63);
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.Size = new System.Drawing.Size(100, 23);
            this.btn_openFolder.TabIndex = 5;
            this.btn_openFolder.Text = "Open Log Folder";
            this.btn_openFolder.UseVisualStyleBackColor = true;
            this.btn_openFolder.Click += new System.EventHandler(this.btn_openFolder_Click);
            // 
            // btn_viewLog
            // 
            this.btn_viewLog.Location = new System.Drawing.Point(12, 63);
            this.btn_viewLog.Name = "btn_viewLog";
            this.btn_viewLog.Size = new System.Drawing.Size(75, 23);
            this.btn_viewLog.TabIndex = 4;
            this.btn_viewLog.Text = "View Log";
            this.btn_viewLog.UseVisualStyleBackColor = true;
            this.btn_viewLog.Click += new System.EventHandler(this.btn_viewLog_Click);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(238, 34);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 3;
            this.btn_SelectFile.Text = "Select File";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // btn_saveLogLocation
            // 
            this.btn_saveLogLocation.Location = new System.Drawing.Point(238, 217);
            this.btn_saveLogLocation.Name = "btn_saveLogLocation";
            this.btn_saveLogLocation.Size = new System.Drawing.Size(75, 23);
            this.btn_saveLogLocation.TabIndex = 2;
            this.btn_saveLogLocation.Text = "Save";
            this.btn_saveLogLocation.UseVisualStyleBackColor = true;
            this.btn_saveLogLocation.Click += new System.EventHandler(this.btn_saveLogLocation_Click);
            // 
            // txtBox_logLocation
            // 
            this.txtBox_logLocation.Location = new System.Drawing.Point(12, 36);
            this.txtBox_logLocation.Name = "txtBox_logLocation";
            this.txtBox_logLocation.ReadOnly = true;
            this.txtBox_logLocation.Size = new System.Drawing.Size(220, 20);
            this.txtBox_logLocation.TabIndex = 1;
            // 
            // lbl_logLocation
            // 
            this.lbl_logLocation.AutoSize = true;
            this.lbl_logLocation.Location = new System.Drawing.Point(9, 17);
            this.lbl_logLocation.Name = "lbl_logLocation";
            this.lbl_logLocation.Size = new System.Drawing.Size(69, 13);
            this.lbl_logLocation.TabIndex = 0;
            this.lbl_logLocation.Text = "Log Location";
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.linkLabel1);
            this.aboutPage.Controls.Add(this.textBox1);
            this.aboutPage.Controls.Add(this.lbl_version);
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Size = new System.Drawing.Size(323, 249);
            this.aboutPage.TabIndex = 2;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(203, 233);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "George Babichev 2017";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 227);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(2, 233);
            this.lbl_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(42, 13);
            this.lbl_version.TabIndex = 0;
            this.lbl_version.Text = "Version";
            // 
            // emailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 274);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 313);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(345, 313);
            this.Name = "emailSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Battery Notification Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.emailSettings_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.emailSet.ResumeLayout(false);
            this.emailSet.PerformLayout();
            this.progSet.ResumeLayout(false);
            this.progSet.PerformLayout();
            this.aboutPage.ResumeLayout(false);
            this.aboutPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_host;
        private System.Windows.Forms.TextBox txtBox_port;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.TextBox txtBox_pw;
        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_PW;
        private System.Windows.Forms.CheckBox chkBox_SSL;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lbl_displayName;
        private System.Windows.Forms.TextBox txtBox_displayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage emailSet;
        private System.Windows.Forms.TabPage progSet;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.Label lbl_logLocation;
        private System.Windows.Forms.Button btn_saveLogLocation;
        private System.Windows.Forms.TextBox txtBox_logLocation;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Button btn_openFolder;
        private System.Windows.Forms.Button btn_viewLog;
        private System.Windows.Forms.TextBox txtBox_sendTo;
        private System.Windows.Forms.Label lbl_toAddress;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}