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

namespace servis_project.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffTaskForms.FrmStaffForm frm = new StaffTaskForms.FrmStaffForm();
            frm.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var value = db.TblAdmin.Where(x=>x.User == txtMail.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (value != null)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
                XtraMessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var value = db.TblStaffs.Where(x => x.Mail == txtMail.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (value != null)
            {
                StaffTaskForms.FrmStaffForm frm = new StaffTaskForms.FrmStaffForm();
                frm.mail = txtMail.Text;
                frm.Show();
                this.Hide();
                XtraMessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}
