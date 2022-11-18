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
    public partial class Dashboard : Form
    {

        SqlConnection conn = new SqlConnection(DbConn.connString);
        List<string> issues = new List<string>();

        public Dashboard()
        {
            InitializeComponent();
            getProfileDetails();
            totalUpdate();
            unresovedReport();
            System.Diagnostics.Debug.WriteLine(string.Join(",", issues));
        }
                

        private void getProfileDetails()
        {
            try
            {
                conn.Open();
                string query = "SELECT username, image FROM Porter WHERE username='" + Login.username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usernameTb.Text = reader["username"].ToString();

                    if (!DBNull.Value.Equals(reader["image"]))
                    {
                        byte[] imgByte = (byte[])reader["image"];
                        MemoryStream ms = new MemoryStream(imgByte);
                        profilePic.Image = new Bitmap(ms);
                    }
                }
                reader.Close();

                conn.Close();

            }
            catch { }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Home home = (Home)Application.OpenForms["Home"];
                home.Close();

                Login login = (Login)Application.OpenForms["Login"];
                login.Show();
            }
        }

        private void unresovedReport()
        {
            for(int i=0; i < 7; i++)
            {
                foreach(Control c in reportPanel.Controls)
                {
                    if(c is Label && c.Tag != null)
                    {
                        if(int.Parse(c.Tag?.ToString()) == i)
                        {
                            c.Text = "------";
                        }

                        if(i < issues.Count)
                        {
                            c.Text = issues[i];
                        }
                    }
                }
            }
        }

        private void totalUpdate()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student", conn);
                studentLbl.Text = cmd.ExecuteScalar().ToString();
                
                cmd = new SqlCommand("SELECT COUNT(*) FROM Room", conn);
                roomLbl.Text = cmd.ExecuteScalar().ToString();
                
                cmd = new SqlCommand("SELECT COUNT(*) FROM Report", conn);
                reportLbl.Text = cmd.ExecuteScalar().ToString();
                //System.Diagnostics.Debug.WriteLine("Printing the i=" + totalstundet);

                cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE level='100'", conn);
                l100Lbl.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE level='200'", conn);
                l200Lbl.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE level='300'", conn);
                l300Lbl.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE level='400'", conn);
                l400Lbl.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE level='500'", conn);
                l500Lbl.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE level='600'", conn);
                l600Lbl.Text = cmd.ExecuteScalar().ToString();
                
                cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE category='POSTGRADUATE'", conn);
                postgradLbl.Text = cmd.ExecuteScalar().ToString();
                
                cmd = new SqlCommand("SELECT problem FROM Report WHERE status='UNSOLVED' LIMIT 6", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    issues.Add(reader["problem"].ToString());
                }
                reader.Close();
                conn.Close();   
            }catch {
                conn.Close();
            }

        }
    }
}
