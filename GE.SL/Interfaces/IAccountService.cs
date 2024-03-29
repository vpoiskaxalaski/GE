﻿using GE.Models;

namespace GE.SL.Interfaces
{
    public interface IAccountService
    {

        ApplicationUserVM GetByEmail(string email);

        ApplicationUserVM GetByUserName(string name);

        ApplicationUserVM GetById(string id);

        void UpdateUserPoints(ApplicationUserVM user);

    }
}
