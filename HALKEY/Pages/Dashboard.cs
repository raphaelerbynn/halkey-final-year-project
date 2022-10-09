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

        public Dashboard()
        {
            InitializeComponent();
            getProfileDetails();
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
                this.Close();
                Login login = (Login)Application.OpenForms["Login"];
                login.Show();
            }
        }
    }
}
