using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GE.SL.Servives
{
    public class AccountService: IAccountService
    {

        private readonly IUnitOfWork _unitOfWork;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;

        public AccountService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ApplicationUserVM GetByEmail(string email)
        {
            ApplicationUser account = _unitOfWork.ApplicationUsers.GetByEmail(email);

            return new ApplicationUserVM {UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber};
        }

        public ApplicationUserVM GetById(string id)
        {
            var account = _userManager.FindByIdAsync(id).Result;

            return new ApplicationUserVM { Id = account.Id, UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber, Points = account.Points };
        }

        public ApplicationUserVM GetByUserName(string name)
        {
            var account = _userManager.FindByNameAsync(name).Result;

            return new ApplicationUserVM { Id = account.Id, UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber, Points = account.Points };
        }

        public void UpdateUserPoints(ApplicationUserVM u)
        {
            var user = _userManager.FindByIdAsync(u.Id).Result;
            user.Points = u.Points;
            _userManager.UpdateAsync(user);
        }
    }
}
