using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static DevExpress.Data.Mask.Internal.MaskSettings<>;

namespace Projekat
{
    public partial class FrmProductsPreview : Form
    {
        public FrmProductsPreview()
        {
            InitializeComponent();
        }

        private void btnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Ucitaj();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gcProducts_DoubleClick(object sender, EventArgs e)
        {
            if (gvProducts.RowCount == 0 || gvProducts.DataSource == null)
            {
                XtraMessageBox.Show("Nemate nijedan vraceni red.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = gvProducts.FocusedRowHandle;
            if (selected >= 0)
            {
                var p = gvProducts.GetRow(selected) as Product;
                if (p != null)
                {
                    var FrmNewProduct = new FrmNewProduct(p);
                    FrmNewProduct.ShowDialog();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var productService = new ProductService();
                if (gvProducts.FocusedRowHandle >= 0)
                {
                    var selectedRow = (Product)gvProducts.GetFocusedRow();
                    productService.DeleteProduct(selectedRow.ProductID);
                    Ucitaj();
                }
                else
                {
                    XtraMessageBox.Show("Nijedan red nije odabran.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void FrmProductsPreview_Load(object sender, EventArgs e)
        {
 
        }

        private void Ucitaj()
        {
            var productService = new ProductService();
            List<Product> products = new List<Product>();
            System.DateTime? datumOd = null;
            System.DateTime? datumDo = null;
            if (deDatumOd.EditValue != null)
            {
                datumOd = (System.DateTime)deDatumOd.EditValue;
            }
            if (deDatumDo.EditValue != null)
            {
                datumDo = (System.DateTime)deDatumDo.EditValue;
            }
            gcProducts.DataSource = products = productService.GetProducts(datumOd, datumDo);
        }
    }
 }
