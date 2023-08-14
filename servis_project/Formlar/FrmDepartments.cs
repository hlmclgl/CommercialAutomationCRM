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
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        DbServisEntities db = new DbServisEntities();

        void List()
        {
            
            var values = (from x in db.TblDepartments
                         select new 
                         {
                             x.ID,
                             x.Name
                         }).ToList();
            gridControl1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblDepartments t = new TblDepartments();
            t.Name = txtName.Text;
            db.TblDepartments.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme eklendi.", 
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var value = db.TblDepartments.Find(x);
            db.TblDepartments.Remove(value);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde silindi.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var value = db.TblDepartments.Find(x);
            value.Name = txtName.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde güncellendi.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            List();
        }
    }
}
