using DevExpress.XtraEditors;
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

namespace servis_project.Forms
{
    public partial class FrmCallAssigment : Form
    {
        public FrmCallAssigment()
        {
            InitializeComponent();
        }

        public int id;
        DbServisEntities db = new DbServisEntities();

        private void FrmCallAssigment_Load(object sender, EventArgs e)
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

            txtCallid.Text = id.ToString();
            var data = db.TblCalls.Find(id);
            txtDesc.Text = data.Description;
            txtDate.Text = data.Date.ToString();
            txtIssue.Text = data.Issue;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var data = db.TblCalls.Find(id);
            data.Issue = txtIssue.Text;
            data.Description = txtDesc.Text;
            data.Date = Convert.ToDateTime(txtDate.Text);
            data.CallStaff = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Destek talebi ilgili personele iletildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
