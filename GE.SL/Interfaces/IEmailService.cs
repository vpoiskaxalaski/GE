using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GE.SL.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string message);
    }
}
