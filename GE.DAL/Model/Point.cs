using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Point
    {
        public string Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public virtual ApplicationUser User { get; set; }
        public int Points { get; set; }
        public virtual ICollection<Microsoft.AspNetCore.JsonPatch.Operations.Operation> Operations { get; set; }
    }
}
