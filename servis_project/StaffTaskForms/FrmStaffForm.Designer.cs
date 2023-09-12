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
            this.btnCalc = new DevExpress.XtraBars.BarButtonItem();
            this.btnYoutube = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCurrency = new DevExpress.XtraBars.BarButtonItem();
            this.btnMaps = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalendar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnSupportRequest,
            this.btnCalc,
            this.btnYoutube,
            this.barButtonItem3,
            this.btnCurrency,
            this.btnMaps,
            this.btnCalendar,
            this.btnAccount,
            this.barButtonItem8,
            this.btnReport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 515;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1482, 183);
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
            // btnCalc
            // 
            this.btnCalc.Caption = "Hesap Makinası";
            this.btnCalc.Id = 5;
            this.btnCalc.ImageOptions.Image = global::servis_project.Properties.Resources.calculatenow_16x16;
            this.btnCalc.ImageOptions.LargeImage = global::servis_project.Properties.Resources.calculatenow_32x32;
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalc_ItemClick);
            // 
            // btnYoutube
            // 
            this.btnYoutube.Caption = "Youtube";
            this.btnYoutube.Id = 6;
            this.btnYoutube.ImageOptions.Image = global::servis_project.Properties.Resources.youtube_16x161;
            this.btnYoutube.ImageOptions.LargeImage = global::servis_project.Properties.Resources.youtube_32x322;
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYoutube_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Haberler";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageOptions.Image = global::servis_project.Properties.Resources.news_16x161;
            this.barButtonItem3.ImageOptions.LargeImage = global::servis_project.Properties.Resources.news_32x321;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnCurrency
            // 
            this.btnCurrency.Caption = "Kurlar";
            this.btnCurrency.Id = 8;
            this.btnCurrency.ImageOptions.Image = global::servis_project.Properties.Resources.currency_16x165;
            this.btnCurrency.ImageOptions.LargeImage = global::servis_project.Properties.Resources.currency_32x326;
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCurrency_ItemClick);
            // 
            // btnMaps
            // 
            this.btnMaps.Caption = "Haritalar";
            this.btnMaps.Id = 9;
            this.btnMaps.ImageOptions.Image = global::servis_project.Properties.Resources.geopointmap_16x161;
            this.btnMaps.ImageOptions.LargeImage = global::servis_project.Properties.Resources.geopointmap_32x321;
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMaps_ItemClick);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Caption = "Takvim";
            this.btnCalendar.Id = 10;
            this.btnCalendar.ImageOptions.Image = global::servis_project.Properties.Resources.today_16x162;
            this.btnCalendar.ImageOptions.LargeImage = global::servis_project.Properties.Resources.today_32x322;
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalendar_ItemClick);
            // 
            // btnAccount
            // 
            this.btnAccount.Caption = "Hesap Ayarları";
            this.btnAccount.Id = 11;
            this.btnAccount.ImageOptions.Image = global::servis_project.Properties.Resources.bopermission_16x161;
            this.btnAccount.ImageOptions.LargeImage = global::servis_project.Properties.Resources.bopermission_32x321;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccount_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Yetkilendirmeler";
            this.barButtonItem8.Id = 12;
            this.barButtonItem8.ImageOptions.LargeImage = global::servis_project.Properties.Resources.bouser_32x322;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Rapor Sihirbazı";
            this.btnReport.Id = 13;
            this.btnReport.ImageOptions.Image = global::servis_project.Properties.Resources.wizard_16x166;
            this.btnReport.ImageOptions.LargeImage = global::servis_project.Properties.Resources.wizard_32x326;
            this.btnReport.Name = "btnReport";
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
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
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Araçlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCalc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnYoutube);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCurrency);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMaps);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCalendar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAccount);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Raporlar";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReport);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Paneli";
            this.Load += new System.EventHandler(this.FrmStaffForm_Load);
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
        private DevExpress.XtraBars.BarButtonItem btnCalc;
        private DevExpress.XtraBars.BarButtonItem btnYoutube;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnCurrency;
        private DevExpress.XtraBars.BarButtonItem btnMaps;
        private DevExpress.XtraBars.BarButtonItem btnCalendar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem btnReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}