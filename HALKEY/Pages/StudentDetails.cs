using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HALKEY.Pages
{
    public partial class StudentDetails : Form
    {
        private string student_id = StudentModule.id;
        SqlConnection conn = new SqlConnection(DbConn.connString);

        public StudentDetails()
        {
            InitializeComponent();
            fillFields();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void fillFields()
        {
            try
            {
                conn.Open();
                string query = "SELECT *, passport_pic,FORMAT(date_registered, 'dd-MMM-yyyy') AS date FROM Student WHERE student_id='"+student_id+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idLbl.Text = reader["student_id"].ToString();
                    fnameLbl.Text = reader["fname"].ToString();
                    mnameLbl.Text = reader["mname"].ToString();
                    lnameLbl.Text = reader["lname"].ToString();
                    genderLbl.Text = reader["gender"].ToString();
                    contactLbl.Text = reader["contact"].ToString();
                    emergLbl.Text = reader["emergency_contact"].ToString();
                    categoryLbl.Text = reader["category"].ToString();
                    programLbl.Text = reader["programme"].ToString();
                    levelLbl.Text = reader["level"].ToString();
                    roomLbl.Text = reader["room"].ToString();
                    dateLbl.Text = reader["date"].ToString();
                    if (!DBNull.Value.Equals(reader["passport_pic"]))
                    {
                        byte[] imgByte = (byte[])reader["passport_pic"];
                        MemoryStream ms = new MemoryStream(imgByte);
                        passportPic.Image = new Bitmap(ms);
                    }

                }
                reader.Close();

                conn.Close();

            }
            catch { }
        }
    }
}
