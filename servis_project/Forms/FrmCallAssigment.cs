﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servis_project.Forms
{
    public partial class FrmCallAssigment : Form
    {
        public FrmCallAssigment()
        {
            InitializeComponent();
        }

        public int id;

        private void FrmCallAssigment_Load(object sender, EventArgs e)
        {
            txtCallid.Text = id.ToString();
        }
    }
}
