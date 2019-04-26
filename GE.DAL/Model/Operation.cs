using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Operation
    {
        public string Id { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public string Date { get; set; }
        public string PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}
