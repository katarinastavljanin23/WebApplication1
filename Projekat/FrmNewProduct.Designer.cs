namespace Projekat
{
    partial class FrmNewProduct
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
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtDesciption = new System.Windows.Forms.RichTextBox();
            this.txtStockQuantity = new DevExpress.XtraEditors.TextEdit();
            this.deCreatedAt = new DevExpress.XtraEditors.DateEdit();
            this.lblCategory = new System.Windows.Forms.Label();
            this.glueCategory = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedAt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
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
            this.btnSave});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(356, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 236);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(356, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 216);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(356, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 216);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(22, 37);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(73, 13);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 94);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(20, 152);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(75, 13);
            this.lblStockQuantity.TabIndex = 7;
            this.lblStockQuantity.Text = "Stock quantity";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(22, 183);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(56, 13);
            this.lblCreatedAt.TabIndex = 8;
            this.lblCreatedAt.Text = "Created at";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(127, 32);
            this.txtProductName.MenuManager = this.barManager1;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(192, 20);
            this.txtProductName.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(127, 59);
            this.txtPrice.MenuManager = this.barManager1;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(192, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(127, 89);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(192, 51);
            this.txtDesciption.TabIndex = 11;
            this.txtDesciption.Text = "";
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(127, 149);
            this.txtStockQuantity.MenuManager = this.barManager1;
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(192, 20);
            this.txtStockQuantity.TabIndex = 12;
            // 
            // deCreatedAt
            // 
            this.deCreatedAt.EditValue = null;
            this.deCreatedAt.Location = new System.Drawing.Point(127, 180);
            this.deCreatedAt.MenuManager = this.barManager1;
            this.deCreatedAt.Name = "deCreatedAt";
            this.deCreatedAt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCreatedAt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCreatedAt.Size = new System.Drawing.Size(191, 20);
            this.deCreatedAt.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(22, 213);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category";
            // 
            // glueCategory
            // 
            this.glueCategory.EditValue = "";
            this.glueCategory.Location = new System.Drawing.Point(127, 210);
            this.glueCategory.MenuManager = this.barManager1;
            this.glueCategory.Name = "glueCategory";
            this.glueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueCategory.Properties.DisplayFormat.FormatString = "dd:MM:yyyy";
            this.glueCategory.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.glueCategory.Properties.EditFormat.FormatString = "dd:MM:yyyy";
            this.glueCategory.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.glueCategory.Properties.NullText = "";
            this.glueCategory.Properties.PopupView = this.gridLookUpEdit1View;
            this.glueCategory.Size = new System.Drawing.Size(190, 20);
            this.glueCategory.TabIndex = 15;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCategoryName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcCategoryName
            // 
            this.gcCategoryName.Caption = "CategoryName";
            this.gcCategoryName.FieldName = "CategoryName";
            this.gcCategoryName.Name = "gcCategoryName";
            this.gcCategoryName.Visible = true;
            this.gcCategoryName.VisibleIndex = 0;
            // 
            // FrmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 256);
            this.Controls.Add(this.glueCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.deCreatedAt);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmNewProduct";
            this.Text = "New product";
            this.Load += new System.EventHandler(this.FrmNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedAt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtStockQuantity;
        private System.Windows.Forms.RichTextBox txtDesciption;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private DevExpress.XtraEditors.GridLookUpEdit glueCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label lblCategory;
        private DevExpress.XtraEditors.DateEdit deCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gcCategoryName;
    }
}