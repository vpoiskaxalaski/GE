using GE.DAL.Model;
using GE.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GE.DAL.Repositories
{
    public class OperationRepository : IRepository<Operation>
    {
        private DatabaseContext db;

        public OperationRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(Operation item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            Operation item = db.Operations.Find(id);
            if (item != null)
                db.Operations.Remove(item);
        }

        public IEnumerable<Operation> Find(Func<Operation, bool> predicate)
        {
            return db.Operations.Where(predicate);
        }

        public Operation Get(int id)
        {
            Operation item = db.Operations.Find(id);
            return item;
        }

        public IEnumerable<Operation> GetAll()
        {
            return db.Operations;
        }

        public int GetCount()
        {
            return db.Operations.Count();
        }

        public void RemoveRange(IEnumerable<Operation> items)
        {
            throw new NotImplementedException();
        }

        public void Update(Operation item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}