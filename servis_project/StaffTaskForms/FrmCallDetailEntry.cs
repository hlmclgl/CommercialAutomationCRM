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

namespace servis_project.StaffTaskForms
{
    public partial class FrmCallDetailEntry : Form
    {
        public FrmCallDetailEntry()
        {
            InitializeComponent();
        }

        public int id;
        DbServisEntities db = new DbServisEntities();

        private void FrmCallDetailEntry_Load(object sender, EventArgs e)
        {
            txtCallid.Enabled = false;
            txtCallid.Text = id.ToString();
            string hour, date;
            date = DateTime.Now.ToShortDateString();
            hour = DateTime.Now.ToShortTimeString();
            txtDate.Text = date;
            txtClock.Text = hour;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblCallDetails t = new TblCallDetails();
            t.Call = int.Parse(txtCallid.Text);
            t.Hour = txtClock.Text;
            t.Date = DateTime.Parse(txtDate.Text);
            t.Description = txtDesc.Text;
            db.TblCallDetails.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Talep Detayı Sisteme Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
