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
    public partial class FrmActiveCalls : Form
    {
        public FrmActiveCalls()
        {
            InitializeComponent();
        }



        private void FrmActiveCalls_Load(object sender, EventArgs e)
        {
            DbServisEntities db = new DbServisEntities();

            var values = (from x in db.TblCalls
                          select new
                          {
                              x.ID,
                              x.TblFirms.Name,
                              x.TblFirms.Phone,
                              x.Issue,
                              x.Description,
                              x.Status,
                              x.Date
                          }).Where(y => y.Status == true).ToList();
            gridControl1.DataSource = values;
        }
    }
}
