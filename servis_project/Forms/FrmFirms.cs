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
    public partial class FrmFirms : Form
    {
        public FrmFirms()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        void List()
        {
            var values = (from x in db.TblFirms
                          select new
                          {
                              x.ID,
                              x.Name,
                              x.Officer,
                              x.Sector,
                              x.Mail,
                              x.Phone,
                              x.City,
                              x.Town,
                              x.Address
                          }).ToList();
            gridControl1.DataSource = values;
        }
        private void FrmFirms_Load(object sender, EventArgs e)
        {

            List();
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblFirms f = new TblFirms();
            f.Name = txtName.Text;
            f.Officer = txtOfficer.Text;
            f.Sector = txtSector.Text;
            f.Mail = txtMail.Text;
            f.Phone = txtPhone.Text;
            f.City = txtCity.Text;
            f.Town = txtTown.Text;
            f.Address = memoEdit1.Text;
            db.TblFirms.Add(f);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni firma başarılı bir şekilde eklendi.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtID.Text);
            var value = db.TblFirms.Find(x);
            db.TblFirms.Remove(value);
            db.SaveChanges();
            XtraMessageBox.Show("Firma başarılı bir şekilde silindi",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var value = db.TblFirms.Find(x);
            value.Name = txtName.Text;
            value.Officer = txtOfficer.Text;
            value.Sector = txtSector.Text;
            value.Mail = txtMail.Text;
            value.Phone = txtPhone.Text;
            value.City = txtCity.Text;
            value.Town = txtTown.Text;
            value.Address = memoEdit1.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Firma başarılı bir şekilde güncellendi",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            List();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtOfficer.Text = gridView1.GetFocusedRowCellValue("Officer").ToString();
            txtSector.Text = gridView1.GetFocusedRowCellValue("Sector").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtPhone.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            txtCity.Text = gridView1.GetFocusedRowCellValue("City").ToString();
            txtTown.Text = gridView1.GetFocusedRowCellValue("Town").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("Address").ToString();
        }
    }
}
