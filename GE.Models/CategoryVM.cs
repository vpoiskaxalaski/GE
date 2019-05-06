﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.Models
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SubcategoryVM> Subcategories { get; set; }
    }
}