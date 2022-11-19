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

        
        private void dashBtn_Click(object sender, EventArgs e)
        {
            stntBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rptBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rmsBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);

            /*this.dashBtn.Image = global::HALKEY.Properties.Resources.dashboard;//
            this.stntBtn.Image = global::HALKEY.Properties.Resources.student_boy;
            this.rmsBtn.Image = global::HALKEY.Properties.Resources.room;
            this.rptBtn.Image = global::HALKEY.Properties.Resources.report1;*/

            if (stntBtn.ForeColor == Color.DimGray)
            {
                stntBtn.ForeColor = Color.White;
                this.stntBtn.Image = global::HALKEY.Properties.Resources.student_boy;
            }
            else if (rmsBtn.ForeColor == Color.DimGray)
            {
                rmsBtn.ForeColor = Color.White;
                this.rmsBtn.Image = global::HALKEY.Properties.Resources.room;
            }
            else if (rptBtn.ForeColor == Color.DimGray)
            {
                rptBtn.ForeColor = Color.White;
                this.rptBtn.Image = global::HALKEY.Properties.Resources.report1;
            }
            this.dashBtn.Image = global::HALKEY.Properties.Resources.dashboard1;
            firstOpen();

        }

        private void stntBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new StudentModule(), bodyPanel);

            dashBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            stntBtn.BackColor = Color.AliceBlue;
            rptBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rmsBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);

            if (dashBtn.ForeColor == Color.DimGray)
            {
                dashBtn.ForeColor = Color.White;
                this.dashBtn.Image = global::HALKEY.Properties.Resources.dashboard;

            }
            else if (rmsBtn.ForeColor == Color.DimGray)
            {
                rmsBtn.ForeColor = Color.White;
                this.rmsBtn.Image = global::HALKEY.Properties.Resources.room;

            }
            else if (rptBtn.ForeColor == Color.DimGray)
            {
                rptBtn.ForeColor = Color.White;
                this.rptBtn.Image = global::HALKEY.Properties.Resources.report1;
            }
            stntBtn.ForeColor = Color.DimGray;
            this.stntBtn.Image = global::HALKEY.Properties.Resources.student_boy1;
        }

        

        private void rmsBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new RoomModule(), bodyPanel);

            dashBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            stntBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rptBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rmsBtn.BackColor = Color.AliceBlue;

            if (dashBtn.ForeColor == Color.DimGray)
            {
                dashBtn.ForeColor = Color.White;
                this.dashBtn.Image = global::HALKEY.Properties.Resources.dashboard;
            }
            else if (stntBtn.ForeColor == Color.DimGray)
            {
                stntBtn.ForeColor = Color.White;
                this.stntBtn.Image = global::HALKEY.Properties.Resources.student_boy;
            }
            else if (rptBtn.ForeColor == Color.DimGray)
            {
                rptBtn.ForeColor = Color.White;
                this.rptBtn.Image = global::HALKEY.Properties.Resources.report1;
            }
            rmsBtn.ForeColor = Color.DimGray;
            this.rmsBtn.Image = global::HALKEY.Properties.Resources.room1;
        }

        private void rptBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new ReportModule(), bodyPanel);

            dashBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            stntBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);
            rptBtn.BackColor = Color.AliceBlue;
            rmsBtn.BackColor = ColorTranslator.FromHtml(Colors.bgDark);

            if (dashBtn.ForeColor == Color.DimGray)
            {
                dashBtn.ForeColor = Color.White;
                this.dashBtn.Image = global::HALKEY.Properties.Resources.dashboard;
            }
            else if (rmsBtn.ForeColor == Color.DimGray)
            {
                rmsBtn.ForeColor = Color.White;
                this.rmsBtn.Image = global::HALKEY.Properties.Resources.room;
            }
            else if (stntBtn.ForeColor == Color.DimGray)
            {
                stntBtn.ForeColor = Color.White;
                this.stntBtn.Image = global::HALKEY.Properties.Resources.student_boy;
            }
            rptBtn.ForeColor = Color.DimGray;
            this.rptBtn.Image = global::HALKEY.Properties.Resources.report;
        }
    }
}
