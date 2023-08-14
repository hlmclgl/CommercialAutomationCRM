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

        

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
