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

namespace servis_project.Formlar
{
    public partial class FrmStaffStatistics : Form
    {
        public FrmStaffStatistics()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void FrmStaffStatistics_Load(object sender, EventArgs e)
        {
            lblTotalDepartment.Text = db.TblDepartments.Count().ToString();
            lblTotalFirm.Text = db.TblFirms.Count().ToString();
            lblTotalStaff.Text = db.TblStaffs.Count().ToString();
            lblActiveWork.Text = db.TblTasks.Count(x => x.Status == true).ToString();
            lblPassiveWork.Text = db.TblTasks.Count(x => x.Status == false).ToString();
            lblLastTask.Text = db.TblTasks.OrderByDescending(x => x.ID).Select(x => x.Description).FirstOrDefault();
            lblLastTaskDate.Text = db.TblTasks.OrderByDescending(x => x.ID).Select(x => x.Date).FirstOrDefault().ToString();
            lblCityCount.Text = db.TblFirms.Select(x => x.City).Distinct().Count().ToString();
            lblSectorCount.Text = db.TblFirms.Select(x=>x.Sector).Distinct().Distinct().Count().ToString();
            DateTime today = DateTime.Today;
            lblOpenedTasksToday.Text = db.TblTasks.Count(x=>x.Date==today).ToString();
            var d1 = db.TblTasks.GroupBy(x => x.TaskTaker).OrderByDescending(z => z.Count
            ()).Select(y => y.Key).FirstOrDefault();
            lblStaffoftheMonth.Text = db.TblStaffs.Where(x => x.ID == d1).Select(y => y.FirstName + "" + y.LastName).FirstOrDefault().ToString();
            lblMonthoftheDepartment.Text = db.TblDepartments.Where(x => x.ID == db.TblStaffs.Where(t=>t.ID == d1).Select(z=>z.Department).FirstOrDefault()).Select(y => y.Name).FirstOrDefault().ToString();
        }

        
    }
}
