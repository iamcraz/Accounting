using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Datalayer.Services
{
    public class GenericRepository<Tentity>where Tentity:class
    {
        private Accounting_DBEntities _db;
        private DbSet<Tentity> _dbset;

        public GenericRepository(Accounting_DBEntities db)
        {

            _db = db;
            _dbset = db.Set<Tentity>();

        }

        public virtual IEnumerable<Tentity> getall(Expression<Func<Tentity,bool>>where=null)
        {
            IQueryable<Tentity> query = _dbset;
            
            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }

        public virtual Tentity GetById (object id)
        {
            return _dbset.Find(id);
            
        }
        

        public virtual void Insert(Tentity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update (Tentity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void delete(Tentity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }

            _dbset.Remove(entity);
        }

        public virtual void delete(object id)
        {
            var entity=_dbset.Find(id);
            
            _dbset.Remove(entity);
        }
    }
}
