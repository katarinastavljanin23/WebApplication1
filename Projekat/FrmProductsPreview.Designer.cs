namespace Projekat
{
    partial class FrmProductsPreview
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deDatumDo = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.deDatumOd = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatumOD = new System.Windows.Forms.Label();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDescripiton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDatumDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDatumDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDatumOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDatumOd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnPreview});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPreview)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "Preview";
            this.btnPreview.Id = 0;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreview_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainer1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 410);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deDatumDo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.deDatumOd);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblDatumOD);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcProducts);
            this.splitContainer1.Size = new System.Drawing.Size(796, 406);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 0;
            // 
            // deDatumDo
            // 
            this.deDatumDo.EditValue = null;
            this.deDatumDo.Location = new System.Drawing.Point(193, 13);
            this.deDatumDo.MenuManager = this.barManager1;
            this.deDatumDo.Name = "deDatumDo";
            this.deDatumDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDatumDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDatumDo.Size = new System.Drawing.Size(100, 20);
            this.deDatumDo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // deDatumOd
            // 
            this.deDatumOd.EditValue = null;
            this.deDatumOd.Location = new System.Drawing.Point(70, 13);
            this.deDatumOd.MenuManager = this.barManager1;
            this.deDatumOd.Name = "deDatumOd";
            this.deDatumOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDatumOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDatumOd.Size = new System.Drawing.Size(100, 20);
            this.deDatumOd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // lblDatumOD
            // 
            this.lblDatumOD.AutoSize = true;
            this.lblDatumOD.Location = new System.Drawing.Point(20, 16);
            this.lblDatumOD.Name = "lblDatumOD";
            this.lblDatumOD.Size = new System.Drawing.Size(35, 13);
            this.lblDatumOD.TabIndex = 0;
            this.lblDatumOD.Text = "label1";
            // 
            // gcProducts
            // 
            this.gcProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProducts.Location = new System.Drawing.Point(0, 0);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.MenuManager = this.barManager1;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(796, 337);
            this.gcProducts.TabIndex = 0;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            this.gcProducts.DoubleClick += new System.EventHandler(this.gcProducts_DoubleClick);
            // 
            // gvProducts
            // 
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcProductName,
            this.gcPrice,
            this.gcDescripiton,
            this.gcStockQuantity,
            this.gcCreatedAt,
            this.gcCategory,
            this.gcProductID});
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsView.ShowGroupPanel = false;
            // 
            // gcProductName
            // 
            this.gcProductName.Caption = "Product name";
            this.gcProductName.FieldName = "ProductName";
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.OptionsColumn.AllowEdit = false;
            this.gcProductName.OptionsColumn.ReadOnly = true;
            this.gcProductName.Visible = true;
            this.gcProductName.VisibleIndex = 0;
            // 
            // gcPrice
            // 
            this.gcPrice.Caption = "Price";
            this.gcPrice.FieldName = "Price";
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.Visible = true;
            this.gcPrice.VisibleIndex = 1;
            // 
            // gcDescripiton
            // 
            this.gcDescripiton.Caption = "Descripiton";
            this.gcDescripiton.FieldName = "Description";
            this.gcDescripiton.Name = "gcDescripiton";
            this.gcDescripiton.Visible = true;
            this.gcDescripiton.VisibleIndex = 2;
            // 
            // gcStockQuantity
            // 
            this.gcStockQuantity.Caption = "StockQuantity";
            this.gcStockQuantity.FieldName = "StockQuantity";
            this.gcStockQuantity.Name = "gcStockQuantity";
            this.gcStockQuantity.Visible = true;
            this.gcStockQuantity.VisibleIndex = 3;
            // 
            // gcCreatedAt
            // 
            this.gcCreatedAt.Caption = "Created at";
            this.gcCreatedAt.FieldName = "CreatedAt";
            this.gcCreatedAt.Name = "gcCreatedAt";
            this.gcCreatedAt.Visible = true;
            this.gcCreatedAt.VisibleIndex = 4;
            // 
            // gcCategory
            // 
            this.gcCategory.Caption = "Category";
            this.gcCategory.FieldName = "CategoryName";
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Visible = true;
            this.gcCategory.VisibleIndex = 5;
            // 
            // gcProductID
            // 
            this.gcProductID.Caption = "ProductID";
            this.gcProductID.FieldName = "ProductID";
            this.gcProductID.Name = "gcProductID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FrmProductsPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmProductsPreview";
            this.Text = "Products preview";
            this.Load += new System.EventHandler(this.FrmProductsPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deDatumDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDatumDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDatumOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDatumOd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn gcProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcDescripiton;
        private DevExpress.XtraGrid.Columns.GridColumn gcStockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gcCategory;
        private DevExpress.XtraEditors.DateEdit deDatumDo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit deDatumOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatumOD;
        private DevExpress.XtraGrid.Columns.GridColumn gcProductID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}