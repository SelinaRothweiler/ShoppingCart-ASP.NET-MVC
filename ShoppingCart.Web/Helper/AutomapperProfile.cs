using AutoMapper;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.Helper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
