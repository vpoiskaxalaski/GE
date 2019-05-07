using Crypto;
using GE.DAL.Model;
using GE.DAL.Interfaces;
using System.Linq;
using System;
using System.Collections.Generic;

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

        public string GetRole(string email)
        {
            if (email != null)
            {
                return _context.ApplicationUsers.Where(x => x.Email == email).FirstOrDefault().Role;
            }

            return "";
        }

        public bool IsExists(string email)
        {
            return _context.ApplicationUsers.FirstOrDefault(i => i.Email == email) != null ? true : false;
        }

        public bool Login(string email, string password)
        {
            string passwordHash = Crypto.Crypto.Sha256(password + email);
            var user = _context.ApplicationUsers.Where(x => x.Email == email && x.PasswordHash == passwordHash).FirstOrDefault();
            if (user != null && user.EmailConfirmed == true)
                return true;
            return false;
        }

        public bool Registration(ApplicationUser model)
        {
            if (!IsExists(model.Email))
            {
                var account = _context.ApplicationUsers.Add(new ApplicationUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PasswordHash = Crypto.Crypto.Sha256(model.PasswordHash + model.Email),
                    Role = "User"
                });

                _context.SaveChanges();

                return true;
            }

            return false;
        }

    }
}