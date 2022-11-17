namespace HALKEY.Pages
{
    partial class AddReport
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.membersCb = new System.Windows.Forms.ComboBox();
            this.roomTb = new System.Windows.Forms.ComboBox();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.problemTb = new System.Windows.Forms.TextBox();
            this.issueTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.bgPanel.Controls.Add(this.clearBtn);
            this.bgPanel.Controls.Add(this.saveBtn);
            this.bgPanel.Controls.Add(this.membersCb);
            this.bgPanel.Controls.Add(this.roomTb);
            this.bgPanel.Controls.Add(this.backLink);
            this.bgPanel.Controls.Add(this.problemTb);
            this.bgPanel.Controls.Add(this.issueTb);
            this.bgPanel.Controls.Add(this.panel3);
            this.bgPanel.Controls.Add(this.label5);
            this.bgPanel.Controls.Add(this.panel1);
            this.bgPanel.Controls.Add(this.panel4);
            this.bgPanel.Controls.Add(this.label4);
            this.bgPanel.Controls.Add(this.label3);
            this.bgPanel.Controls.Add(this.panel2);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(938, 613);
            this.bgPanel.TabIndex = 0;
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
            this.clearBtn.Location = new System.Drawing.Point(487, 556);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 27);
            this.clearBtn.TabIndex = 19;
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
            this.saveBtn.Location = new System.Drawing.Point(384, 556);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(76, 27);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "SAVE DATA";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // membersCb
            // 
            this.membersCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.membersCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.membersCb.Enabled = false;
            this.membersCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.membersCb.FormattingEnabled = true;
            this.membersCb.Location = new System.Drawing.Point(233, 439);
            this.membersCb.Name = "membersCb";
            this.membersCb.Size = new System.Drawing.Size(520, 25);
            this.membersCb.TabIndex = 18;
            // 
            // roomTb
            // 
            this.roomTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.roomTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomTb.FormattingEnabled = true;
            this.roomTb.Location = new System.Drawing.Point(233, 392);
            this.roomTb.Name = "roomTb";
            this.roomTb.Size = new System.Drawing.Size(520, 25);
            this.roomTb.TabIndex = 18;
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backLink.Location = new System.Drawing.Point(12, 18);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(39, 19);
            this.backLink.TabIndex = 17;
            this.backLink.TabStop = true;
            this.backLink.Text = "<<<";
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // problemTb
            // 
            this.problemTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.problemTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.problemTb.Location = new System.Drawing.Point(233, 149);
            this.problemTb.Multiline = true;
            this.problemTb.Name = "problemTb";
            this.problemTb.Size = new System.Drawing.Size(520, 220);
            this.problemTb.TabIndex = 16;
            // 
            // issueTb
            // 
            this.issueTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.issueTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.issueTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issueTb.Location = new System.Drawing.Point(233, 105);
            this.issueTb.Name = "issueTb";
            this.issueTb.Size = new System.Drawing.Size(520, 25);
            this.issueTb.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 2);
            this.panel3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(106, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "ROOM MEMBER:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 2);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(12, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 2);
            this.panel4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(166, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "ROOM:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "PROBLEM STATEMENT:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 2);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "ISSUE TITLE:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADD REPORT DETAILS";
            // 
            // AddReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 613);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReport";
            this.Text = "AddReport";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel bgPanel;
        private LinkLabel backLink;
        private TextBox issueTb;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private ComboBox membersCb;
        private ComboBox roomTb;
        private TextBox problemTb;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button clearBtn;
        private Button saveBtn;
        private Panel panel1;
    }
}