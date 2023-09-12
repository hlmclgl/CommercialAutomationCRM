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
    public partial class FrmAccount : Form
    {
        DbServisEntities db = new DbServisEntities();
        public FrmAccount()
        {
            InitializeComponent();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            XtraMessageBox.Show("Hesap bilgileri başarılı bir şekilde güncellendi",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Hide();
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
