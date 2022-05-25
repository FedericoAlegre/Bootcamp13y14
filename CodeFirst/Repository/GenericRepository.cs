using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly KioscoContext _context;
        private DbSet<T> _entity;
        public GenericRepository(KioscoContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entity.ToList();
        }
        public T GetByID(int id)
        {
            return _entity.Find(id);
        }
        public void Insert(T entity)
        {
            _entity.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _entity.Remove(entity);
        }

        public void Update(T entity)
        {
            _entity.Add(entity);
        }


    }

}