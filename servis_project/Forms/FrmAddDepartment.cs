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
    public partial class FrmAddDepartment : Form
    {
        public FrmAddDepartment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DbServisEntities db = new DbServisEntities();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblDepartments departments = new TblDepartments();

            departments.Name = txtDepartmentName.Text;
            db.TblDepartments.Add(departments);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void FrmAddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
