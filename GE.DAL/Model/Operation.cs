using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Operation
    {
        public int Id { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public string Date { get; set; }
        public int PointId { get; set; }

        public Point Point { get; set; }
    }
}
