using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.DAL
{
    public class UnitOfWork : IDisposable
    {
        private MandMContext context = new MandMContext();
        private GenericRepository<BandImage> bandImageRepository;
        private GenericRepository<Collage> collageRepository;
        private GenericRepository<ClickableArea> clickableAreaRepository;

        public GenericRepository<BandImage> BandImageRepository
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

        public GenericRepository<Collage> CollageRepository
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

        public GenericRepository<ClickableArea> ClickableAreaRepository
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