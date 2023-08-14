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

namespace servis_project.Forms
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();
        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblTasks
                                       select new
                                       {
                                           x.Description,
                                           GörevAlanPersonel = x.TblStaffs1.FirstName + " " + x.TblStaffs1.LastName,
                                           x.Status
                                       }).Where(y=>y.Status == true).ToList();

            gridView1.Columns["Status"].Visible = false;

            DateTime today = DateTime.Parse( DateTime.Now.ToShortDateString());
            //MessageBox.Show(today.ToString());
            gridControl4.DataSource = (from x in db.TblTaskDetails
                                       select new
                                       {
                                           Görev = x.TblTasks.Description,
                                           x.Description,
                                           x.Date
                                       }).Where(y => y.Date == today).ToList();
        }
    }
}
