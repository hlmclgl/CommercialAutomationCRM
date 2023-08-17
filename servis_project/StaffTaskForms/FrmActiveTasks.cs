﻿using DevExpress.XtraEditors;
using servis_project.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servis_project.StaffTaskForms
{
    public partial class FrmActiveTasks : Form
    {
        public FrmActiveTasks()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void FrmActiveTasks_Load(object sender, EventArgs e)
        {
            var values = (from x in db.TblTasks
                          select new
                          {
                              x.ID,
                              TaskTaker = x.TblStaffs1.FirstName ,
                              x.Description,
                              x.Status,
                              x.Date
                          }).Where(x => x.TaskTaker == "Ahmet Hilmi" && x.Status == true).ToList();
            gridControl1.DataSource = values;
            //gridView1.Columns["TaskTaker"].Visible = false;
            gridView1.Columns["Status"].Visible = false;

            int taskcount = gridView1.RowCount;

            if (taskcount == 0)
            {
                XtraMessageBox.Show("Aktif Bir Görev Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
