using System;
using System.Collections.Generic;
using System.Text;

namespace GE.Models
{
    public class OperationVM
    {
        public int Id { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public string Date { get; set; }
        public string UserId { get; set; }

        public ApplicationUserVM User { get; set; }
    }
}
