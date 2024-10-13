using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
