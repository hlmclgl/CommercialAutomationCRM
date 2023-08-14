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
using System.Data.Entity;

namespace servis_project.Formlar
{
    public partial class FrmTaskDetail : Form
    {
        public FrmTaskDetail()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void FrmTaskDetail_Load(object sender, EventArgs e)
        {
            db.TblTaskDetails.Load();
            bindingSource1.DataSource = db.TblTaskDetails.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteTaskDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
