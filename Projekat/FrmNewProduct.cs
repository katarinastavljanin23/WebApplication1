using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
namespace Projekat
{
    public partial class FrmNewProduct : Form
    {
        private Product _product = new Product();
        public FrmNewProduct()
        {
            InitializeComponent();
        }

        public FrmNewProduct(Product p)
        {
            InitializeComponent();
            _product = p;
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            try
            {
                //punjenje glue-a
                //var baseAddress = ConfigurationManager.AppSettings["YourDbContext"];
                string connectionString = ConfigurationManager.ConnectionStrings["YourDbContext"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    var categories = new List<Category>();
                    connection.Open();
                    var command = new SqlCommand("GetAllCategories", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new Category
                            {
                                CategoryID = (int)reader["CategoryID"],
                                CategoryName = (string)reader["CategoryName"],
                            });
                        }
                    }
                    glueCategory.Properties.DataSource = categories;
                    glueCategory.Properties.DisplayMember = "CategoryName";
                    glueCategory.Properties.ValueMember = "CategoryID";
                }


                if (_product != null)
                {
                    txtProductName.Text = _product.ProductName;
                    txtDesciption.Text = _product.Description;

                    if (_product.Price != null)
                    {
                        txtPrice.Text = _product.Price.ToString();
                    }

                    if (_product.StockQuantity != null)
                    {
                        txtStockQuantity.Text = _product.StockQuantity.ToString();
                    }

                    if (_product.CreatedAt != null)
                    {
                        deCreatedAt.EditValue = _product.CreatedAt;
                    }

                    if (_product.CategoryID != null)
                    {
                        glueCategory.EditValue = _product.CategoryID;
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //private async Task btnSave_ItemClickAsync(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
            
        //}

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var productService = new ProductService();

                #region Validacije
                if (!string.IsNullOrEmpty(txtProductName.Text))
                {
                    _product.ProductName = txtProductName.Text;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti naziv proizvoda.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(txtDesciption.Text))
                {
                    _product.Description = txtDesciption.Text;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti opis proizvoda.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    _product.Price = price;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti cenu.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(txtStockQuantity.Text, out int stockQuantity))
                {
                    _product.StockQuantity = stockQuantity;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti količinu.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (deCreatedAt.EditValue != null)
                {
                    _product.CreatedAt = (DateTime)deCreatedAt.EditValue;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti datum kreiranja.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (glueCategory.EditValue != null)
                {
                    _product.CategoryID = (int)glueCategory.EditValue;
                    _product.CategoryName = (string)glueCategory.Text;
                }
                else
                {
                    XtraMessageBox.Show("Morate uneti kojoj kategoriji proizvod pripada.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                if (_product.ProductID == 0)
                {
                    var result = productService.CreateProduct(_product);//bool
                }
                else
                {
                    var result = productService.UpdateProduct(_product.ProductID, _product);//bool
                }

                this.Close();
          
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
