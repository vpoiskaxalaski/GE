using GE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.SL.Interfaces
{
    public interface IAccountService
    {

        ApplicationUserVM GetByEmail(string email);

        bool Login(LoginViewModel model);

        bool Registration(RegisterViewModel model);

        string GetRole(string email);

        bool ConfirmEmail(string email); 

    }
}
