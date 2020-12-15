using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Service.Infrastructure
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById();
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void Save();
    }
}
