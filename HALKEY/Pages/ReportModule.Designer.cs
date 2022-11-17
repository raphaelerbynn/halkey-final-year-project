namespace HALKEY.Pages
{
    partial class ReportModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.solvedBtn = new System.Windows.Forms.Button();
            this.problemTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addStudentLink = new System.Windows.Forms.LinkLabel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomDV = new System.Windows.Forms.DataGridView();
            this.report_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDV)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.solvedBtn);
            this.bgPanel.Controls.Add(this.problemTb);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Controls.Add(this.addStudentLink);
            this.bgPanel.Controls.Add(this.panel12);
            this.bgPanel.Controls.Add(this.panel2);
            this.bgPanel.Controls.Add(this.panel1);
            this.bgPanel.Controls.Add(this.roomDV);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(938, 613);
            this.bgPanel.TabIndex = 0;
            // 
            // solvedBtn
            // 
            this.solvedBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.solvedBtn.AutoSize = true;
            this.solvedBtn.BackColor = System.Drawing.Color.Green;
            this.solvedBtn.FlatAppearance.BorderSize = 0;
            this.solvedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.solvedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.solvedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solvedBtn.ForeColor = System.Drawing.Color.White;
            this.solvedBtn.Location = new System.Drawing.Point(696, 81);
            this.solvedBtn.Name = "solvedBtn";
            this.solvedBtn.Size = new System.Drawing.Size(76, 27);
            this.solvedBtn.TabIndex = 62;
            this.solvedBtn.Text = "SOLVED";
            this.solvedBtn.UseVisualStyleBackColor = false;
            this.solvedBtn.Visible = false;
            this.solvedBtn.Click += new System.EventHandler(this.solvedBtn_Click);
            // 
            // problemTb
            // 
            this.problemTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.problemTb.Enabled = false;
            this.problemTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.problemTb.Location = new System.Drawing.Point(183, 78);
            this.problemTb.Multiline = true;
            this.problemTb.Name = "problemTb";
            this.problemTb.Size = new System.Drawing.Size(495, 89);
            this.problemTb.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "PROBLEM STATEMENT:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 60;
            this.label1.Text = "REPORTS";
            // 
            // addStudentLink
            // 
            this.addStudentLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudentLink.AutoSize = true;
            this.addStudentLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStudentLink.Location = new System.Drawing.Point(807, 146);
            this.addStudentLink.Name = "addStudentLink";
            this.addStudentLink.Size = new System.Drawing.Size(119, 21);
            this.addStudentLink.TabIndex = 55;
            this.addStudentLink.TabStop = true;
            this.addStudentLink.Text = "MAKE REPORT";
            this.addStudentLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addStudentLink_LinkClicked);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(12, 68);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(914, 2);
            this.panel12.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 2);
            this.panel2.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 2);
            this.panel1.TabIndex = 58;
            // 
            // roomDV
            // 
            this.roomDV.AllowUserToAddRows = false;
            this.roomDV.AllowUserToDeleteRows = false;
            this.roomDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomDV.BackgroundColor = System.Drawing.Color.White;
            this.roomDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.report_id,
            this.problem,
            this.room,
            this.reporter,
            this.title,
            this.status,
            this.date,
            this.view,
            this.delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDV.DefaultCellStyle = dataGridViewCellStyle4;
            this.roomDV.EnableHeadersVisualStyles = false;
            this.roomDV.Location = new System.Drawing.Point(12, 173);
            this.roomDV.Name = "roomDV";
            this.roomDV.ReadOnly = true;
            this.roomDV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomDV.RowHeadersVisible = false;
            this.roomDV.RowTemplate.Height = 30;
            this.roomDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDV.Size = new System.Drawing.Size(914, 404);
            this.roomDV.TabIndex = 56;
            this.roomDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDV_CellContentClick);
            this.roomDV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.roomDV_CellFormatting);
            // 
            // report_id
            // 
            this.report_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.report_id.DataPropertyName = "report_id";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 8);
            this.report_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.report_id.HeaderText = "REPORT ID";
            this.report_id.Name = "report_id";
            this.report_id.ReadOnly = true;
            this.report_id.Width = 114;
            // 
            // problem
            // 
            this.problem.DataPropertyName = "problem";
            this.problem.HeaderText = "prob";
            this.problem.Name = "problem";
            this.problem.ReadOnly = true;
            this.problem.Visible = false;
            // 
            // room
            // 
            this.room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.room.DataPropertyName = "room";
            this.room.HeaderText = "ROOM";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            this.room.Width = 82;
            // 
            // reporter
            // 
            this.reporter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reporter.DataPropertyName = "reporter";
            this.reporter.HeaderText = "REPORTER";
            this.reporter.Name = "reporter";
            this.reporter.ReadOnly = true;
            this.reporter.Width = 112;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "ISSUE TITLE";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.status.DefaultCellStyle = dataGridViewCellStyle3;
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.Width = 90;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "DATE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 73;
            // 
            // view
            // 
            this.view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.view.HeaderText = "";
            this.view.Image = global::HALKEY.Properties.Resources.view;
            this.view.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Width = 5;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = global::HALKEY.Properties.Resources.delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 5;
            // 
            // ReportModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(938, 613);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportModule";
            this.Text = "ReportModule";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel bgPanel;
        private Label label1;
        private LinkLabel addStudentLink;
        private Panel panel12;
        private Panel panel2;
        private Panel panel1;
        private DataGridView roomDV;
        private TextBox problemTb;
        private Label label2;
        private Button solvedBtn;
        private DataGridViewTextBoxColumn report_id;
        private DataGridViewTextBoxColumn problem;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn reporter;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn date;
        private DataGridViewImageColumn view;
        private DataGridViewImageColumn delete;
    }
}