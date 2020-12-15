using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Decription { get; set; }
        public string ProductImage { get; set; }
        public ICollection<ProductCategory> Categories { get; set; }
    }
}
