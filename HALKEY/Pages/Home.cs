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
    public partial class Home : Form
    {
        OpenNewPage openNewPage = new OpenNewPage();

        public Home()
        {
            InitializeComponent();
            menuPanel.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            
            bodyPanel.BackColor = Color.AliceBlue;
            firstOpen();

        }

        private void firstOpen()
        {
            dashBtn.BackColor = Color.AliceBlue;
            dashBtn.ForeColor = Color.DimGray;
            openNewPage.OpenChildForm(new Dashboard(), bodyPanel);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close the application?";
            MessageBoxButtons action = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", action);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            stntBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            wkrBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rptBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rmsBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);

            if (stntBtn.ForeColor == Color.DimGray)
            {
                stntBtn.ForeColor = Color.White;
            }
            else if (wkrBtn.ForeColor == Color.DimGray)
            {
                wkrBtn.ForeColor = Color.White;
            }
            else if (rmsBtn.ForeColor == Color.DimGray)
            {
                rmsBtn.ForeColor = Color.White;
            }
            else if (rptBtn.ForeColor == Color.DimGray)
            {
                rptBtn.ForeColor = Color.White;
            }

            firstOpen();
        }

        private void stntBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new StudentModule(), bodyPanel);

            dashBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            stntBtn.BackColor = Color.AliceBlue;
            wkrBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rptBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rmsBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);

            if (dashBtn.ForeColor == Color.DimGray)
            {
                dashBtn.ForeColor = Color.White;
            }
            else if (wkrBtn.ForeColor == Color.DimGray)
            {
                wkrBtn.ForeColor = Color.White;
            }
            else if (rmsBtn.ForeColor == Color.DimGray)
            {
                rmsBtn.ForeColor = Color.White;
            }
            else if (rptBtn.ForeColor == Color.DimGray)
            {
                rptBtn.ForeColor = Color.White;
            }
            stntBtn.ForeColor = Color.DimGray;
        }

        private void wkrBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new WorkersModule(), bodyPanel);

            dashBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            stntBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            wkrBtn.BackColor = Color.AliceBlue;
            rptBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rmsBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);

            if (stntBtn.ForeColor == Color.DimGray)
            {
                stntBtn.ForeColor = Color.White;
            }
            else if (dashBtn.ForeColor == Color.DimGray)
            {
                dashBtn.ForeColor = Color.White;
            }
            else if (rmsBtn.ForeColor == Color.DimGray)
            {
                rmsBtn.ForeColor = Color.White;
            }
            else if (rptBtn.ForeColor == Color.DimGray)
            {
                rptBtn.ForeColor = Color.White;
            }
            wkrBtn.ForeColor = Color.DimGray;
        }

        private void rmsBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new RoomModule(), bodyPanel);

            dashBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            stntBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            wkrBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rptBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rmsBtn.BackColor = Color.AliceBlue;

            if (dashBtn.ForeColor == Color.DimGray)
            {
                dashBtn.ForeColor = Color.White;
            }
            else if (wkrBtn.ForeColor == Color.DimGray)
            {
                wkrBtn.ForeColor = Color.White;
            }
            else if (stntBtn.ForeColor == Color.DimGray)
            {
                stntBtn.ForeColor = Color.White;
            }
            else if (rptBtn.ForeColor == Color.DimGray)
            {
                rptBtn.ForeColor = Color.White;
            }
            rmsBtn.ForeColor = Color.DimGray;
        }

        private void rptBtn_Click(object sender, EventArgs e)
        {
            dashBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            stntBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            wkrBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rptBtn.BackColor = Color.AliceBlue;
            rmsBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);

            if (dashBtn.ForeColor == Color.DimGray)
            {
                dashBtn.ForeColor = Color.White;
            }
            else if (wkrBtn.ForeColor == Color.DimGray)
            {
                wkrBtn.ForeColor = Color.White;
            }
            else if (rmsBtn.ForeColor == Color.DimGray)
            {
                rmsBtn.ForeColor = Color.White;
            }
            else if (stntBtn.ForeColor == Color.DimGray)
            {
                stntBtn.ForeColor = Color.White;
            }
            rptBtn.ForeColor = Color.DimGray;
        }
    }
}
