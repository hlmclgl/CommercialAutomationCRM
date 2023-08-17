using servis_project.Entity;
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
    public partial class FrmCallList : Form
    {
        public FrmCallList()
        {
            InitializeComponent();
        }

        DbServisEntities db = new DbServisEntities();

        private void FrmCallList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblCalls
                                       select new
                                       {
                                           x.ID,
                                           x.TblFirms.Name,
                                           x.TblFirms.Phone,
                                           x.TblFirms.Mail,
                                           x.Issue,
                                           x.Description,
                                           x.Status
                                       }).Where(y => y.Status == true).ToList();
            gridView1.Columns["Status"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCallDetailEntry fr = new FrmCallDetailEntry();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
