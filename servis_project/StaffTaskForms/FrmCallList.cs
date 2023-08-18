using DevExpress.XtraEditors;
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
        public string mail1;

        private void FrmCallList_Load(object sender, EventArgs e)
        {
            var staffid = db.TblStaffs.Where(x => x.Mail == mail1).Select(y => y.ID).FirstOrDefault();


            gridControl1.DataSource = (from x in db.TblCalls
                                       select new
                                       {
                                           x.ID,
                                           x.TblFirms.Name,
                                           x.TblFirms.Phone,
                                           x.TblFirms.Mail,
                                           x.Issue,
                                           x.Description,
                                           x.Status,
                                           x.CallStaff
                                       }).Where(y => y.Status == true && 
                                       y.CallStaff == staffid).ToList();
            gridView1.Columns["Status"].Visible = false;
            gridView1.Columns["CallStaff"].Visible = false;


            int taskcount = gridView1.RowCount;

            if (taskcount == 0)
            {
                XtraMessageBox.Show("Adınıza Tanımlanmış Bir Destek Talebi Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCallDetailEntry fr = new FrmCallDetailEntry();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
