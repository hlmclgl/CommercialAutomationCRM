using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servis_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Forms.FrmHomePage frm7;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new Forms.FrmHomePage();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }

        Formlar.FrmDepartments frm1;
        private void BtnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new Formlar.FrmDepartments();
                frm1.MdiParent = this;
                frm1.Show();
            }
            
        }

        Formlar.FrmStaffs frm2;
        private void BtnStaffList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.FrmStaffs();
                frm2.MdiParent = this;
                frm2.Show();
            }
            

        }

        Formlar.FrmStaffStatistics frm3;
        private void btnStaffStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmStaffStatistics();
                frm3.MdiParent = this;
                frm3.Show();
            }
            
        }

        Formlar.FrmTaskList frm4;
        private void btnTaskList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmTaskList();
                frm4.MdiParent = this;
                frm4.Show();
            }
            
        }

        
        private void btnNewTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmTask frmTask = new Forms.FrmTask();
            frmTask.Show();
        }

        private void btnTaskDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmTaskDetail frm = new Formlar.FrmTaskDetail();
            frm.Show();
        }

        Forms.FrmHomePage frm5;
        private void btnHomePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Forms.FrmHomePage();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        Forms.FrmActiveCalls frm6;
        private void btnActiveCalls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Forms.FrmActiveCalls();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        private void btnNewDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmAddDepartment frmAddDepartment = new Forms.FrmAddDepartment();
            frmAddDepartment.Show();
        }

        private void btnAddStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmAddStaff frmAddStaff = new Forms.FrmAddStaff();
            frmAddStaff.Show();
        }

        Forms.FrmFirms frm8;
        private void frmList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Forms.FrmFirms();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }

        Forms.FrmPassiveCalls frm9;
        private void btnPassiveCalls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Forms.FrmPassiveCalls();
                frm9.MdiParent = this;
                frm9.Show();
            }
        }

        private void btnActiveTasks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmActiveTasks frmActiveTasks = new Forms.FrmActiveTasks();
            frmActiveTasks.Show();
        }

        private void btnPassiveTasks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmPassiveTasks frmPassiveTasks = new Forms.FrmPassiveTasks();
            frmPassiveTasks.Show();
        }

        private void btnAddFirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmAddFirm frmAddFirm = new Forms.FrmAddFirm();
            frmAddFirm.Show();
        }

        private void btnCalc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCalculator frmCalculator = new Forms.FrmCalculator();
            frmCalculator.Show();
        }

        private void btnCurrency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCurrencyConvertor frmConvertor = new Forms.FrmCurrencyConvertor();
            frmConvertor.Show();
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

        Forms.FrmDpReport frm12;
        private void btnDpReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Forms.FrmDpReport();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        private void btnReportWizard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Forms.FrmDpReport();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        private void btnStfReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Forms.FrmDpReport();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        private void btnFrmReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Forms.FrmDpReport();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        private void btnCallReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Forms.FrmDpReport();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        private void btnAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmAccount frmAccount = new Forms.FrmAccount();
            frmAccount.Show();
        }
    }
}
