using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GE.DAL.Model
{
    public class ApplicationUser: IdentityUser
    {    
        //public int Id { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string PasswordHash { get; set; }
        //public string PhoneNumber { get; set; }
        public string Role { get; set; }

        public virtual Point Points { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        
    }
}
