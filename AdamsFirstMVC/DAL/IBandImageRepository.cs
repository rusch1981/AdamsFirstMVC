using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.DAL
{
    interface IBandImageRepository: IDisposable
    {
        IEnumerable<BandImage> GetBandImages();
        BandImage GetBandImageByName(string bandImageName);
        BandImage GetBandImageByID(int bandImageID);
        void InsertBandImage(BandImage bandImage);
        void DeleteBandImage(int bandImageID);
        void UpdateBandImage(BandImage bandImage);

        void Save();
    }
}
