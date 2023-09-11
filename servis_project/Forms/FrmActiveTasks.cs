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
    public partial class FrmActiveTasks : Form
    {
        public FrmActiveTasks()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void FrmActiveTasks_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblTasks
                                       select new
                                       {
                                           x.ID,
                                           x.Description,
                                           x.Date
                                       }).ToList();
        }
    }
}
