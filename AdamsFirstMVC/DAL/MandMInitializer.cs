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
                new Collage {Name="Example1024WithAreas", ImagePath="../../images/Example1024WithAreas.png" }
            };

            Collages.ForEach(s => context.Collages.Add(s));
            context.SaveChanges();
            var ClickableAreas = new List<ClickableArea>
            {
                new ClickableArea {CollageID=1, ClickableAreaName="Google", Coordinates="87,114,244,202", URL="http://www.google.com"},
                new ClickableArea {CollageID=1, ClickableAreaName="Yahoo", Coordinates="318,219,544,366", URL="http://www.yahoo.com"},
                new ClickableArea {CollageID=1, ClickableAreaName="Hotmail", Coordinates="117,474,306,575", URL="http://www.hotmail.com"},
                new ClickableArea {CollageID=1, ClickableAreaName="gmail", Coordinates="595,493,866,630", URL="http://www.gmail.com"}
            };
            ClickableAreas.ForEach(s => context.ClickableAreas.Add(s));
            context.SaveChanges();
        }
    }
}