using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using servis_project.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace servis_project.Forms
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            var staffs = (from x in db.TblStaffs
                              select new
                              {
                                  x.ID,
                                  Name = x.FirstName + " " + x.LastName
                                  
                              }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.DataSource = staffs;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbServisEntities db = new DbServisEntities();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblTasks tasks = new TblTasks();
            tasks.Description = txtDesc.Text;
            tasks.Status = true;
            tasks.TaskGiver = 9;
            tasks.Date = DateTime.Parse(txtDate.Text);
            tasks.TaskTaker = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblTasks.Add(tasks);
            db.SaveChanges();
            XtraMessageBox.Show("Görev başarılı bir şekilde tanımlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
