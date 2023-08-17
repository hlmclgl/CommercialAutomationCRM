namespace servis_project.StaffTaskForms
{
    partial class FrmStaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnActiveCalls = new DevExpress.XtraBars.BarButtonItem();
            this.btnPassiveTasks = new DevExpress.XtraBars.BarButtonItem();
            this.btnSupportRequest = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(46);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnActiveCalls,
            this.btnPassiveTasks,
            this.btnSupportRequest});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 515;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(982, 183);
            // 
            // btnActiveCalls
            // 
            this.btnActiveCalls.Caption = "Aktif Görevler";
            this.btnActiveCalls.Id = 1;
            this.btnActiveCalls.ImageOptions.Image = global::servis_project.Properties.Resources.edittask_16x162;
            this.btnActiveCalls.ImageOptions.LargeImage = global::servis_project.Properties.Resources.edittask_32x322;
            this.btnActiveCalls.Name = "btnActiveCalls";
            this.btnActiveCalls.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActiveCalls_ItemClick);
            // 
            // btnPassiveTasks
            // 
            this.btnPassiveTasks.Caption = "Tamamlanmış Görevler";
            this.btnPassiveTasks.Id = 2;
            this.btnPassiveTasks.ImageOptions.Image = global::servis_project.Properties.Resources.apply_16x162;
            this.btnPassiveTasks.ImageOptions.LargeImage = global::servis_project.Properties.Resources.apply_32x323;
            this.btnPassiveTasks.Name = "btnPassiveTasks";
            this.btnPassiveTasks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPassiveTasks_ItemClick);
            // 
            // btnSupportRequest
            // 
            this.btnSupportRequest.Caption = "Destek Talepleri";
            this.btnSupportRequest.Id = 4;
            this.btnSupportRequest.ImageOptions.Image = global::servis_project.Properties.Resources.support_16x161;
            this.btnSupportRequest.ImageOptions.LargeImage = global::servis_project.Properties.Resources.support_32x321;
            this.btnSupportRequest.Name = "btnSupportRequest";
            this.btnSupportRequest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSupportRequest_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnActiveCalls);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPassiveTasks);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSupportRequest);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmStaffForm";
            this.Text = "FrmStaffForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnActiveCalls;
        private DevExpress.XtraBars.BarButtonItem btnPassiveTasks;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnSupportRequest;
    }
}