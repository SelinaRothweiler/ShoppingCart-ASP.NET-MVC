using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Service.Infrastructure
{
   public interface ICategory
    {
        List<Category> GetAllCategories();
        Category GetCategoryById();
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void Save();
    }
}
