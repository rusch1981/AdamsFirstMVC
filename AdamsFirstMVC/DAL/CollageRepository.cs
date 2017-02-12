using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdamsFirstMVC.Models;
using System.Data.Entity;

namespace AdamsFirstMVC.DAL
{
    public class CollageRepository :ICollageRepository, IDisposable
    {
        private MandMContext context;

        public CollageRepository(MandMContext context)
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