namespace HALKEY.Pages
{
    partial class UpdateStudent
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.roomCb = new System.Windows.Forms.ComboBox();
            this.levelCb = new System.Windows.Forms.ComboBox();
            this.genderCb = new System.Windows.Forms.ComboBox();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.picBtn = new System.Windows.Forms.Button();
            this.emergencyTb = new System.Windows.Forms.TextBox();
            this.programTb = new System.Windows.Forms.TextBox();
            this.contactTb = new System.Windows.Forms.TextBox();
            this.snameTb = new System.Windows.Forms.TextBox();
            this.mnameTb = new System.Windows.Forms.TextBox();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passportPic = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passportPic)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(12, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 19);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<<<";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(12, 600);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(914, 2);
            this.panel5.TabIndex = 27;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearBtn.AutoSize = true;
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(484, 546);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 27);
            this.clearBtn.TabIndex = 41;
            this.clearBtn.Text = "CLEAR DATA";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveBtn.AutoSize = true;
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(381, 546);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 27);
            this.saveBtn.TabIndex = 40;
            this.saveBtn.Text = "UPDATE DATA";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // roomCb
            // 
            this.roomCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomCb.FormattingEnabled = true;
            this.roomCb.Location = new System.Drawing.Point(172, 502);
            this.roomCb.Name = "roomCb";
            this.roomCb.Size = new System.Drawing.Size(686, 25);
            this.roomCb.TabIndex = 38;
            // 
            // levelCb
            // 
            this.levelCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.levelCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelCb.FormattingEnabled = true;
            this.levelCb.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600"});
            this.levelCb.Location = new System.Drawing.Point(172, 426);
            this.levelCb.Name = "levelCb";
            this.levelCb.Size = new System.Drawing.Size(686, 25);
            this.levelCb.TabIndex = 37;
            // 
            // genderCb
            // 
            this.genderCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderCb.FormattingEnabled = true;
            this.genderCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.genderCb.Location = new System.Drawing.Point(172, 249);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(446, 25);
            this.genderCb.TabIndex = 36;
            // 
            // categoryCb
            // 
            this.categoryCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Items.AddRange(new object[] {
            "UNDERGRADUATE",
            "POSTGRADUATE"});
            this.categoryCb.Location = new System.Drawing.Point(172, 387);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(686, 25);
            this.categoryCb.TabIndex = 39;
            // 
            // picBtn
            // 
            this.picBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBtn.AutoSize = true;
            this.picBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.picBtn.FlatAppearance.BorderSize = 0;
            this.picBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.picBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.picBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picBtn.ForeColor = System.Drawing.Color.White;
            this.picBtn.Location = new System.Drawing.Point(690, 298);
            this.picBtn.Name = "picBtn";
            this.picBtn.Size = new System.Drawing.Size(121, 27);
            this.picBtn.TabIndex = 35;
            this.picBtn.Text = "PASSPORT PICTURE";
            this.picBtn.UseVisualStyleBackColor = false;
            this.picBtn.Click += new System.EventHandler(this.picBtn_Click);
            // 
            // emergencyTb
            // 
            this.emergencyTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emergencyTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emergencyTb.Location = new System.Drawing.Point(172, 339);
            this.emergencyTb.Name = "emergencyTb";
            this.emergencyTb.Size = new System.Drawing.Size(446, 25);
            this.emergencyTb.TabIndex = 31;
            // 
            // programTb
            // 
            this.programTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.programTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.programTb.Location = new System.Drawing.Point(172, 466);
            this.programTb.Name = "programTb";
            this.programTb.Size = new System.Drawing.Size(686, 25);
            this.programTb.TabIndex = 32;
            // 
            // contactTb
            // 
            this.contactTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contactTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactTb.Location = new System.Drawing.Point(172, 295);
            this.contactTb.Name = "contactTb";
            this.contactTb.Size = new System.Drawing.Size(446, 25);
            this.contactTb.TabIndex = 28;
            // 
            // snameTb
            // 
            this.snameTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.snameTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snameTb.Location = new System.Drawing.Point(172, 202);
            this.snameTb.Name = "snameTb";
            this.snameTb.Size = new System.Drawing.Size(446, 25);
            this.snameTb.TabIndex = 30;
            // 
            // mnameTb
            // 
            this.mnameTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mnameTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnameTb.Location = new System.Drawing.Point(172, 160);
            this.mnameTb.Name = "mnameTb";
            this.mnameTb.Size = new System.Drawing.Size(446, 25);
            this.mnameTb.TabIndex = 34;
            // 
            // fnameTb
            // 
            this.fnameTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fnameTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameTb.Location = new System.Drawing.Point(172, 116);
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(446, 25);
            this.fnameTb.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(61, 469);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "*PROGRAMME:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(117, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "LEVEL:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(86, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "CATEGORY:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(60, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "ASSIGN ROOM:";
            // 
            // idTb
            // 
            this.idTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTb.Location = new System.Drawing.Point(172, 73);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(446, 25);
            this.idTb.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(72, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "*EMERGENCY\r\nCONTACT:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passportPic
            // 
            this.passportPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passportPic.Image = global::HALKEY.Properties.Resources.assign;
            this.passportPic.Location = new System.Drawing.Point(653, 73);
            this.passportPic.Name = "passportPic";
            this.passportPic.Size = new System.Drawing.Size(205, 215);
            this.passportPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passportPic.TabIndex = 26;
            this.passportPic.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(96, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "*GENDER:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(87, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "*CONTACT:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 2);
            this.panel3.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(84, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "*SURNAME:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(12, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 2);
            this.panel4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "MIDDLE NAME:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 2);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "*FIRST NAME:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "*STUDENT ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "UPDATE STUDENT DETAILS";
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(938, 613);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.roomCb);
            this.Controls.Add(this.levelCb);
            this.Controls.Add(this.genderCb);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.picBtn);
            this.Controls.Add(this.emergencyTb);
            this.Controls.Add(this.programTb);
            this.Controls.Add(this.contactTb);
            this.Controls.Add(this.snameTb);
            this.Controls.Add(this.mnameTb);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passportPic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            ((System.ComponentModel.ISupportInitialize)(this.passportPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1;
        private Panel panel5;
        private Button clearBtn;
        private Button saveBtn;
        private ComboBox roomCb;
        private ComboBox levelCb;
        private ComboBox genderCb;
        private ComboBox categoryCb;
        private Button picBtn;
        private TextBox emergencyTb;
        private TextBox programTb;
        private TextBox contactTb;
        private TextBox snameTb;
        private TextBox mnameTb;
        private TextBox fnameTb;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private TextBox idTb;
        private Label label8;
        private PictureBox passportPic;
        private Label label10;
        private Label label7;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
        private Label label5;
        private Panel panel2;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}