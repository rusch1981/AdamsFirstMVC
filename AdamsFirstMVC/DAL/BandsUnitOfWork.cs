using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.DAL
{
    public class BandsUnitOfWork : IDisposable
    {
        private MandMContext context = new MandMContext();
        private IGenericRepository<BandImage> bandImageRepository;
        private IGenericRepository<Collage> collageRepository;
        private IGenericRepository<ClickableArea> clickableAreaRepository;
        private IGenericRepository<Setup> SetupRepository;
        private IGenericRepository<BandImageSetup> BandImageSetupRepository;
        

        public BandsUnitOfWork(IGenericRepository<BandImage> bandImageRepository = null,
            IGenericRepository<Collage> collageRepository = null, IGenericRepository<ClickableArea> clickableAreaRepository = null,
            IGenericRepository<Setup> SetupRepository = null, IGenericRepository<BandImageSetup> BandImageSetupRepository = null)
        {
            this.bandImageRepository = bandImageRepository;
            this.collageRepository = collageRepository;
            this.clickableAreaRepository = clickableAreaRepository;
            this.SetupRepository = SetupRepository;
            this.BandImageSetupRepository = BandImageSetupRepository;
        }
           
        public IGenericRepository<BandImage> BandImageRepository
        {
            get
            {

                if (this.bandImageRepository == null)
                {
                    this.bandImageRepository = new GenericRepository<BandImage>(context);
                }
                return bandImageRepository;
            }
        }

        public IGenericRepository<Collage> CollageRepository
        {
            get
            {

                if (this.collageRepository == null)
                {
                    this.collageRepository = new GenericRepository<Collage>(context);
                }
                return collageRepository;
            }
        }

        public IGenericRepository<ClickableArea> ClickableAreaRepository
        {
            get
            {

                if (this.clickableAreaRepository == null)
                {
                    this.clickableAreaRepository = new GenericRepository<ClickableArea>(context);
                }
                return clickableAreaRepository;
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