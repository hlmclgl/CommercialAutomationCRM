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
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblTasks select new
            {
                
                x.Description,
                x.Date
            }).ToList();

            lblActiveTask.Text = db.TblTasks.Where(x => x.Status == true).Count().ToString();
            lblPassiveTask.Text = db.TblTasks.Where(x => x.Status == false).Count().ToString();
            lblTotalDepartment.Text = db.TblDepartments.Count().ToString();

            chartControl1.Series["Görev Durumları"].Points.AddPoint("Aktif Görevler", int.Parse(lblActiveTask.Text));
            chartControl1.Series["Görev Durumları"].Points.AddPoint("Pasif Görevler", int.Parse(lblPassiveTask.Text));



        }

        
    }
}
