using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.DAL
{
    public class DJUnitOfWork : IDisposable
    {
        private readonly MandMContext _context = new MandMContext();
        
        private IGenericRepository<Setup> _setupRepository;
        private IGenericRepository<DJImage> _DJImageRepository;
        private IGenericRepository<DJImageSetup> _DJImageSetupRepository;


        public DJUnitOfWork(IGenericRepository<DJImage> DJImageRepository = null,
            IGenericRepository<DJImageSetup> DJImageSetupRepository = null, 
            IGenericRepository<Setup> setupRepository = null)
        {
            this._DJImageRepository = DJImageRepository;

            this._DJImageSetupRepository = DJImageSetupRepository;

            this._setupRepository = setupRepository;
        }
           
        public IGenericRepository<DJImage> DJImageRepository
        {
            get
            {

                if (this._DJImageRepository == null)
                {
                    this._DJImageRepository = new GenericRepository<DJImage>(_context);
                }

                return _DJImageRepository;
            }
        }

        public IGenericRepository<DJImageSetup> DJImageSetupRepository
        {
            get
            {

                if (this._DJImageSetupRepository == null)
                {
                    this._DJImageSetupRepository = new GenericRepository<DJImageSetup>(_context);
                }

                return _DJImageSetupRepository;
            }
        }

        public IGenericRepository<Setup> SetupRepository
        {
            get
            {

                if (this._setupRepository == null)
                {
                    this._setupRepository = new GenericRepository<Setup>(_context);
                }

                return _setupRepository;
            }
        }

        public List<DJImage> GetDJImagesfromSetup()
        {
            var setupId = GetMainSetup().SetupId;

            var dJImageSetups = DJImageSetupRepository.Get(setup => setup.SetupId == setupId).ToList();

            var dJImageIds = dJImageSetups.Select(setup => setup.DJImageId).ToList();

            return dJImageIds.Select(id => DJImageRepository.GetByID(id)).ToList();
        }

        private Setup GetMainSetup()
        {
            return SetupRepository.Get(setup => setup.IsCurrentSetUp).ToList().First();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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