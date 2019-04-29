using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.DAL.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}