﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.TsarevDI.Sprint7.Project.V4
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }

        private void FormGuide_Load(object sender, EventArgs e)
        {

        }

        private void programGuide_TDI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
