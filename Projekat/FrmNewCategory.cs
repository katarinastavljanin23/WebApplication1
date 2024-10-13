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

namespace Projekat
{
    public partial class FrmNewCategory : Form
    {
        private Category _category = new Category();
        public FrmNewCategory()
        {
            InitializeComponent();
        }
        public FrmNewCategory(Category category)
        {
            InitializeComponent();
            _category = category;
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var categoryService = new CategoryService();

                #region Validacije
                if (!string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    _category.CategoryName = txtCategoryName.Text;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti naziv kategorije.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (deCreatedAt.EditValue != null)
                {
                    _category.CreatedAt = (DateTime)deCreatedAt.EditValue;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti datum kreiranja.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                if (_category.CategoryID == 0)
                {
                    var result = categoryService.CreateCategory(_category);
                }
                else 
                {
                    var result = categoryService.UpdateCategory(_category.CategoryID, _category);
                }
                this.Close();
               
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmNewCategory_Load(object sender, EventArgs e)
        {
            if (_category != null)
            {
                txtCategoryName.Text = _category.CategoryName;
                if (_category.CreatedAt != null)
                {
                    deCreatedAt.EditValue = _category.CreatedAt;
                }
            }
        }
    }
}
