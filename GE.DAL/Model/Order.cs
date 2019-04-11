using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Adopted { get; set; }
        public int Count { get; set; }
        public decimal FinalPrice { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Lot> Lot { get; set; }
    }
}
