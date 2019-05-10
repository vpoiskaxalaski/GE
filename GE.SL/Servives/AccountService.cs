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

            return new ApplicationUserVM { Id = account.Id, UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber };
        }

        public ApplicationUserVM GetByUserName(string name)
        {
            var account = _userManager.FindByNameAsync(name).Result;

            return new ApplicationUserVM { Id = account.Id, UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber, Points = account.Points };
        }

        //public string GetRole(string email)
        //{
        //    return _unitOfWork.ApplicationUsers.GetRole(email);
        //}

        //public bool Login(LoginViewModel model)
        //{
        //    return _unitOfWork.ApplicationUsers.Login(model.Email, model.Password);
        //}

        //public async Task<ApplicationUserVM> Registration(RegisterViewModel model)
        //{
        //    ApplicationUser newUser = new ApplicationUser
        //    {
        //        UserName = model.Name,
        //        Email = model.Email,
        //        PhoneNumber = model.PhoneNumber
        //    };
        //    var result = await _userManager.CreateAsync(newUser, model.Password);

        //    if (result.Succeeded)
        //    {
        //        var config = new MapperConfiguration(cfg => {
        //            cfg.CreateMap<ApplicationUser, ApplicationUserVM>();
        //        });

        //        var map = config.CreateMapper();

        //        return map.Map<ApplicationUser, ApplicationUserVM>(newUser);
        //    }

        //    return null;
        //}

    }
}
