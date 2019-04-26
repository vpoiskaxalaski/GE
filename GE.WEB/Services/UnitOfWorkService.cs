using GE.RL.Interfaces;
using GE.RL.Repositories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GE.WEB.Services
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class UnitOfWorkService 
    {
        private IUnitOfWork _unitOfWork;

        public IUnitOfWork GetUnitOfWork()
        {
            IKernel ninjectKernel = new StandardKernel();
            DbConnection dbConnection = new DbConnection("MyConnection");

            ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(dbConnection.GetOptions());
            _unitOfWork = ninjectKernel.Get<IUnitOfWork>();

            return _unitOfWork;
        }

        public void InitializeDatabase()
        {
            _unitOfWork.CategoriesInit();
        }
    }
}
