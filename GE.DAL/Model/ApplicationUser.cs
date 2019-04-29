using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class ApplicationUser: IdentityUser
    {
        public virtual Point Points { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        public async System.Threading.Tasks.Task<byte[]> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateSecurityTokenAsync(this);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }
}
