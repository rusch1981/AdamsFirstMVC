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
        private IGenericRepository<AboutMandM> _aboutMandMRepository;
        private IGenericRepository<Setup> _setupRepository;
        private IGenericRepository<AboutMandMSetup> _aboutMandMSetupRepository;

        public AboutUnitOfWork(IGenericRepository<AboutMandM> aboutMandMRepository = null,
            IGenericRepository<Setup> setupRepository = null)
        {
            this._aboutMandMRepository = aboutMandMRepository;
            this._setupRepository = setupRepository;
        }
           
        
        public IGenericRepository<AboutMandM> AboutMandMRepository
        {
            get
            {
                if (this._aboutMandMRepository == null)
                {
                    this._aboutMandMRepository = new GenericRepository<AboutMandM>(context);
                }
                return _aboutMandMRepository;
            }
        }

        public IGenericRepository<Setup> SetupRepository
        {
            get
            {

                if (this._setupRepository == null)
                {
                    this._setupRepository = new GenericRepository<Setup>(context);
                }
                return _setupRepository;
            }
        }

        public IGenericRepository<AboutMandMSetup> AboutMandMSetupRepository
        {
            get
            {

                if (this._aboutMandMSetupRepository == null)
                {
                    this._aboutMandMSetupRepository = new GenericRepository<AboutMandMSetup>(context);
                }
                return _aboutMandMSetupRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}