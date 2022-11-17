﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HALKEY.Pages
{
    public partial class AddReport : Form
    {
        SqlConnection conn = new SqlConnection(DbConn.connString);
        public AddReport()
        {
            InitializeComponent();

        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void clearFeild()
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            try
            {

                //System.Diagnostics.Debug.WriteLine(Encoding.Default.GetString(imgByte));
                conn.Open();
                string query = "INSERT INTO Report (title, problem, room, reporter, status, date) " +
                    "VALUES('" + issueTb.Text + "', '" + problemTb.Text + "', '" + roomTb.Text + "', '" + membersCb.Text + "', 'UNSOLVED', '" + DateTime.Now + "')";

                DialogResult result = MessageBox.Show("Do you want to save this report?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Report saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFeild();
                }
                conn.Close();

            }
            catch (SqlException ex)
            {

                conn.Close();

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}