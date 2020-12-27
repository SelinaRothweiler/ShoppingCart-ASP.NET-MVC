using ShoppingCart.DataAccess.Model;
using ShoppingCart.Service.Data;
using ShoppingCart.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Service.Repositories
{
    public class CategoryRepo : ICategory
    {
        private readonly ApplicationDbContext _context;

         CategoryRepo(ApplicationDbContext context) => _context = context;

        public int Id { get; private set; }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById()
        {
            return _context.Categories.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void InsertCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
