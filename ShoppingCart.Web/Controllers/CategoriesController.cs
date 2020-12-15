using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Service.Infrastructure;
using ShoppingCart.Web.ViewModels;

namespace ShoppingCart.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategory _category;

        public CategoriesController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var AllCategories = _category.GetAllCategories();
            List<CategoryViewModel> vm = new List<CategoryViewModel>();
            foreach (var item in AllCategories)
            {
                vm.Add(new CategoryViewModel
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return View(vm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
