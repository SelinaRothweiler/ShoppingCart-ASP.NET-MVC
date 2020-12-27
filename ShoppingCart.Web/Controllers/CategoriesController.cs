using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Service.Infrastructure;
using ShoppingCart.Web.ViewModels.CategoryViewModels;

namespace ShoppingCart.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategory _category;
        private IMapper _mapper;


        public CategoriesController(ICategory category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var AllCategories = _category.GetAllCategories();
            var mappedCategories = _mapper.Map<List<CategoryViewModel>>(AllCategories);

            return View(mappedCategories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _category.GetCategoryById(id);
            var mappedCategory = _mapper.Map<EditCategoryViewModel>(category);
            return View();
        }
        [HttpGet]
        public IActionResult Details( int id)
        {
            var category = _category.GetCategoryById(id);
            var mappedCategory = _mapper.Map<DetailCategoryViewModel>(category);
            return View(mappedCategory);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _category.GetCategoryById(id);
            var mappedCategory = _mapper.Map<DeleteCategoryViewModel>(category);
            return View(mappedCategory);
        }
        [HttpPost]
        public IActionResult Delete(DeleteCategoryViewModel vm)
        {
            var mappedCategoryInModel = _mapper.Map<Category>(vm);
            _category.DeleteCategory(mappedCategoryInModel);
            _category.Save();
                return RedirectToAction("Index", "Categories");
        }
        [HttpPost]
        public IActionResult Edit(EditCategoryViewModel vm)
        {
            var mappedCategoryInModel = _mapper.Map<Category>(vm);
            _category.UpdateCategory(mappedCategoryInModel);
            _category.Save();
            return RedirectToAction("Index", "Categories");
        }

    }
}
