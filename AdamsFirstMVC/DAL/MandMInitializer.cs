using AdamsFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.DAL
{
    public class MandMInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MandMContext>
    {
        protected override void Seed(MandMContext context)
        {
            var Collages = new List<Collage>
            {
                new Collage {CollageName="Example1024WithAreas", CollageSrc="../../images/Example1024WithAreas.png", CollageAlt="Collage of Bands"}
            };
            Collages.ForEach(s => context.Collages.Add(s));
            context.SaveChanges();

            var ClickableAreas = new List<ClickableArea>
            {
                new ClickableArea {CollageID=1, ClickableAreaName="Google", ClickableAreaCoordinates="87,114,244,202", ClickableAreaHref="http://www.google.com",ClickableAreaShape="rect",ClickableAreaAlt="Google.com"},
                new ClickableArea {CollageID=1, ClickableAreaName="Yahoo", ClickableAreaCoordinates="318,219,544,366", ClickableAreaHref="http://www.yahoo.com",ClickableAreaShape="rect",ClickableAreaAlt="Yahoo.com"},
                new ClickableArea {CollageID=1, ClickableAreaName="Hotmail", ClickableAreaCoordinates="117,474,306,575", ClickableAreaHref="http://www.hotmail.com",ClickableAreaShape="rect",ClickableAreaAlt="Hotmail.com"},
                new ClickableArea {CollageID=1, ClickableAreaName="gmail", ClickableAreaCoordinates="595,493,866,630", ClickableAreaHref="http://www.gmail.com",ClickableAreaShape="rect",ClickableAreaAlt="Gmail.com"}
            };
            ClickableAreas.ForEach(s => context.ClickableAreas.Add(s));
            context.SaveChanges();

            var BandImage = new List<BandImage>
            {
                new BandImage { BandImageName= "Acoustic Saints", BandImageSrc= "../../images/13730988_211766675887877_986217828283931809_o.jpg", BandImageAlt= "Acoustic Saints", BandHref= "http://goggle.com"},
                new BandImage { BandImageName= "Ellwood City Band", BandImageSrc= "../../images/Ellwood2.jpg", BandImageAlt= "Ellwood City Band", BandHref= "http://www.yahoo.com"},
                new BandImage { BandImageName= "Game Face", BandImageSrc= "../../images/13668737_1230873603623735_8560807734309575763_o.jpg", BandImageAlt= "Game Face", BandHref= "http://www.hotmail.com"}
            };
            BandImage.ForEach(s => context.BandImages.Add(s));
            context.SaveChanges();
        }
    }
}