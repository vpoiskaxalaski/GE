﻿using GE.DAL.Interfaces;
using GE.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GE.DAL.Repositories
{

    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly DatabaseContext _context;

        public ApplicationUserRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<ApplicationUser> Find(Func<ApplicationUser, bool> predicate)
        {
            return _context.ApplicationUsers.Where(predicate).ToList();
        }

        public ApplicationUser GetByUserName(string name)
        {
            if (name != null)
            {
                return _context.ApplicationUsers.FirstOrDefault(x => x.UserName == name);
            }

            return new ApplicationUser();
        }

        public ApplicationUser GetByEmail(string email)
        {
            if (email != null)
            {
                return _context.ApplicationUsers.FirstOrDefault(x => x.Email == email);
            }

            return new ApplicationUser();
        }

        public bool IsExists(string email)
        {
            return _context.ApplicationUsers.FirstOrDefault(i => i.Email == email) != null ? true : false;
        }

    }
}