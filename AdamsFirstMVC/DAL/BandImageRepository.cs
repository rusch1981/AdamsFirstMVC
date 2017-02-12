using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdamsFirstMVC.Models;
using System.Data.Entity;

namespace AdamsFirstMVC.DAL
{
    public class BandImageRepository: IBandImageRepository, IDisposable
    {
        private MandMContext context;

        public BandImageRepository(MandMContext context)
        {
            this.context = context;
        }

        public IEnumerable<BandImage> GetBandImages()
        {
            return context.BandImages.ToList();
        }
        public BandImage GetBandImageByName(string bandImageName)
        {
            return context.BandImages.Find(bandImageName);
        }
        public BandImage GetBandImageByID(int bandImageID)
        {
            return context.BandImages.Find(bandImageID);
        }
        public void InsertBandImage(BandImage bandImage)
        {
            context.BandImages.Add(bandImage);
        }
        public void DeleteBandImage(int bandImageID)
        {
            BandImage bandImage = context.BandImages.Find(bandImageID);
            context.BandImages.Remove(bandImage);
        }
        public void UpdateBandImage(BandImage bandImage)
        {
            context.Entry(bandImage).State = EntityState.Modified;
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