using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Order
    {
        public string Id { get; set; }
        public string PostId { get; set; }
        public virtual Post Post { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
