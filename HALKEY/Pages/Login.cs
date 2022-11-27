using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HALKEY
{
    public partial class Login : Form
    {
        public static string username;
        public Login()
        {
            InitializeComponent();
            bgPanel.BackColor = ColorTranslator.FromHtml(Colors.bgLight);
            loginBtn.BackColor = ColorTranslator.FromHtml(Colors.buttonDark);

            //MessageBox.Show(Dns.GetHostName());
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            if(validateCredentials(usernameTb.Text, passwordTb.Text) == true)
            {
                usernameTb.Text = null;
                passwordTb.Text = null;

                Loading loading = (Loading)Application.OpenForms["Loading"];
                loading.Hide();
                Pages.Home home = new Pages.Home();
                home.Show();
            }
            else
            {
                incLbl.Visible = true;
                passwordTb.BackColor = Color.IndianRed;
                usernameTb.BackColor = Color.IndianRed;
            }
        }

        private bool validateCredentials(string usrname, string pwd)
        {
            bool value = false;
            SqlConnection conn = new SqlConnection(DbConn.connString);

            try
            {
                conn.Open();
                string query = "SELECT username, password FROM Porter";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((usrname.Equals(reader["username"].ToString()) && pwd.Equals(reader["password"].ToString())))
                    {
                        value = true;
                        username = usernameTb.Text;
                    }
                }
                reader.Close();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Put database in path: " + Directory.GetCurrentDirectory());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return value;
        }

        private void createAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenNewPage onp = new OpenNewPage();
            onp.OpenChildForm(new Pages.CreateAccount(), bgPanel);
        }

      
    }
}
