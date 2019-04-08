using GE.DAL.Model;
using GE.RL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.RL.Repositories
{
    public class LotRepository : IRepository<Lot>
    {
        private DatabaseContext db;

        public LotRepository(DatabaseContext context)
        {
            this.db = context;
        }

        public IEnumerable<Lot> GetAll()
        {
            return db.Lots;
        }

        public Lot Get(int id)
        {
            return db.Lots.Find(id);
        }

        public void Create(Lot lot)
        {
            db.Lots.Add(lot);
        }

        public void Update(Lot lot)
        {
            db.Entry(lot).State = EntityState.Modified;
        }

        public IEnumerable<Lot> Find(Func<Lot, Boolean> predicate)
        {
            return db.Lots.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Lot lot  = db.Lots.Find(id);
            if (lot != null)
                db.Lots.Remove(lot);
        }
    }
}
