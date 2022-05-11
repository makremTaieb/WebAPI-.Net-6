using WebAPI.Digital.API2.Abstraction;
using WebAPI.Digital.API2.Data;
using WebAPI.Digital.Domain;

namespace WebAPI.Digital.API2.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private readonly WebAPIDbContext _dbcontext;
        public GenericRepository(WebAPIDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public IEnumerable<T> GetAll()
        {
            return _dbcontext.Set<T>().Where(x => !x.IsDeleted);
            
        }

        public T GetByDigitalId(string DigitalId)
        {
            return _dbcontext.Set<T>().FirstOrDefault(x => x.DigitalId == DigitalId);
        }

        public T GetById(int id)
        {
            return _dbcontext.Set<T>().FirstOrDefault(x => x.Id == id);
        }


        public int Create(T entity)
        {
            var itemId = _dbcontext.Set<T>().Add(entity);
            _dbcontext.SaveChanges();
            return itemId.Entity.Id;
        }

        public void DeleteByDigitalId(string DigitalId)
        {
            var existingElement = _dbcontext.Set<T>().FirstOrDefault(x => x.DigitalId == DigitalId);
            if (existingElement != null)
            {
                existingElement.IsDeleted = true;
                _dbcontext.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update( T entity)
        {
            
            var existingElement = _dbcontext.Set<T>().FirstOrDefault(x => x.DigitalId == entity.DigitalId);
            if (existingElement != null && !existingElement.IsDeleted)
            {
                existingElement.UDate = DateTime.Now;
                existingElement.UUserId = entity.UUserId;
                _dbcontext.Set<T>().Update(existingElement);
                _dbcontext.SaveChanges();
            }
        }
    }
}
