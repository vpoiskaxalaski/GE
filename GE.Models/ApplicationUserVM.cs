using Microsoft.AspNetCore.Identity;

namespace GE.Models
{
    public class ApplicationUserVM : IdentityUser
    {
        public virtual int Points { get; set; }
    }
}
