using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Modeli
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string connString;

        public CategoryRepository(string connectionString)
        {
            connString = connectionString;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            var categories = new List<CategoryDto>();

            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand("GetAllCategories", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new CategoryDto
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"],
                            CreatedAt = (DateTime)reader["CreatedAt"]
                        });
                    }
                }
            }

            return categories;
        }

        public CategoryDto GetById(int id)
        {
            CategoryDto category = null;

            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand("GetCategoryById", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        category = new CategoryDto
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"],
                            CreatedAt = (DateTime)reader["CreatedAt"]
                        };
                    }
                }
            }

            return category;
        }

        public void Add(CategoryDto category)
        {
            using (var connection = new SqlConnection(connString))
            {
                var cmd = new SqlCommand("AddCategory", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                cmd.Parameters.AddWithValue("@CreatedAt", category.CreatedAt);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CategoryDto category)
        {
            using (var connection = new SqlConnection(connString))
            {
                var cmd = new SqlCommand("UpdateCategory", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Id", category.CategoryID);
                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                cmd.Parameters.AddWithValue("@CreatedAt", category.CreatedAt);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand("DeleteCategory", connection)
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
