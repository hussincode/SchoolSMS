namespace SchoolSMS.Genaric
{
    public interface IGenaricRepo<T> where T : class
    {
        public Task<T>GetById(int id);
        public Task<List<T> >GetAll();
        public Task Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);

    }
}
