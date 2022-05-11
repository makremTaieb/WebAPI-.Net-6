using Digital.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital.Core
{
    public interface IRepository<T> where T : BaseEntity<int>
    {
        IQueryable<T> GetAll(params string[] param);

        T GetById(int id, params string[] param);

        void Insert(T entity); 

        void Update(T entity);

        void Delete(T entity);

        void Save();

    }
}
