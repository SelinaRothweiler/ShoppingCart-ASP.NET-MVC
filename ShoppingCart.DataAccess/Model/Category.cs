﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategory> Products { get; set; }
    }
}
