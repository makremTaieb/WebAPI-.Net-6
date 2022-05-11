namespace WebAPI.Digital.API2.Abstraction
{
    public interface IGenericRepository<T>
    {
        public T GetById(int id);
        public T GetByDigitalId(string DigitalId);
        public IEnumerable<T> GetAll();
        public int Create(T entity);
        public void Update(T entity);
        public void DeleteById(int id);
        public void DeleteByDigitalId(string DigitalId);
    }
}
