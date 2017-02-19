using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.DAL
{
    public class AboutUnitOfWork : IDisposable
    {
        private MandMContext context = new MandMContext();
        private IGenericRepository<AboutMandM> aboutMandMRepository;
        private IGenericRepository<Setup> setupRepository;        

        public AboutUnitOfWork(IGenericRepository<AboutMandM> aboutMandMRepository = null,
            IGenericRepository<Setup> setupRepository = null)
        {
            this.aboutMandMRepository = aboutMandMRepository;
            this.setupRepository = setupRepository;
        }
           
        
        public IGenericRepository<AboutMandM> AboutMandMRepository
        {
            get
            {

                if (this.aboutMandMRepository == null)
                {
                    this.aboutMandMRepository = new GenericRepository<AboutMandM>(context);
                }
                return AboutMandMRepository;
            }
        }

        public IGenericRepository<Setup> SetupRepository
        {
            get
            {

                if (this.setupRepository == null)
                {
                    this.setupRepository = new GenericRepository<Setup>(context);
                }
                return setupRepository;
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