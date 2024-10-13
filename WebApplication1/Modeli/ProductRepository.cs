#region zakomentarisi
//using System.Data;
//using System.Data.SqlClient;

//namespace WebApplication1.Modeli
//{
//    public class ProductRepository 
//    {

//        private readonly string connString;

//        public ProductRepository(string connectionString)
//        {
//            connString = connectionString;
//        }

//        public async Task<IEnumerable<ProductDto>> GetAllAsync()
//        {
//            var products = new List<ProductDto>();

//            using (var connection = new SqlConnection(connString))
//            {
//                var command = new SqlCommand("GetAllProducts", connection)
//                {
//                    CommandType = CommandType.StoredProcedure
//                };

//                await connection.OpenAsync();
//                using (var reader = await command.ExecuteReaderAsync())
//                {
//                    while (await reader.ReadAsync())
//                    {
//                        products.Add(new ProductDto
//                        {
//                            ProductID = (int)reader["ProductID"],
//                            ProductName = (string)reader["ProductName"],
//                            Price = (decimal)reader["Price"],
//                            Description = reader["Description"].ToString(),
//                            StockQuantity = (int)reader["StockQuantity"],
//                            CreatedAt = (DateTime)reader["CreatedAt"]
//                        });
//                    }
//                }
//            }
//            return products;
//        }

//        public async Task<ProductDto> GetByIdAsync(int id)
//        {
//            ProductDto product = null;

//            using (var connection = new SqlConnection(connString))
//            {
//                var command = new SqlCommand("GetProductById", connection)
//                {
//                    CommandType = CommandType.StoredProcedure
//                };
//                command.Parameters.AddWithValue("@ID", id);

//                await connection.OpenAsync();
//                using (var reader = await command.ExecuteReaderAsync())
//                {
//                    if (await reader.ReadAsync())
//                    {
//                        product = new ProductDto
//                        {
//                            ProductID = (int)reader["ProductID"],
//                            ProductName = (string)reader["ProductName"],
//                            Price = (decimal)reader["Price"],
//                            Description = reader["Description"].ToString(),
//                            StockQuantity = (int)reader["StockQuantity"],
//                            CreatedAt = (DateTime)reader["CreatedAt"]
//                        };
//                    }
//                }
//            }
//            return product;
//        }

//        public async Task AddAsync(ProductDto product)
//        {
//            using (var connection = new SqlConnection(connString))
//            {
//                var cmd = new SqlCommand("AddProduct", connection)
//                {
//                    CommandType = CommandType.StoredProcedure
//                };
//                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
//                cmd.Parameters.AddWithValue("@Price", product.Price);
//                cmd.Parameters.AddWithValue("@Description", product.Description);
//                cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
//                cmd.Parameters.AddWithValue("@CreatedAt", product.CreatedAt);

//                await connection.OpenAsync();
//                await cmd.ExecuteNonQueryAsync();
//            }
//        }

//        public async Task UpdateAsync(ProductDto product)
//        {
//            using (var connection = new SqlConnection(connString))
//            {
//                var cmd = new SqlCommand("UpdateProduct", connection)
//                {
//                    CommandType = CommandType.StoredProcedure
//                };
//                cmd.Parameters.AddWithValue("@Id", product.ProductID);
//                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
//                cmd.Parameters.AddWithValue("@Price", product.Price);
//                cmd.Parameters.AddWithValue("@Description", product.Description);
//                cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
//                cmd.Parameters.AddWithValue("@CreatedAt", product.CreatedAt);

//                await connection.OpenAsync();
//                await cmd.ExecuteNonQueryAsync();
//            }
//        }

//        public async Task DeleteAsync(int id)
//        {
//            using (var connection = new SqlConnection(connString))
//            {
//                var command = new SqlCommand("DeleteProduct", connection)
//                {
//                    CommandType = CommandType.StoredProcedure
//                };
//                command.Parameters.AddWithValue("@ID", id);

//                await connection.OpenAsync();
//                await command.ExecuteNonQueryAsync();
//            }
//        }
//    }
//}
#endregion

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication1.Modeli
{
    public class ProductRepository : IProductRepository
    {
        private readonly string connString;

        public ProductRepository(string connectionString)
        {
            connString = connectionString;
        }

        public IEnumerable<ProductDto> GetAll(DateTime? datumOd, DateTime? datumDo)
        {
            var products = new List<ProductDto>();

            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand("GetAllProducts", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (datumOd.HasValue)
                {
                    command.Parameters.AddWithValue("@DatumOd", datumOd.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@DatumOd", DBNull.Value);
                }

                if (datumDo.HasValue)
                {
                    command.Parameters.AddWithValue("@DatumDo", datumDo.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@DatumDo", DBNull.Value);
                }

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDto
                        {
                            ProductID = (int)reader["ProductID"],
                            ProductName = (string)reader["ProductName"],
                            Price = (decimal)reader["Price"],
                            Description = reader["Description"].ToString(),
                            StockQuantity = (int)reader["StockQuantity"],
                            CreatedAt = (DateTime)reader["CreatedAt"],
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"]
                        });
                    }
                }
            }

            return products;
        }

        public IEnumerable<ProductDto> GetProductsByDateRange(DateTime? datumOd, DateTime? datumDo)
        {
            var products = new List<ProductDto>();

            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand("GetProductsByDateRange", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (datumOd.HasValue)
                {
                    command.Parameters.AddWithValue("@DatumOd", datumOd.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@DatumOd", DBNull.Value);
                }

                if (datumDo.HasValue)
                {
                    command.Parameters.AddWithValue("@DatumDo", datumDo.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@DatumDo", DBNull.Value);
                }

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDto
                        {
                            ProductID = (int)reader["ProductID"],
                            ProductName = (string)reader["ProductName"],
                            Price = (decimal)reader["Price"],
                            Description = reader["Description"].ToString(),
                            StockQuantity = (int)reader["StockQuantity"],
                            CreatedAt = (DateTime)reader["CreatedAt"],
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"]
                        });
                    }
                }
            }

            return products;
        }

        public ProductDto GetById(int id)
        {
            ProductDto product = null;

            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand("GetProductById", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new ProductDto
                        {
                            ProductID = (int)reader["ProductID"],
                            ProductName = (string)reader["ProductName"],
                            Price = (decimal)reader["Price"],
                            Description = reader["Description"].ToString(),
                            StockQuantity = (int)reader["StockQuantity"],
                            CreatedAt = (DateTime)reader["CreatedAt"]
                        };
                    }
                }
            }

            return product;
        }

        public void Add(ProductDto product)
        {
            using (var connection = new SqlConnection(connString))
            {
                var cmd = new SqlCommand("AddProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                cmd.Parameters.AddWithValue("@CreatedAt", product.CreatedAt);
                cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                var pIDParam = new SqlParameter("@pID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(pIDParam);
                connection.Open();
                cmd.ExecuteNonQuery();

                var proizvodID = (int)pIDParam.Value;

                cmd.Parameters.Clear();
                 cmd = new SqlCommand("InsertProductCategory", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@pID", proizvodID);
                cmd.Parameters.AddWithValue("@cID", product.CategoryID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(ProductDto product)
        {
            using (var connection = new SqlConnection(connString))
            {
                var cmd = new SqlCommand("UpdateProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Id", product.ProductID);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                cmd.Parameters.AddWithValue("@CreatedAt", product.CreatedAt);
                cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand("DeleteProduct", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
