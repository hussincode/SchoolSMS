
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic;
using SchoolSMS.Data;

namespace SchoolSMS.Genaric
{
    public class GenaricRepo<T> : IGenaricRepo<T> where T : class
    {
        private readonly AppDBContext context;
        public GenaricRepo(AppDBContext context)
        {
            this.context = context;
        }
        public async Task Add(T entity)
        {
           await context.Set<T>().AddAsync(entity); 
        }

        public  void Delete(T entity)
        {
             context.Set<T>().Remove(entity);
        }

        public async Task<List<T> >GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T>GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void  Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}
