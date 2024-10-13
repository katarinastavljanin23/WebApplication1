namespace Projekat
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductsPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProductsPreview,
            this.btnAddNewProduct});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPreview,
            this.btnAddNewCategory});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // btnProductsPreview
            // 
            this.btnProductsPreview.Name = "btnProductsPreview";
            this.btnProductsPreview.Size = new System.Drawing.Size(180, 22);
            this.btnProductsPreview.Text = "Preview";
            this.btnProductsPreview.Click += new System.EventHandler(this.btnProductsPreview_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(180, 22);
            this.btnAddNewProduct.Text = "Add new";
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(180, 22);
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(180, 22);
            this.btnAddNewCategory.Text = "Add new";
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Home page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnProductsPreview;
        private System.Windows.Forms.ToolStripMenuItem btnAddNewProduct;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPreview;
        private System.Windows.Forms.ToolStripMenuItem btnAddNewCategory;
    }
}

