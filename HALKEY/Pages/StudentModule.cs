﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HALKEY.Pages
{
    public partial class StudentModule : Form
    {
        public StudentModule()
        {
            InitializeComponent();
        }

        private void addStudentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenNewPage onp = new OpenNewPage();
            onp.OpenChildForm(new AddStudent(), bgPanel);
        }
    }
}
