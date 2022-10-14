namespace HALKEY.Pages
{
    partial class StudentModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.studentDV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPostG = new System.Windows.Forms.Button();
            this.btn600 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn400 = new System.Windows.Forms.Button();
            this.btn300 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.addStudentLink = new System.Windows.Forms.LinkLabel();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_id
            // 
            this.student_id.HeaderText = "ID";
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            // 
            // student_name
            // 
            this.student_name.HeaderText = "NAME";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            // 
            // student_level
            // 
            this.student_level.HeaderText = "LEVEL";
            this.student_level.Name = "student_level";
            this.student_level.ReadOnly = true;
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.panel3);
            this.bgPanel.Controls.Add(this.panel4);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.studentDV);
            this.bgPanel.Controls.Add(this.searchBtn);
            this.bgPanel.Controls.Add(this.panel1);
            this.bgPanel.Controls.Add(this.addStudentLink);
            this.bgPanel.Controls.Add(this.searchTb);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(938, 613);
            this.bgPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(25, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 2);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(25, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 2);
            this.panel4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sort by level";
            // 
            // studentDV
            // 
            this.studentDV.AllowUserToAddRows = false;
            this.studentDV.AllowUserToDeleteRows = false;
            this.studentDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studentDV.BackgroundColor = System.Drawing.Color.White;
            this.studentDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.view,
            this.update,
            this.delete});
            this.studentDV.EnableHeadersVisualStyles = false;
            this.studentDV.Location = new System.Drawing.Point(189, 120);
            this.studentDV.Name = "studentDV";
            this.studentDV.ReadOnly = true;
            this.studentDV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentDV.RowHeadersVisible = false;
            this.studentDV.RowTemplate.Height = 25;
            this.studentDV.Size = new System.Drawing.Size(724, 476);
            this.studentDV.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "LEVEL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // view
            // 
            this.view.HeaderText = "";
            this.view.Name = "view";
            this.view.ReadOnly = true;
            // 
            // update
            // 
            this.update.HeaderText = "";
            this.update.Name = "update";
            this.update.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(823, 73);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(90, 29);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnPostG);
            this.panel1.Controls.Add(this.btn600);
            this.panel1.Controls.Add(this.btn500);
            this.panel1.Controls.Add(this.btn400);
            this.panel1.Controls.Add(this.btn300);
            this.panel1.Controls.Add(this.btn200);
            this.panel1.Controls.Add(this.btn100);
            this.panel1.Location = new System.Drawing.Point(25, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 476);
            this.panel1.TabIndex = 12;
            // 
            // btnPostG
            // 
            this.btnPostG.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPostG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostG.FlatAppearance.BorderSize = 0;
            this.btnPostG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPostG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPostG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPostG.ForeColor = System.Drawing.Color.White;
            this.btnPostG.Location = new System.Drawing.Point(0, 408);
            this.btnPostG.Name = "btnPostG";
            this.btnPostG.Size = new System.Drawing.Size(142, 68);
            this.btnPostG.TabIndex = 6;
            this.btnPostG.Text = "Postgraduate";
            this.btnPostG.UseVisualStyleBackColor = false;
            // 
            // btn600
            // 
            this.btn600.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn600.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn600.FlatAppearance.BorderSize = 0;
            this.btn600.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn600.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn600.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn600.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn600.ForeColor = System.Drawing.Color.White;
            this.btn600.Location = new System.Drawing.Point(0, 340);
            this.btn600.Name = "btn600";
            this.btn600.Size = new System.Drawing.Size(142, 68);
            this.btn600.TabIndex = 5;
            this.btn600.Text = "Level 600";
            this.btn600.UseVisualStyleBackColor = false;
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn500.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn500.FlatAppearance.BorderSize = 0;
            this.btn500.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn500.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn500.ForeColor = System.Drawing.Color.White;
            this.btn500.Location = new System.Drawing.Point(0, 272);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(142, 68);
            this.btn500.TabIndex = 4;
            this.btn500.Text = "Level 500";
            this.btn500.UseVisualStyleBackColor = false;
            // 
            // btn400
            // 
            this.btn400.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn400.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn400.FlatAppearance.BorderSize = 0;
            this.btn400.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn400.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn400.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn400.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn400.ForeColor = System.Drawing.Color.White;
            this.btn400.Location = new System.Drawing.Point(0, 204);
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(142, 68);
            this.btn400.TabIndex = 3;
            this.btn400.Text = "Level 400";
            this.btn400.UseVisualStyleBackColor = false;
            // 
            // btn300
            // 
            this.btn300.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn300.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn300.FlatAppearance.BorderSize = 0;
            this.btn300.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn300.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn300.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn300.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn300.ForeColor = System.Drawing.Color.White;
            this.btn300.Location = new System.Drawing.Point(0, 136);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(142, 68);
            this.btn300.TabIndex = 2;
            this.btn300.Text = "Level 300";
            this.btn300.UseVisualStyleBackColor = false;
            // 
            // btn200
            // 
            this.btn200.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn200.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn200.FlatAppearance.BorderSize = 0;
            this.btn200.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn200.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn200.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn200.ForeColor = System.Drawing.Color.White;
            this.btn200.Location = new System.Drawing.Point(0, 68);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(142, 68);
            this.btn200.TabIndex = 1;
            this.btn200.Text = "Level 200";
            this.btn200.UseVisualStyleBackColor = false;
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn100.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn100.FlatAppearance.BorderSize = 0;
            this.btn100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn100.ForeColor = System.Drawing.Color.White;
            this.btn100.Location = new System.Drawing.Point(0, 0);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(142, 68);
            this.btn100.TabIndex = 0;
            this.btn100.Text = "Level 100";
            this.btn100.UseVisualStyleBackColor = false;
            // 
            // addStudentLink
            // 
            this.addStudentLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudentLink.AutoSize = true;
            this.addStudentLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStudentLink.Location = new System.Drawing.Point(823, 50);
            this.addStudentLink.Name = "addStudentLink";
            this.addStudentLink.Size = new System.Drawing.Size(90, 15);
            this.addStudentLink.TabIndex = 11;
            this.addStudentLink.TabStop = true;
            this.addStudentLink.Text = "ADD STUDENT";
            this.addStudentLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addStudentLink_LinkClicked);
            // 
            // searchTb
            // 
            this.searchTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTb.Location = new System.Drawing.Point(189, 72);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(628, 29);
            this.searchTb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "STUDENTS";
            // 
            // StudentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(938, 613);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentModule";
            this.Text = "StudentModule";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_level;
        private Panel bgPanel;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private DataGridView studentDV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewImageColumn view;
        private DataGridViewImageColumn update;
        private DataGridViewImageColumn delete;
        private Button searchBtn;
        private Panel panel1;
        private Button btnPostG;
        private Button btn600;
        private Button btn500;
        private Button btn400;
        private Button btn300;
        private Button btn200;
        private Button btn100;
        private LinkLabel addStudentLink;
        private TextBox searchTb;
        private Label label1;
    }
}