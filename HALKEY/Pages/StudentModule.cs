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
    public partial class StudentModule : Form
    {
        public static string id;
        OpenNewPage onp = new OpenNewPage();
        SqlConnection conn = new SqlConnection(DbConn.connString);

        public StudentModule()
        {
            InitializeComponent();
            string query = "SELECT student_id, level, room, category, fname+' '+mname+' '+lname AS name FROM Student";
            fillTable(query);
            columnOrder();
        }

        private void columnOrder()
        {
            studentDV.AutoGenerateColumns = false;
            studentDV.Columns["stnt_id"].DisplayIndex = 0;
            studentDV.Columns["stnt_name"].DisplayIndex = 1;
            studentDV.Columns["stnt_level"].DisplayIndex = 2;
            studentDV.Columns["stnt_room"].DisplayIndex = 3;
            studentDV.Columns["view"].DisplayIndex = 4;
            studentDV.Columns["update"].DisplayIndex = 5;
            studentDV.Columns["delete"].DisplayIndex = 6;
        }

        private void addStudentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            onp.OpenChildForm(new AddStudent(), bgPanel);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", searchTb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Again");
                Console.WriteLine(ex.Message);
            }
        }

        private void fillTable(string query)
        {
            try
            {
                
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
                studentDV.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("level LIKE '%{0}%'", "100");
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("level LIKE '%{0}%'", "200");
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("level LIKE '%{0}%'", "300");
        }

        private void btn400_Click(object sender, EventArgs e)
        {
            (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("level LIKE '%{0}%'", "400");

        }

        private void btn500_Click(object sender, EventArgs e)
        {
            (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("level LIKE '%{0}%'", "500");
        }

        private void btn600_Click(object sender, EventArgs e)
        {
            (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("level LIKE '%{0}%'", "600");
        }

        private void btnPostG_Click(object sender, EventArgs e)
        {
            (studentDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("category LIKE '%{0}%'", "POST");
        }

        private void studentDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = studentDV.Rows[e.RowIndex];
                id = row.Cells["stnt_id"].Value.ToString();

                if (studentDV.Columns[e.ColumnIndex].Name == "view" && e.RowIndex >= 0)
                {
                    onp.OpenChildForm(new StudentDetails(), bgPanel);
                }

                if (studentDV.Columns[e.ColumnIndex].Name == "update" && e.RowIndex >= 0)
                {
                    onp.OpenChildForm(new UpdateStudent(), bgPanel);
                }

                if (studentDV.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete this student?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Student WHERE student_id='" + id + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        studentDV.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Student deleted from system");

                    }
                }
            }
            catch { }
        }
    }
}
