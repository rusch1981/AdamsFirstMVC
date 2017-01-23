using AdamsFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AdamsFirstMVC.DAL
{
    public class MandMRepository : IMandMRepository, IDisposable
    {
        private MandMContext context;

        public MandMRepository(MandMContext context)
        {
            this.context = context;
        }

        public IEnumerable<Collage> GetCollages()
        {
            return context.Collages.ToList();
        }
        public Collage GetCollageByName(string collageName)
        {
            return context.Collages.Find(collageName);
        }
        public Collage GetCollageByID(int collageID)
        {
            return context.Collages.Find(collageID);
        }
        public void InsertCollage(Collage collage)
        {
            context.Collages.Add(collage);
        }
        public void DeleteCollage(int collageID)
        {
            Collage collage = context.Collages.Find(collageID);
            context.Collages.Remove(collage);
        }
        public void UpdateCollage(Collage collage)
        {
            context.Entry(collage).State = EntityState.Modified;
        }

        public IEnumerable<ClickableArea> GetClickableAreas()
        {
            return context.ClickableAreas.ToList();
        }
        public ClickableArea GetClickableAreaByName(string clickableAreaName)
        {
            return context.ClickableAreas.Find(clickableAreaName);
        }
        public ClickableArea GetClickableAreaByID(int clickableAreaID)
        {
            return context.ClickableAreas.Find(clickableAreaID);
        }
        public void InsertClickableArea(ClickableArea clickableArea)
        {
            context.ClickableAreas.Add(clickableArea);
        }
        public void DeleteClickableArea(int clickableAreaID)
        {
            ClickableArea clickableArea = context.ClickableAreas.Find(clickableAreaID);
            context.ClickableAreas.Remove(clickableArea);
        }
        public void UpdateClickableArea(ClickableArea clickableArea)
        {
            context.Entry(clickableArea).State = EntityState.Modified;
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