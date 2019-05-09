using GE.Models;
using System.Collections.Generic;

namespace GE.SL.Interfaces
{
    public interface IOperationService
    {
        List<OperationVM> GetAll();

        void Create(OperationVM operation);
    }
}
