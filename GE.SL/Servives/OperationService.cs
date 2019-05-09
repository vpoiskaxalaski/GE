using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.SL.Servives
{
    public class OperationService : IOperationService
    {
        private IUnitOfWork _unitOfWork;

        public OperationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(OperationVM operation)
        {
            _unitOfWork.Operations.Create(new Operation { Spent = operation.Spent, UserId = operation.UserId, Earned = operation.Earned, Date = operation.Date });
            _unitOfWork.Save();
        }

        public List<OperationVM> GetAll()
        {
            List<OperationVM> operationsVM = new List<OperationVM>();
            IEnumerable<Operation> operations = _unitOfWork.Operations.GetAll();

            foreach (Operation operation in operations)
            {
                operationsVM.Add(new OperationVM {  Id = operation.Id, Date = operation.Date, Earned = operation.Earned, UserId = operation.UserId, Spent = operation.Spent });
            }

            return operationsVM;
        }
    }
}
