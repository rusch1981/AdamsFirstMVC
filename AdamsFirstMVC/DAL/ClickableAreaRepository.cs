using AdamsFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.DAL
{
    public class ClickableAreaRepository: IClickableAreaRepository, IDisposable
    {
        private MandMContext context;

        public ClickableAreaRepository(MandMContext context)
        {
            this.context = context;
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