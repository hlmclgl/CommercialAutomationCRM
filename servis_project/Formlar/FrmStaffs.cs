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

namespace servis_project.Formlar
{
    public partial class FrmStaffs : Form
    {
        public FrmStaffs()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        void List()
        {
            var values = from x in db.TblStaffs
                         select new
                         {
                             x.ID,
                             x.FirstName,
                             x.LastName,
                             Department = x.TblDepartments.Name,
                             x.Mail,
                             x.Phone,
                             x.Image,
                             x.Status
                         };

            gridControl1.DataSource = values.Where(x => x.Status == true).ToList();
        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            List();
            var departmens = (from x in db.TblDepartments
                              select new
                              {
                                  x.ID,
                                  x.Name
                              }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.DataSource = departmens;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblStaffs t = new TblStaffs();
            t.FirstName = txtName.Text;
            t.LastName = txtLastname.Text;
            t.Department = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Mail = txtMail.Text;
            t.Phone = txtPhone.Text;
            t.Image = txtImage.Text;
            db.TblStaffs.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel başarılı bir şekilde eklendi.", 
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtID.Text);
            var value = db.TblStaffs.Find(x);
            value.Status = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde silindi, Silinen personeller " +
                "listesinden tüm silinmiş personel bilgilerine ulaşabilirsiniz...",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue("FirstName").ToString();
            txtLastname.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Department").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtPhone.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            txtImage.Text = gridView1.GetFocusedRowCellValue("Image").ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var value = db.TblStaffs.Find(x);
            value.FirstName = txtName.Text;
            value.LastName = txtLastname.Text;
            value.Department = int.Parse(lookUpEdit1.EditValue.ToString());
            value.Mail = txtMail.Text;
            value.Phone = txtPhone.Text;
            value.Image = txtImage.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde güncellendi",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            List();
        }
    }
}
