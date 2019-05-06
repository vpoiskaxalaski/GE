using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;

namespace GE.SL.Servives
{
    public class AccountService: IAccountService
    {

        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ApplicationUserVM GetByEmail(string email)
        {
            ApplicationUser account = _unitOfWork.ApplicationUsers.GetByEmail(email);

            return new ApplicationUserVM {UserName = account.UserName, Email = account.Email, PhoneNumber = account.PhoneNumber};
        }

        public string GetRole(string email)
        {
            return _unitOfWork.ApplicationUsers.GetRole(email);
        }

        public bool Login(LoginViewModel model)
        {
            return _unitOfWork.ApplicationUsers.Login(model.Email, model.Password);
        }

        public bool Registration(RegisterViewModel model)
        {
            return _unitOfWork.ApplicationUsers.Registration(new ApplicationUser { UserName = model.Name, Email = model.Email, PasswordHash = model.Password, Role = "User" });
        }

        public bool ConfirmEmail(string email)
        {
            
           var user = _unitOfWork.ApplicationUsers.GetByEmail(email);
            if (user != null)
            {
                user.EmailConfirmed = true;
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
    }   
}
