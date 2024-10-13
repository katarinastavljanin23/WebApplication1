using DevExpress.XtraEditors;
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
    public partial class FrmCategoryPreview : Form
    {
        public FrmCategoryPreview()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var categoryService = new CategoryService();
                System.DateTime datumOd = DateTime.MinValue;
                System.DateTime datumDo = DateTime.MinValue;
           
                var lista = categoryService.GetCategoriesByDate(datumOd, datumDo);

                gcCategory.DataSource = lista;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gcCategory_DoubleClick(object sender, EventArgs e)
        {
            if (gvCategory.RowCount == 0 || gvCategory.DataSource == null)
            {
                XtraMessageBox.Show("Nemate nijedan vraceni red.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = gvCategory.FocusedRowHandle;
            if (selected >= 0) 
            {
                var category = gvCategory.GetRow(selected) as Category; 
                if (category != null)
                {
                    var frmNewCategory = new FrmNewCategory(category);
                    frmNewCategory.ShowDialog();
                }
            }
        }
    }
}
