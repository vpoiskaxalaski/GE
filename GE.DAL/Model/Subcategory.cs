using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GE.DAL.Model
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string CategoryName { get; set; }
        // public string CategoryId { get; set; }

        public Category Category { get; set; }
    }
}