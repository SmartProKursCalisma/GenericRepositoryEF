using GenericRepositoryEF.Entities.Entities;
using GenericRepositoryEF.Repository.Abstract;
using GenericRepositoryEF.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryEF.Repository.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T:class , IBaseEntity,new()
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();  
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Add(T entity)
        {
           _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
       

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
