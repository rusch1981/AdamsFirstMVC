using AdamsFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsFirstMVC.DAL
{
    interface IMandMRepository : IDisposable
    {
        IEnumerable<Collage> GetCollage();
        Collage GetCollageByName(string collageName);
        Collage GetCollageByID(int collageID);
        void InsertCollage(Collage collage);
        void DeleteCollage(int collageID);
        void UpdateCollage(Collage collage);

        IEnumerable<ClickableArea> GetClickableArea();
        ClickableArea GetClickableAreaByName(string clickableAreaName);
        ClickableArea GetClickableAreaByID(int clickableAreaID);
        void InsertClickableArea(ClickableArea clickableArea);
        void DeleteClickableArea(int clickableAreaID);
        void UpdateClickableArea(ClickableArea clickableArea);

        IEnumerable<BandImage> GetBandImage();
        BandImage GetBandImageByName(string bandImageName);
        BandImage GetBandImageByID(int bandImageID);
        void InsertBandImage(BandImage bandImage);
        void DeleteBandImage(int bandImageID);
        void UpdateBandImage(BandImage bandImage);

        void Save();
    }
}
