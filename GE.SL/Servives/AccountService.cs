using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GE.SL.Servives
{
    public class AccountService : IAccountService
    {

        private readonly IUnitOfWork _unitOfWork;
        private UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ApplicationUserVM GetByEmail(string email)
        {
            ApplicationUser account = _unitOfWork.ApplicationUsers.GetByEmail(email);

            return new ApplicationUserVM { UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber };
        }

        public ApplicationUserVM GetById(string id)
        {
            ApplicationUser account = _userManager.FindByIdAsync(id).Result;

            return new ApplicationUserVM { Id = account.Id, UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber, Points = account.Points };
        }

        public ApplicationUserVM GetByUserName(string name)
        {
            ApplicationUser account = _userManager.FindByNameAsync(name).Result;

            return new ApplicationUserVM { Id = account.Id, UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber, Points = account.Points };
        }

        public void UpdateUserPoints(ApplicationUserVM u)
        {
            ApplicationUser user = _userManager.FindByIdAsync(u.Id).Result;
            user.Points = u.Points;
            _userManager.UpdateAsync(user);
        }
    }
}
