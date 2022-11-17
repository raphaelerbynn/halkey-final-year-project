using System;
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
    public partial class ReportModule : Form
    {
        string query;
        string id;
        OpenNewPage onp = new OpenNewPage();
        SqlConnection conn = new SqlConnection(DbConn.connString);
        public ReportModule()
        {
            InitializeComponent();
            query = "SELECT report_id, room, reporter, title, status, problem, FORMAT(date, 'dd-MMM-yy hh:mm tt') AS date FROM Report";
            DbConn.fillTable(query, roomDV, conn);
            columnOrder();
        }

        private void columnOrder()
        {
            roomDV.AutoGenerateColumns = false;
            roomDV.Columns["report_id"].DisplayIndex = 0;
            roomDV.Columns["room"].DisplayIndex = 1;
            roomDV.Columns["reporter"].DisplayIndex = 2;
            roomDV.Columns["title"].DisplayIndex = 3;
            roomDV.Columns["status"].DisplayIndex = 4;
            roomDV.Columns["date"].DisplayIndex = 5;
            roomDV.Columns["delete"].DisplayIndex = 6;

            

        }

        private void addStudentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            onp.OpenChildForm(new AddReport(), bgPanel);
        }

        private void roomDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = roomDV.Rows[e.RowIndex];
            id = row.Cells["report_id"].Value.ToString();

            if (roomDV.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
            {
                string message = "Do you want to delete report " + id + "?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Report WHERE report_id='" + id + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    roomDV.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Report deleted from system");

                }
            }

            if (roomDV.Columns[e.ColumnIndex].Name == "view" && e.RowIndex >= 0)
            {
                solvedBtn.Visible = true;
                if (row.Cells["status"].Value.ToString() == "SOLVED")
                {
                    solvedBtn.Enabled = false;
                }
                else
                {
                    solvedBtn.Enabled = true;
                }
                problemTb.Text = row.Cells["problem"].Value.ToString();

            }
        }

        private void roomDV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string state = e.Value.ToString();
                System.Diagnostics.Debug.WriteLine("Printing the i=" + state);
                if (state == "UNSOLVED")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = Color.IndianRed;
                }
                else if (state == "SOLVED")
                {
                    e.CellStyle.BackColor = Color.Lime;
                    e.CellStyle.SelectionForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = Color.ForestGreen;
                }
            }
        }

        private void solvedBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //System.Diagnostics.Debug.WriteLine(Encoding.Default.GetString(imgByte));
                conn.Open();
                string query = "UPDATE Report SET status = 'SOLVED' WHERE report_id='"+id+"'";

                DialogResult result = MessageBox.Show("Do you want to tick this issue as solved?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Report ticked successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    query = "SELECT report_id, room, reporter, title, status, problem, FORMAT(date, 'dd-MMM-yy hh:mm tt') AS date FROM Report";
                    DbConn.fillTable(query, roomDV, conn);
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
