using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.DAL
{
    public class AboutUnitOfWork : IDisposable
    {
        private readonly MandMContext _context = new MandMContext();

        private IGenericRepository<AboutMandM> _aboutMandMRepository;

        private IGenericRepository<Setup> _setupRepository;

        private IGenericRepository<AboutMandMSetup> _aboutMandMSetupRepository;

        public AboutUnitOfWork(IGenericRepository<AboutMandM> aboutMandMRepository = null,
            IGenericRepository<Setup> setupRepository = null, IGenericRepository<AboutMandMSetup> aboutMandMSetupRepository = null)
        {
            this._aboutMandMRepository = aboutMandMRepository;

            this._setupRepository = setupRepository;

            this._aboutMandMSetupRepository = aboutMandMSetupRepository;
        }
           
        
        public IGenericRepository<AboutMandM> AboutMandMRepository
        {
            get
            {
                if (this._aboutMandMRepository == null)
                {
                    this._aboutMandMRepository = new GenericRepository<AboutMandM>(_context);
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
                    this._setupRepository = new GenericRepository<Setup>(_context);
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
                    this._aboutMandMSetupRepository = new GenericRepository<AboutMandMSetup>(_context);
                }
                return _aboutMandMSetupRepository;
            }
        }

        public List<AboutMandM> GetAboutContentsfromSetup()
        {
            var setupId = GetMainSetup().SetupId;

            var aboutContentSetups = AboutMandMSetupRepository.Get(setup => setup.SetupId == setupId).ToList();

            var aboutContentIds = aboutContentSetups.Select(setup => setup.AboutMandMId).ToList();

            return aboutContentIds.Select(id => AboutMandMRepository.GetByID(id)).ToList();
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