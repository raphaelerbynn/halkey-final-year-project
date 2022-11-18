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
    public partial class CreateAccount : Form
    {
        private string sys_key = "halkey2022";
        private byte[] imgByte = null; 

        public CreateAccount()
        {
            InitializeComponent();
            bgPanel.BackColor = ColorTranslator.FromHtml(Colors.bgLight);
            singUpBtn.BackColor = ColorTranslator.FromHtml(Colors.buttonDark);
            genderCb.SelectedIndex = 0;
            //getImage();
        }

        private void singUpBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(DbConn.connString);
            if (!String.IsNullOrEmpty(nameTb.Text) | !String.IsNullOrEmpty(usernameTb.Text))
            {
                if (pwdTb.Text.Equals(cPwdTb.Text))
                {
                    if (sysTb.Text.Equals(sys_key))
                    {
                        try
                        {
                            if(imgByte == null)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    profilePic.Image.Save(ms, profilePic.Image.RawFormat);
                                    imgByte = ms.ToArray();
                                }
                            }
                            //System.Diagnostics.Debug.WriteLine(Encoding.Default.GetString(imgByte));
                            conn.Open();
                            string query = "INSERT INTO Porter VALUES(@name, @username, @contact, @gender, @password, @image)";
                                
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@name", nameTb.Text);
                            cmd.Parameters.AddWithValue("@username", usernameTb.Text);
                            cmd.Parameters.AddWithValue("@contact", contactTb.Text);
                            cmd.Parameters.AddWithValue("@gender", genderCb.Text);
                            cmd.Parameters.AddWithValue("@password", pwdTb.Text);
                            cmd.Parameters.AddWithValue("@image", imgByte);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        }
                        catch (SqlException ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex.Message);

                            //MessageBox.Show(ex.ToString());
                            MessageBox.Show(Directory.GetCurrentDirectory());

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("System key inccorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            else
            {
                MessageBox.Show("All feilds must be filled");
            }
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private byte[] getImage()
        {
            string sFile;
            OpenFileDialog openFile = new OpenFileDialog();
            byte[] img = null;

            openFile.Filter = "Image Files(*.jpeg; *.jpg; *.png) | *.jpeg; *.jpg; *.png";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                profilePic.Image = System.Drawing.Bitmap.FromFile(openFile.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    profilePic.Image.Save(ms, profilePic.Image.RawFormat);
                    img = ms.ToArray();
                }
            }

            return img;
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpeg; *.jpg; *.png) | *.jpeg; *.jpg; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                profilePic.Image = new Bitmap(openFile.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    profilePic.Image.Save(ms, profilePic.Image.RawFormat);
                    imgByte = ms.ToArray();
                }

            }
        }
    }
}
