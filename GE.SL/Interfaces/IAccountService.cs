using GE.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GE.SL.Interfaces
{
    public interface IAccountService
    {

        ApplicationUserVM GetByEmail(string email);

        ApplicationUserVM GetByUserName(string name);

        bool Login(LoginViewModel model);

        Task<ApplicationUserVM> Registration(RegisterViewModel model);

        string GetRole(string email);
    }
}
