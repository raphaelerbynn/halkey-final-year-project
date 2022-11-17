﻿namespace HALKEY.Pages
{
    partial class Home
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.rptBtn = new System.Windows.Forms.Button();
            this.rmsBtn = new System.Windows.Forms.Button();
            this.wkrBtn = new System.Windows.Forms.Button();
            this.dashBtn = new System.Windows.Forms.Button();
            this.stntBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.maxBtn = new System.Windows.Forms.PictureBox();
            this.minBtn = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.rptBtn);
            this.menuPanel.Controls.Add(this.rmsBtn);
            this.menuPanel.Controls.Add(this.wkrBtn);
            this.menuPanel.Controls.Add(this.dashBtn);
            this.menuPanel.Controls.Add(this.stntBtn);
            this.menuPanel.Controls.Add(this.closeBtn);
            this.menuPanel.Controls.Add(this.maxBtn);
            this.menuPanel.Controls.Add(this.minBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(938, 86);
            this.menuPanel.TabIndex = 0;
            // 
            // rptBtn
            // 
            this.rptBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rptBtn.FlatAppearance.BorderSize = 0;
            this.rptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rptBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rptBtn.ForeColor = System.Drawing.Color.White;
            this.rptBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.rptBtn.Location = new System.Drawing.Point(737, 34);
            this.rptBtn.Name = "rptBtn";
            this.rptBtn.Size = new System.Drawing.Size(170, 53);
            this.rptBtn.TabIndex = 2;
            this.rptBtn.Text = "REPORTs";
            this.rptBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rptBtn.UseVisualStyleBackColor = true;
            this.rptBtn.Click += new System.EventHandler(this.rptBtn_Click);
            // 
            // rmsBtn
            // 
            this.rmsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rmsBtn.FlatAppearance.BorderSize = 0;
            this.rmsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rmsBtn.ForeColor = System.Drawing.Color.White;
            this.rmsBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.rmsBtn.Location = new System.Drawing.Point(561, 34);
            this.rmsBtn.Name = "rmsBtn";
            this.rmsBtn.Size = new System.Drawing.Size(170, 53);
            this.rmsBtn.TabIndex = 2;
            this.rmsBtn.Text = "ROOMS";
            this.rmsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rmsBtn.UseVisualStyleBackColor = true;
            this.rmsBtn.Click += new System.EventHandler(this.rmsBtn_Click);
            // 
            // wkrBtn
            // 
            this.wkrBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wkrBtn.FlatAppearance.BorderSize = 0;
            this.wkrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wkrBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wkrBtn.ForeColor = System.Drawing.Color.White;
            this.wkrBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.wkrBtn.Location = new System.Drawing.Point(385, 34);
            this.wkrBtn.Name = "wkrBtn";
            this.wkrBtn.Size = new System.Drawing.Size(170, 53);
            this.wkrBtn.TabIndex = 2;
            this.wkrBtn.Text = "WORKERS";
            this.wkrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.wkrBtn.UseVisualStyleBackColor = true;
            this.wkrBtn.Click += new System.EventHandler(this.wkrBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dashBtn.FlatAppearance.BorderSize = 0;
            this.dashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashBtn.ForeColor = System.Drawing.Color.DimGray;
            this.dashBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.dashBtn.Location = new System.Drawing.Point(33, 34);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(170, 53);
            this.dashBtn.TabIndex = 2;
            this.dashBtn.Text = "DASHBOARD";
            this.dashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dashBtn.UseVisualStyleBackColor = true;
            this.dashBtn.Click += new System.EventHandler(this.dashBtn_Click);
            // 
            // stntBtn
            // 
            this.stntBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stntBtn.FlatAppearance.BorderSize = 0;
            this.stntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stntBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stntBtn.ForeColor = System.Drawing.Color.White;
            this.stntBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.stntBtn.Location = new System.Drawing.Point(209, 34);
            this.stntBtn.Name = "stntBtn";
            this.stntBtn.Size = new System.Drawing.Size(170, 53);
            this.stntBtn.TabIndex = 2;
            this.stntBtn.Text = "STUDENTS";
            this.stntBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stntBtn.UseVisualStyleBackColor = true;
            this.stntBtn.Click += new System.EventHandler(this.stntBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.closeBtn.Location = new System.Drawing.Point(913, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.maxBtn.Location = new System.Drawing.Point(888, 3);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(21, 24);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 1;
            this.maxBtn.TabStop = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Image = global::HALKEY.Properties.Resources.controls;
            this.minBtn.Location = new System.Drawing.Point(864, 3);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(21, 24);
            this.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBtn.TabIndex = 1;
            this.minBtn.TabStop = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 86);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(938, 613);
            this.bodyPanel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 699);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel bodyPanel;
        private Button rptBtn;
        private Button rmsBtn;
        private Button wkrBtn;
        private Button dashBtn;
        private Button stntBtn;
        private PictureBox closeBtn;
        private PictureBox maxBtn;
        private PictureBox minBtn;
    }
}