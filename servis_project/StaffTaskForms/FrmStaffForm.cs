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

        private void btnCalc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCalculator frmCalculator = new Forms.FrmCalculator();
            frmCalculator.Show();
        }

        Forms.FrmYoutube frm10;
        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new Forms.FrmYoutube();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }

        private void btnCurrency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCurrencyConvertor frmConvertor = new Forms.FrmCurrencyConvertor();
            frmConvertor.Show();
        }

        Forms.FrmMaps frm11;
        private void btnMaps_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new Forms.FrmMaps();
                frm11.MdiParent = this;
                frm11.Show();
            }
        }

        private void btnCalendar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCalendar frmCalendar = new Forms.FrmCalendar();
            frmCalendar.Show();
        }

        private void btnAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmAccount frmAccount = new Forms.FrmAccount();
            frmAccount.Show();
        }

        Forms.FrmDpReport frm12;
        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Forms.FrmDpReport();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }
    }
}
