using GE.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Interfaces
{
    public interface IApplicationUserRepository
    {
        ApplicationUser GetByEmail(string email);

        ApplicationUser GetByUserName(string name);

        //bool Login(string email, string password);

        //bool Registration(ApplicationUser entity);

        bool IsExists(string email);

        //string GetRole(string email);

        List<ApplicationUser> Find(Func<ApplicationUser, Boolean> predicate);
    }
}
