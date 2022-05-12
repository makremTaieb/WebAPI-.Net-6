using Digital.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital.Core
{
    public class Repository<T> : IRepository<T> where T : BaseEntity<int>
    {
        private readonly DigitalDbContextBase _db;

        public Repository(DigitalDbContextBase db)
        {
            _db = db;
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);
        }

        public IQueryable<T> GetAll(params string[] param)
        {
            IQueryable<T> set = _db.Set<T>().Where(x => !x.IsDeleted);

            foreach (var item in param)
            {
                set = set.Include(item);
            }

            return set;
        }

        public T GetById(int id, params string[] param)
        {
            return GetAll(param).FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity.IsDeleted)
                throw new Exception("Erreur d'intégrité des données");
            _db.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            if (entity.IsDeleted)
                throw new Exception("Erreur d'intégrité des données");
            _db.Set<T>().Update(entity);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
