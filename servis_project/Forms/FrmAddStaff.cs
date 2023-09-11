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
    public partial class FrmAddStaff : Form
    {
        public FrmAddStaff()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddStaff_Load(object sender, EventArgs e)
        {
            var departments = (from x in db.TblDepartments
                               select new
                               {
                                   x.ID,
                                   Departman = x.Name
                               }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Departman";
            lookUpEdit1.Properties.DataSource = departments;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblStaffs staffs = new TblStaffs();
            staffs.Status = true;
            staffs.FirstName = txtFirstName.Text;
            staffs.LastName = txtLastName.Text;
            staffs.Roles = "A";
            staffs.Image = "test";
            staffs.Mail = txtMail.Text;
            staffs.Phone = txtPhone.Text;
            staffs.Department = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblStaffs.Add(staffs);
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        ///44-45
    }
}
