namespace QuanLyBanHang.Forms
{
    partial class KhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label gHICHULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Them = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gHICHURichTextBox = new System.Windows.Forms.RichTextBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANNLYDONHANGDataSet = new QuanLyBanHang.QUANNLYDONHANGDataSet();
            this.sDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView_KhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kHACHHANGTableAdapter = new QuanLyBanHang.QUANNLYDONHANGDataSetTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QUANNLYDONHANGDataSetTableAdapters.TableAdapterManager();
            iDLabel1 = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANNLYDONHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(5, 90);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(79, 13);
            iDLabel1.TabIndex = 8;
            iDLabel1.Text = "Mã khách hàng";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(297, 90);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(83, 13);
            tENKHLabel.TabIndex = 9;
            tENKHLabel.Text = "Tên khách hàng";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(609, 90);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(69, 13);
            sDTLabel.TabIndex = 10;
            sDTLabel.Text = "Số điện thoại";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(968, 94);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(42, 13);
            gHICHULabel.TabIndex = 11;
            gHICHULabel.Text = "Ghi chú";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_Them,
            this.barButtonItem_Xoa,
            this.barButtonItem_Sua,
            this.barButtonItem_Ghi,
            this.barButtonItem_Thoat});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Thoat)});
            this.bar2.Text = "Tools";
            // 
            // barButtonItem_Them
            // 
            this.barButtonItem_Them.Caption = "Thêm";
            this.barButtonItem_Them.Id = 0;
            this.barButtonItem_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_Them.ImageOptions.SvgImage")));
            this.barButtonItem_Them.Name = "barButtonItem_Them";
            this.barButtonItem_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Them_ItemClick);
            // 
            // barButtonItem_Xoa
            // 
            this.barButtonItem_Xoa.Caption = "Xóa";
            this.barButtonItem_Xoa.Id = 1;
            this.barButtonItem_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_Xoa.ImageOptions.SvgImage")));
            this.barButtonItem_Xoa.Name = "barButtonItem_Xoa";
            this.barButtonItem_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Xoa_ItemClick);
            // 
            // barButtonItem_Sua
            // 
            this.barButtonItem_Sua.Caption = "Sửa";
            this.barButtonItem_Sua.Id = 2;
            this.barButtonItem_Sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_Sua.ImageOptions.SvgImage")));
            this.barButtonItem_Sua.Name = "barButtonItem_Sua";
            this.barButtonItem_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Sua_ItemClick);
            // 
            // barButtonItem_Ghi
            // 
            this.barButtonItem_Ghi.Caption = "Ghi";
            this.barButtonItem_Ghi.Id = 3;
            this.barButtonItem_Ghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_Ghi.ImageOptions.SvgImage")));
            this.barButtonItem_Ghi.Name = "barButtonItem_Ghi";
            this.barButtonItem_Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Ghi_ItemClick);
            // 
            // barButtonItem_Thoat
            // 
            this.barButtonItem_Thoat.Caption = "Thoát";
            this.barButtonItem_Thoat.Id = 4;
            this.barButtonItem_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_Thoat.ImageOptions.SvgImage")));
            this.barButtonItem_Thoat.Name = "barButtonItem_Thoat";
            this.barButtonItem_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Thoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1296, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 2401);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1296, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 2377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1296, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 2377);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(gHICHULabel);
            this.panelControl1.Controls.Add(this.gHICHURichTextBox);
            this.panelControl1.Controls.Add(sDTLabel);
            this.panelControl1.Controls.Add(this.sDTTextEdit);
            this.panelControl1.Controls.Add(tENKHLabel);
            this.panelControl1.Controls.Add(this.tENKHTextEdit);
            this.panelControl1.Controls.Add(iDLabel1);
            this.panelControl1.Controls.Add(this.iDTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 2166);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1296, 235);
            this.panelControl1.TabIndex = 4;
            // 
            // gHICHURichTextBox
            // 
            this.gHICHURichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "GHICHU", true));
            this.gHICHURichTextBox.Location = new System.Drawing.Point(1016, 58);
            this.gHICHURichTextBox.Name = "gHICHURichTextBox";
            this.gHICHURichTextBox.Size = new System.Drawing.Size(262, 96);
            this.gHICHURichTextBox.TabIndex = 12;
            this.gHICHURichTextBox.Text = "";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qUANNLYDONHANGDataSet;
            // 
            // qUANNLYDONHANGDataSet
            // 
            this.qUANNLYDONHANGDataSet.DataSetName = "QUANNLYDONHANGDataSet";
            this.qUANNLYDONHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sDTTextEdit
            // 
            this.sDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "SDT", true));
            this.sDTTextEdit.Location = new System.Drawing.Point(682, 87);
            this.sDTTextEdit.MenuManager = this.barManager1;
            this.sDTTextEdit.Name = "sDTTextEdit";
            this.sDTTextEdit.Size = new System.Drawing.Size(124, 20);
            this.sDTTextEdit.TabIndex = 11;
            // 
            // tENKHTextEdit
            // 
            this.tENKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "TENKH", true));
            this.tENKHTextEdit.Location = new System.Drawing.Point(386, 87);
            this.tENKHTextEdit.MenuManager = this.barManager1;
            this.tENKHTextEdit.Name = "tENKHTextEdit";
            this.tENKHTextEdit.Size = new System.Drawing.Size(124, 20);
            this.tENKHTextEdit.TabIndex = 10;
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(90, 87);
            this.iDTextEdit.MenuManager = this.barManager1;
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Size = new System.Drawing.Size(113, 20);
            this.iDTextEdit.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kHACHHANGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView_KhachHang;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1296, 2142);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_KhachHang});
            // 
            // gridView_KhachHang
            // 
            this.gridView_KhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTENKH,
            this.colSDT,
            this.colGHICHU});
            this.gridView_KhachHang.GridControl = this.gridControl1;
            this.gridView_KhachHang.Name = "gridView_KhachHang";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.OptionsColumn.AllowEdit = false;
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 3;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUTHANHTableAdapter = null;
            this.tableAdapterManager.CTDATHANGTableAdapter = null;
            this.tableAdapterManager.DACTINHTableAdapter = null;
            this.tableAdapterManager.DOITACTableAdapter = null;
            this.tableAdapterManager.DONHANGTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.QUANNLYDONHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(1296, 2421);
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANNLYDONHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Ghi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Thoat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QUANNLYDONHANGDataSet qUANNLYDONHANGDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private QUANNLYDONHANGDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private QUANNLYDONHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RichTextBox gHICHURichTextBox;
        private DevExpress.XtraEditors.TextEdit sDTTextEdit;
        private DevExpress.XtraEditors.TextEdit tENKHTextEdit;
    }
}
