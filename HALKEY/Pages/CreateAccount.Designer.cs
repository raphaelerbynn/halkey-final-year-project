namespace HALKEY.Pages
{
    partial class CreateAccount
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
            this.bgPanel = new System.Windows.Forms.Panel();
            this.genderCb = new System.Windows.Forms.ComboBox();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.singUpBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sysTb = new System.Windows.Forms.TextBox();
            this.cPwdTb = new System.Windows.Forms.TextBox();
            this.pwdTb = new System.Windows.Forms.TextBox();
            this.contactTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgPanel.Controls.Add(this.genderCb);
            this.bgPanel.Controls.Add(this.backLink);
            this.bgPanel.Controls.Add(this.singUpBtn);
            this.bgPanel.Controls.Add(this.uploadBtn);
            this.bgPanel.Controls.Add(this.profilePic);
            this.bgPanel.Controls.Add(this.label8);
            this.bgPanel.Controls.Add(this.label7);
            this.bgPanel.Controls.Add(this.label6);
            this.bgPanel.Controls.Add(this.label5);
            this.bgPanel.Controls.Add(this.label4);
            this.bgPanel.Controls.Add(this.label3);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Controls.Add(this.sysTb);
            this.bgPanel.Controls.Add(this.cPwdTb);
            this.bgPanel.Controls.Add(this.pwdTb);
            this.bgPanel.Controls.Add(this.contactTb);
            this.bgPanel.Controls.Add(this.usernameTb);
            this.bgPanel.Controls.Add(this.nameTb);
            this.bgPanel.Location = new System.Drawing.Point(-6, -1);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(786, 433);
            this.bgPanel.TabIndex = 0;
            // 
            // genderCb
            // 
            this.genderCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderCb.FormattingEnabled = true;
            this.genderCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCb.Location = new System.Drawing.Point(183, 202);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(377, 27);
            this.genderCb.TabIndex = 24;
            // 
            // backLink
            // 
            this.backLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backLink.AutoSize = true;
            this.backLink.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backLink.Location = new System.Drawing.Point(18, 402);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(36, 19);
            this.backLink.TabIndex = 23;
            this.backLink.TabStop = true;
            this.backLink.Text = "<<<";
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // singUpBtn
            // 
            this.singUpBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.singUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(179)))));
            this.singUpBtn.FlatAppearance.BorderSize = 0;
            this.singUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.singUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(115)))), ((int)(((byte)(179)))));
            this.singUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singUpBtn.ForeColor = System.Drawing.Color.White;
            this.singUpBtn.Location = new System.Drawing.Point(392, 379);
            this.singUpBtn.Name = "singUpBtn";
            this.singUpBtn.Size = new System.Drawing.Size(75, 23);
            this.singUpBtn.TabIndex = 22;
            this.singUpBtn.Text = "SING UP";
            this.singUpBtn.UseVisualStyleBackColor = true;
            this.singUpBtn.Click += new System.EventHandler(this.singUpBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uploadBtn.AutoSize = true;
            this.uploadBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.uploadBtn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.uploadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(604, 230);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(110, 25);
            this.uploadBtn.TabIndex = 21;
            this.uploadBtn.Text = "UPLOAD PROFILE";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // profilePic
            // 
            this.profilePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Image = global::HALKEY.Properties.Resources.assign;
            this.profilePic.Location = new System.Drawing.Point(595, 75);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(132, 149);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 20;
            this.profilePic.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(321, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Porter\'s Details";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Confirm Password:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "System Key:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Username:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contact:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Full Name:";
            // 
            // sysTb
            // 
            this.sysTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sysTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sysTb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sysTb.Location = new System.Drawing.Point(183, 331);
            this.sysTb.Name = "sysTb";
            this.sysTb.PasswordChar = '*';
            this.sysTb.Size = new System.Drawing.Size(377, 27);
            this.sysTb.TabIndex = 5;
            // 
            // cPwdTb
            // 
            this.cPwdTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cPwdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPwdTb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cPwdTb.Location = new System.Drawing.Point(183, 289);
            this.cPwdTb.Name = "cPwdTb";
            this.cPwdTb.PasswordChar = '*';
            this.cPwdTb.Size = new System.Drawing.Size(377, 27);
            this.cPwdTb.TabIndex = 6;
            // 
            // pwdTb
            // 
            this.pwdTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pwdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwdTb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwdTb.Location = new System.Drawing.Point(183, 246);
            this.pwdTb.Name = "pwdTb";
            this.pwdTb.PasswordChar = '*';
            this.pwdTb.Size = new System.Drawing.Size(377, 27);
            this.pwdTb.TabIndex = 7;
            // 
            // contactTb
            // 
            this.contactTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contactTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactTb.Location = new System.Drawing.Point(183, 160);
            this.contactTb.Name = "contactTb";
            this.contactTb.Size = new System.Drawing.Size(377, 27);
            this.contactTb.TabIndex = 9;
            // 
            // usernameTb
            // 
            this.usernameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTb.Location = new System.Drawing.Point(183, 118);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(377, 27);
            this.usernameTb.TabIndex = 10;
            // 
            // nameTb
            // 
            this.nameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTb.Location = new System.Drawing.Point(183, 75);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(377, 27);
            this.nameTb.TabIndex = 11;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 429);
            this.Controls.Add(this.bgPanel);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel bgPanel;
        private PictureBox profilePic;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox sysTb;
        private TextBox cPwdTb;
        private TextBox pwdTb;
        private TextBox contactTb;
        private TextBox usernameTb;
        private TextBox nameTb;
        private Button singUpBtn;
        private Button uploadBtn;
        private LinkLabel backLink;
        private ComboBox genderCb;
    }
}