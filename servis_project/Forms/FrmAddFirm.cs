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
    public partial class FrmAddFirm : Form
    {
        public FrmAddFirm()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblFirms f = new TblFirms();
            f.Name = txtName.Text;
            f.Officer = txtOfficer.Text;
            f.Sector = txtSector.Text;
            f.Mail = txtMail.Text;
            f.Image = "test";
            f.Phone = txtPhone.Text;
            f.City = txtCity.Text;
            f.Town = txtTown.Text;
            f.Address = memoEdit1.Text;
            db.TblFirms.Add(f);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni firma başarılı bir şekilde eklendi.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
