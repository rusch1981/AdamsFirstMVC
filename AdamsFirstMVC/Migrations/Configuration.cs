using System.Collections.Generic;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdamsFirstMVC.DAL.MandMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdamsFirstMVC.DAL.MandMContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var collages = new List<Collage>
            {
                new Collage {CollageName="largebanddisplayupdateJune2017", CollageSrc="../../images/largebanddisplayupdateJune2017.png", CollageAlt="Collage of Bands"}
            };

            collages.ForEach(s => context.Collages.AddOrUpdate(p => p.CollageName, s));

            context.SaveChanges();

            var setup = new List<Setup>
            {
                new Setup {IsCurrentSetUp = true, SetupDate = DateTime.Today, CollageId=1, SetupName="Test"}
            };

            setup.ForEach(s => context.Setups.AddOrUpdate(p => p.SetupName, s));

            context.SaveChanges();

            var clickableAreas = new List<ClickableArea>
            {
                new ClickableArea {CollageId=1, ClickableAreaName="Game Face", ClickableAreaCoordinates="60,12,581,242", ClickableAreaHref="https://www.facebook.com/gameface4u/0",ClickableAreaShape="rect",ClickableAreaAlt="Game Face",BandToolTip = "Game Face"},
                new ClickableArea {CollageId=1, ClickableAreaName="Shannon Lee", ClickableAreaCoordinates="699,1,988,313", ClickableAreaHref="http://www.simplyshannon.net/",ClickableAreaShape="rect",ClickableAreaAlt="Shannon Lee",BandToolTip = "Shannon Lee"},
                new ClickableArea {CollageId=1, ClickableAreaName="The Wingnuts", ClickableAreaCoordinates="1020,9,1501,206", ClickableAreaHref="https://www.facebook.com/The-Wingnuts-335327236591252/",ClickableAreaShape="rect",ClickableAreaAlt="The Wingnuts",BandToolTip = "The Wingnuts"},
                new ClickableArea {CollageId=1, ClickableAreaName="Acoustic Saints", ClickableAreaCoordinates="1603,14,1883,241", ClickableAreaHref="https://www.facebook.com/AcousticSaintsRock/?ref=br_rs",ClickableAreaShape="rect",ClickableAreaAlt="Acoustic Saints",BandToolTip = "Acoustic Saints"},
                new ClickableArea {CollageId=1, ClickableAreaName="Sticks and Stones", ClickableAreaCoordinates="17,277,325,563", ClickableAreaHref="https://www.facebook.com/SticksAndStonesNC/",ClickableAreaShape="rect",ClickableAreaAlt="Sticks and Stones",BandToolTip = "Sticks and Stones"},
                new ClickableArea {CollageId=1, ClickableAreaName="Horsefly", ClickableAreaCoordinates="373,289,631,556", ClickableAreaHref="https://www.reverbnation.com/horseflyblues",ClickableAreaShape="rect",ClickableAreaAlt="Horsefly",BandToolTip = "Horsefly"},
                new ClickableArea {CollageId=1, ClickableAreaName="Mitch Hayes", ClickableAreaCoordinates="666,325,1054,564", ClickableAreaHref="http://www.mitchhayesmusic.com/",ClickableAreaShape="rect",ClickableAreaAlt="Mitch Hayes",BandToolTip = "Mitch Hayes"},
                new ClickableArea {CollageId=1, ClickableAreaName="Remedy Hollow", ClickableAreaCoordinates="1160,232,1570,438", ClickableAreaHref="https://www.facebook.com/remedyhollow/",ClickableAreaShape="rect",ClickableAreaAlt="Remedy Hollow",BandToolTip = "Remedy Hollow"},
                new ClickableArea {CollageId=1, ClickableAreaName="Grievous Angels", ClickableAreaCoordinates="1155,449,1498,617", ClickableAreaHref="https://www.facebook.com/grievousangelsband/",ClickableAreaShape="rect",ClickableAreaAlt="Grievous Angels",BandToolTip = "Grievous Angels"},
                new ClickableArea {CollageId=1, ClickableAreaName="Carolina Rhythm Band", ClickableAreaCoordinates="1629,317,1886,611", ClickableAreaHref="https://www.carolinarhythmband.com/",ClickableAreaShape="rect",ClickableAreaAlt="Carolina Rhythm Band",BandToolTip = "Carolina Rhythm Band"},
                new ClickableArea {CollageId=1, ClickableAreaName="Standing Room Only", ClickableAreaCoordinates="118,607,594,802", ClickableAreaHref="https://www.facebook.com/SRO2015/",ClickableAreaShape="rect",ClickableAreaAlt="Standing Room Only",BandToolTip = "Standing Room Only"},
                new ClickableArea {CollageId=1, ClickableAreaName="Rachel's Ransom", ClickableAreaCoordinates="771,609,1207,774", ClickableAreaHref="https://www.facebook.com/rachelsransom/",ClickableAreaShape="rect",ClickableAreaAlt="Rachel's Ransom",BandToolTip = "Rachel's Ransom"},
                new ClickableArea {CollageId=1, ClickableAreaName="Khaos Kings", ClickableAreaCoordinates="1264,649,1871,772", ClickableAreaHref="https://www.facebook.com/KhaoskingsSC/?ref=br_rs",ClickableAreaShape="rect",ClickableAreaAlt="Khaos Kings",BandToolTip = "Khaos Kings"},
                new ClickableArea {CollageId=1, ClickableAreaName="Ellwood City Band", ClickableAreaCoordinates="35,830,558,1055", ClickableAreaHref="https://www.facebook.com/Ellwood-City-Band-1019490414809599/",ClickableAreaShape="rect",ClickableAreaAlt="Ellwood City Band",BandToolTip = "Ellwood City Band"},
                new ClickableArea {CollageId=1, ClickableAreaName="Catawba River Monster", ClickableAreaCoordinates="622,803,983,1072", ClickableAreaHref="http://www.catawbarivermonster.com/",ClickableAreaShape="rect",ClickableAreaAlt="Catawba River Monster",BandToolTip = "Catawba River Monster"},
                new ClickableArea {CollageId=1, ClickableAreaName="Jody and Joanna", ClickableAreaCoordinates="1061,811,1431,1055", ClickableAreaHref="https://www.facebook.com/jodyedwardsmusic1/",ClickableAreaShape="rect",ClickableAreaAlt="Jody and Joanna",BandToolTip = "Jody and Joanna"},
                new ClickableArea {CollageId=1, ClickableAreaName="House of Payne", ClickableAreaCoordinates="1548,808,1873,1069", ClickableAreaHref="https://www.facebook.com/Unofficial-house-of-payne-band-1671711236449993/",ClickableAreaShape="rect",ClickableAreaAlt="House of Payne",BandToolTip = "House of Payne"},
            };

            clickableAreas.ForEach(s => context.ClickableAreas.AddOrUpdate(p => p.ClickableAreaName, s));

            context.SaveChanges();

            var bandImage = new List<BandImage>
            {
                new BandImage { BandImageName= "Acoustic Saints", BandImageSrc= "../../images/AcousticSaints.png", BandImageAlt= "Acoustic Saints", BandHref= "https://www.facebook.com/AcousticSaintsRock/?ref=br_rs", BandToolTip = "Acoustic Saints"},
                new BandImage { BandImageName= "Carolina Rhythm Band", BandImageSrc= "../../images/CarolinaRhythmBand.png", BandImageAlt= "Carolina Rhythm Band", BandHref= "https://www.carolinarhythmband.com/", BandToolTip = "Carolina Rhythm Band"},
                new BandImage { BandImageName= "Catawba River Monster", BandImageSrc= "../../images/CatawbaRiverMonster.png", BandImageAlt= "Catawba River Monster", BandHref= "http://www.catawbarivermonster.com/", BandToolTip = "Catawba River Monster"},
                new BandImage { BandImageName= "Ellwood City Band", BandImageSrc= "../../images/Ellwood.jpg", BandImageAlt= "Ellwood City Band", BandHref= "https://www.facebook.com/Ellwood-City-Band-1019490414809599/", BandToolTip = "Ellwood City Band"},
                new BandImage { BandImageName= "Game Face", BandImageSrc= "../../images/GameFace321.png", BandImageAlt= "Game Face", BandHref= "https://www.facebook.com/gameface4u/0", BandToolTip = "Game Face"},
                new BandImage { BandImageName= "Grievous Angels", BandImageSrc= "../../images/GrievousAngels.png", BandImageAlt= "Grievous Angels", BandHref= "https://www.facebook.com/grievousangelsband/", BandToolTip = "Grievous Angels"},
                new BandImage { BandImageName= "Horsefly", BandImageSrc= "../../images/horseflylogo.png", BandImageAlt= "Horsefly", BandHref= "https://www.reverbnation.com/horseflyblues", BandToolTip = "Horsefly"},
                new BandImage { BandImageName= "House of Payne", BandImageSrc= "../../images/HouseOfPayne.png", BandImageAlt= "House of Payne", BandHref= "https://www.facebook.com/Unofficial-house-of-payne-band-1671711236449993/", BandToolTip = "House of Payne"},
                new BandImage { BandImageName= "Jody and Joanna", BandImageSrc= "../../images/JodyandJoanna.png", BandImageAlt= "Jody and Joanna", BandHref= "https://www.facebook.com/jodyedwardsmusic1/", BandToolTip = "Jody and Joanna"},
                new BandImage { BandImageName= "Khaos Kings", BandImageSrc= "../../images/KhaosKings.png", BandImageAlt= "Khaos Kings", BandHref= "https://www.facebook.com/KhaoskingsSC/?ref=br_rs", BandToolTip = "Khaos Kings"},
                new BandImage { BandImageName= "Mitch Hayes", BandImageSrc= "../../images/MitchHayes.png", BandImageAlt= "Mitch Hayes", BandHref= "http://www.mitchhayesmusic.com/", BandToolTip = "Mitch Hayes"},
                new BandImage { BandImageName= "Rachel's Ransom", BandImageSrc= "../../images/RachelsRansom.png", BandImageAlt= "Rachel's Ransom", BandHref= "https://www.facebook.com/rachelsransom/", BandToolTip = "Rachel's Ransom"},
                new BandImage { BandImageName= "Remedy Hollow", BandImageSrc= "../../images/RemedyHollow321.png", BandImageAlt= "Remedy Hollow", BandHref= "https://www.facebook.com/remedyhollow/", BandToolTip = "Remedy Hollow"},
                new BandImage { BandImageName= "Shannon Lee", BandImageSrc= "../../images/ShannonLee.png", BandImageAlt= "Shannon Lee", BandHref= "http://www.simplyshannon.net/", BandToolTip = "Shannon Lee"},
                new BandImage { BandImageName= "Standing Room Only", BandImageSrc= "../../images/StandingRoomOnly.png", BandImageAlt= "Standing Room Only", BandHref= "https://www.facebook.com/SRO2015/", BandToolTip = "Standing Room Only"},
                new BandImage { BandImageName= "Sticks and Stones", BandImageSrc= "../../images/SticksStones.png", BandImageAlt= "Sticks and Stones", BandHref= "https://www.facebook.com/SticksAndStonesNC/", BandToolTip = "Sticks and Stones"},
                new BandImage { BandImageName= "The Wingnuts", BandImageSrc= "../../images/Wingnuts.png", BandImageAlt= "The Wingnuts", BandHref= "https://www.facebook.com/The-Wingnuts-335327236591252/", BandToolTip = "The Wingnuts"},
            };

            bandImage.ForEach(s => context.BandImages.AddOrUpdate(p => p.BandImageName, s));

            context.SaveChanges();

            var bandImageSetup = new List<BandImageSetup>
            {
                new BandImageSetup {SetupId = 1, BandImageId=1},
                new BandImageSetup {SetupId = 1, BandImageId=2},
                new BandImageSetup {SetupId = 1, BandImageId=3},
                new BandImageSetup {SetupId = 1, BandImageId=4},
                new BandImageSetup {SetupId = 1, BandImageId=5},
                new BandImageSetup {SetupId = 1, BandImageId=6},
                new BandImageSetup {SetupId = 1, BandImageId=7},
                new BandImageSetup {SetupId = 1, BandImageId=8},
                new BandImageSetup {SetupId = 1, BandImageId=9},
                new BandImageSetup {SetupId = 1, BandImageId=10},
                new BandImageSetup {SetupId = 1, BandImageId=11},
                new BandImageSetup {SetupId = 1, BandImageId=12},
                new BandImageSetup {SetupId = 1, BandImageId=13},
                new BandImageSetup {SetupId = 1, BandImageId=14},
                new BandImageSetup {SetupId = 1, BandImageId=15},
                new BandImageSetup {SetupId = 1, BandImageId=16},
                new BandImageSetup {SetupId = 1, BandImageId=17},
            };

            bandImageSetup.ForEach(s => context.BandImageSetups.AddOrUpdate(p => p.BandImageId, s));

            context.SaveChanges();

            var aboutMandM = new List<AboutMandM>
            {
                new AboutMandM {HeadingH1 ="", HeadingH2="M&M Productions is an event planning company that specializes in organizing charity events. "
                + "M&M Productions also supports, promotes and believes in local music and local musicians. <br/> <br/>"
                + "We serve as a part time booking agent for several popular and incredibly talented local artists. "
                + "The money made goes directly into funding the cost of organizing the charity events we host. "
                +" This is how we make a difference making music. <br/> <br/>"
                + "Our charity events always feature local musicians who generously donate their time and talent to help "
                + "worthy causes.", HeadingH3=""}
            };

            aboutMandM.ForEach(s => context.AboutMandM.AddOrUpdate(p => p.HeadingH2, s));

            context.SaveChanges();

            var aboutMandMSetup = new List<AboutMandMSetup>
            {
                new AboutMandMSetup {SetupId = 1, AboutMandMId=1}
            };

            aboutMandMSetup.ForEach(s => context.AboutMandMSetups.AddOrUpdate(p => p.AboutMandMId, s));

            context.SaveChanges();

            var dJImage = new List<DJImage>
            {
                new DJImage {DJImageName = "DJ Nixxx", DJImageSrc = "../../images/DJNixxx.png", DJImageAlt = "DJ Nixxx", DJHref = "https://www.facebook.com/letmebeyourdj/", DJToolTip = "DJ Nixxx"},
                new DJImage {DJImageName = "Juke Box Junkie", DJImageSrc = "../../images/JukeboxJunkie.png", DJImageAlt = "Juke Box Junkie", DJHref = "https://www.facebook.com/JukeBoxJunkieDJ/", DJToolTip = "Juke Box Junkie"}

            };

            dJImage.ForEach(s => context.DJImages.AddOrUpdate(p => p.DJImageName, s));

            context.SaveChanges();

            var dJImageSetup = new List<DJImageSetup>
            {
                new DJImageSetup {DJImageId = 1, SetupId = 1},
                new DJImageSetup {DJImageId = 2, SetupId = 1}
            };

            dJImageSetup.ForEach(s => context.DJImageSetups.AddOrUpdate(p => p.DJImageId, s));

            context.SaveChanges();
        }
    }
}
