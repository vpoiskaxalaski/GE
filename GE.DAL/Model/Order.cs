using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; }

        public virtual Post Post { get; set; }
       // public virtual ApplicationUser User { get; set; }
    }
}
