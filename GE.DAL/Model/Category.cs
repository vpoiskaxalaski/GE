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

        public List<Subcategory> Subcategories { get; set; }

        public Category(){ }

        public Category(string Name)
        {
            this.Name = Name;
        }

        public Category(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}