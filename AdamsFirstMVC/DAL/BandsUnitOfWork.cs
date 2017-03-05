using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.DAL
{
    public class BandsUnitOfWork : IDisposable
    {
        private readonly MandMContext _context = new MandMContext();

        private IGenericRepository<BandImage> _bandImageRepository;

        private IGenericRepository<Collage> _collageRepository;

        private IGenericRepository<ClickableArea> _clickableAreaRepository;

        private IGenericRepository<Setup> _setupRepository;

        private IGenericRepository<BandImageSetup> _bandImageSetupRepository;
        

        public BandsUnitOfWork(IGenericRepository<BandImage> bandImageRepository = null,
            IGenericRepository<Collage> collageRepository = null, IGenericRepository<ClickableArea> clickableAreaRepository = null,
            IGenericRepository<Setup> setupRepository = null, IGenericRepository<BandImageSetup> bandImageSetupRepository = null)
        {
            this._bandImageRepository = bandImageRepository;

            this._collageRepository = collageRepository;

            this._clickableAreaRepository = clickableAreaRepository;

            this._setupRepository = setupRepository;

            this._bandImageSetupRepository = bandImageSetupRepository;
        }
           
        public IGenericRepository<BandImage> BandImageRepository
        {
            get
            {

                if (this._bandImageRepository == null)
                {
                    this._bandImageRepository = new GenericRepository<BandImage>(_context);
                }

                return _bandImageRepository;
            }
        }

        public IGenericRepository<Collage> CollageRepository
        {
            get
            {

                if (this._collageRepository == null)
                {
                    this._collageRepository = new GenericRepository<Collage>(_context);
                }

                return _collageRepository;
            }
        }

        public IGenericRepository<ClickableArea> ClickableAreaRepository
        {
            get
            {

                if (this._clickableAreaRepository == null)
                {
                    this._clickableAreaRepository = new GenericRepository<ClickableArea>(_context);
                }

                return _clickableAreaRepository;
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

        public IGenericRepository<BandImageSetup> BandImageSetupRepository
        {
            get
            {

                if (this._bandImageSetupRepository == null)
                {
                    this._bandImageSetupRepository = new GenericRepository<BandImageSetup>(_context);
                }

                return _bandImageSetupRepository;
            }
        }

        public List<BandImage> GetBandImagesfromSetup()
        {
            var setupId = GetMainSetup().SetupId;

            var bandImageSetups = BandImageSetupRepository.Get(setup => setup.SetupId == setupId).ToList();

            var bandImageIds = bandImageSetups.Select(setup => setup.BandImageId).ToList();

            return bandImageIds.Select(id => BandImageRepository.GetByID(id)).ToList();
        }

        private Setup GetMainSetup()
        {
            return SetupRepository.Get(setup => setup.IsCurrentSetUp).ToList().First();
        }

        public Collage GetSetupCollage()
        {
            return CollageRepository.GetByID(GetMainSetup().CollageId);
        }

        public List<ClickableArea> GetSetupClickableAreas()
        {
            var collageId = GetSetupCollage().CollageId;
            return ClickableAreaRepository.Get(clickableArea => clickableArea.CollageId == collageId).ToList();
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