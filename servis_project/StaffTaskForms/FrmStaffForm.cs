using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servis_project.StaffTaskForms
{
    public partial class FrmStaffForm : Form
    {
        public FrmStaffForm()
        {
            InitializeComponent();
        }

        StaffTaskForms.FrmActiveTasks frm;
        private void btnActiveCalls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new StaffTaskForms.FrmActiveTasks();
                frm.MdiParent = this;
                frm.mail1 = mail;
                frm.Show();
            }
        }

        StaffTaskForms.FrmPassiveTasks frm1;
        private void btnPassiveTasks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new StaffTaskForms.FrmPassiveTasks();
                frm1.MdiParent = this;
                frm1.mail1 = mail;
                frm1.Show();
            }
        }

        StaffTaskForms.FrmCallList frm2;
        private void btnSupportRequest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new StaffTaskForms.FrmCallList();
                frm2.MdiParent = this;
                frm2.mail1 = mail;
                frm2.Show();
            }
        }

        public string mail;

        private void FrmStaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
