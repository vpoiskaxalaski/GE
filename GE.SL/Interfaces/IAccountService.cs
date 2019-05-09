using GE.Models;
using System.Threading.Tasks;

namespace GE.SL.Interfaces
{
    public interface IAccountService
    {

        ApplicationUserVM GetByEmail(string email);

        ApplicationUserVM GetByUserName(string name);

        ApplicationUserVM GetById(string id);

        //bool Login(LoginViewModel model);

        //Task<ApplicationUserVM> Registration(RegisterViewModel model);
    }
}
