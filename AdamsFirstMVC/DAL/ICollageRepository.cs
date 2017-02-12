using AdamsFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.DAL
{
    interface ICollageRepository : IDisposable
    {
        IEnumerable<Collage> GetCollages();
        Collage GetCollageByName(string collageName);
        Collage GetCollageByID(int collageID);
        void InsertCollage(Collage collage);
        void DeleteCollage(int collageID);
        void UpdateCollage(Collage collage);

        void Save();
    }
}