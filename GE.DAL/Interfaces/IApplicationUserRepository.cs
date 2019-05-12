using GE.DAL.Model;
using System;
using System.Collections.Generic;

namespace GE.DAL.Interfaces
{
    public interface IApplicationUserRepository
    {
        ApplicationUser GetByEmail(string email);

        ApplicationUser GetByUserName(string name);

        bool IsExists(string email);

        List<ApplicationUser> Find(Func<ApplicationUser, Boolean> predicate);
    }
}
