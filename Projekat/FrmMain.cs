using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnProductsPreview_Click(object sender, EventArgs e)
        {
            FrmProductsPreview frmProductsPreview = new FrmProductsPreview();
            frmProductsPreview.ShowDialog();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            FrmNewProduct frm = new FrmNewProduct();
            frm.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            FrmCategoryPreview frmCategoryPreview = new FrmCategoryPreview();
            frmCategoryPreview.ShowDialog();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            FrmNewCategory frm = new FrmNewCategory();
            frm.ShowDialog();
        }
    }
}
