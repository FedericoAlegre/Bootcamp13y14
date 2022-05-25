using CodeFirst.Models;
using CodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.UnitOfWorkRepository
{
    public class UnitOfWork : IDisposable
    {
        private KioscoContext context = new KioscoContext();
        private GenericRepository<Producto> productRepository;
        private GenericRepository<Categoria> catRepository;

        public GenericRepository<Producto> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Producto>(context);
                }
                return productRepository;
            }
        }

        public GenericRepository<Categoria> CatRepository
        {
            get
            {

                if (this.catRepository == null)
                {
                    this.catRepository = new GenericRepository<Categoria>(context);
                }
                return catRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}