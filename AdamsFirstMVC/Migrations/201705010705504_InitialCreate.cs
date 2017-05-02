namespace AdamsFirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutMandM",
                c => new
                    {
                        AboutMandMid = c.Int(nullable: false, identity: true),
                        HeadingH1 = c.String(),
                        HeadingH2 = c.String(),
                        HeadingH3 = c.String(),
                    })
                .PrimaryKey(t => t.AboutMandMid);
            
            CreateTable(
                "dbo.AboutMandMSetup",
                c => new
                    {
                        AboutMandMSetupId = c.Int(nullable: false, identity: true),
                        SetupId = c.Int(nullable: false),
                        AboutMandMId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AboutMandMSetupId)
                .ForeignKey("dbo.AboutMandM", t => t.AboutMandMId, cascadeDelete: true)
                .ForeignKey("dbo.Setup", t => t.SetupId, cascadeDelete: true)
                .Index(t => t.SetupId)
                .Index(t => t.AboutMandMId);
            
            CreateTable(
                "dbo.Setup",
                c => new
                    {
                        SetupId = c.Int(nullable: false, identity: true),
                        IsCurrentSetUp = c.Boolean(nullable: false),
                        SetupDate = c.DateTime(nullable: false),
                        CollageId = c.Int(nullable: false),
                        SetupName = c.String(),
                    })
                .PrimaryKey(t => t.SetupId)
                .ForeignKey("dbo.Collage", t => t.CollageId, cascadeDelete: true)
                .Index(t => t.CollageId);
            
            CreateTable(
                "dbo.BandImageSetup",
                c => new
                    {
                        BandImageSetupId = c.Int(nullable: false, identity: true),
                        SetupId = c.Int(nullable: false),
                        BandImageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BandImageSetupId)
                .ForeignKey("dbo.BandImage", t => t.BandImageId, cascadeDelete: true)
                .ForeignKey("dbo.Setup", t => t.SetupId, cascadeDelete: true)
                .Index(t => t.SetupId)
                .Index(t => t.BandImageId);
            
            CreateTable(
                "dbo.BandImage",
                c => new
                    {
                        BandImageId = c.Int(nullable: false, identity: true),
                        BandImageName = c.String(),
                        BandImageSrc = c.String(),
                        BandImageAlt = c.String(),
                        BandHref = c.String(),
                        BandToolTip = c.String(),
                    })
                .PrimaryKey(t => t.BandImageId);
            
            CreateTable(
                "dbo.Collage",
                c => new
                    {
                        CollageId = c.Int(nullable: false, identity: true),
                        CollageName = c.String(),
                        CollageSrc = c.String(),
                        CollageAlt = c.String(),
                    })
                .PrimaryKey(t => t.CollageId);
            
            CreateTable(
                "dbo.ClickableArea",
                c => new
                    {
                        ClickableAreaId = c.Int(nullable: false, identity: true),
                        CollageId = c.Int(nullable: false),
                        ClickableAreaName = c.String(),
                        ClickableAreaCoordinates = c.String(),
                        ClickableAreaHref = c.String(),
                        ClickableAreaShape = c.String(),
                        ClickableAreaAlt = c.String(),
                        BandToolTip = c.String(),
                    })
                .PrimaryKey(t => t.ClickableAreaId)
                .ForeignKey("dbo.Collage", t => t.CollageId, cascadeDelete: true)
                .Index(t => t.CollageId);
            
            CreateTable(
                "dbo.DJImage",
                c => new
                    {
                        DJImageId = c.Int(nullable: false, identity: true),
                        DJImageName = c.String(),
                        DJImageSrc = c.String(),
                        DJImageAlt = c.String(),
                        DJHref = c.String(),
                        DJToolTip = c.String(),
                    })
                .PrimaryKey(t => t.DJImageId);
            
            CreateTable(
                "dbo.DJImageSetup",
                c => new
                    {
                        DJImageSetupId = c.Int(nullable: false, identity: true),
                        SetupId = c.Int(nullable: false),
                        DJImageId = c.Int(nullable: false),
                        BandImage_BandImageId = c.Int(),
                    })
                .PrimaryKey(t => t.DJImageSetupId)
                .ForeignKey("dbo.BandImage", t => t.BandImage_BandImageId)
                .ForeignKey("dbo.Setup", t => t.SetupId, cascadeDelete: true)
                .ForeignKey("dbo.DJImage", t => t.DJImageId, cascadeDelete: true)
                .Index(t => t.SetupId)
                .Index(t => t.DJImageId)
                .Index(t => t.BandImage_BandImageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DJImageSetup", "DJImageId", "dbo.DJImage");
            DropForeignKey("dbo.DJImageSetup", "SetupId", "dbo.Setup");
            DropForeignKey("dbo.DJImageSetup", "BandImage_BandImageId", "dbo.BandImage");
            DropForeignKey("dbo.Setup", "CollageId", "dbo.Collage");
            DropForeignKey("dbo.ClickableArea", "CollageId", "dbo.Collage");
            DropForeignKey("dbo.BandImageSetup", "SetupId", "dbo.Setup");
            DropForeignKey("dbo.BandImageSetup", "BandImageId", "dbo.BandImage");
            DropForeignKey("dbo.AboutMandMSetup", "SetupId", "dbo.Setup");
            DropForeignKey("dbo.AboutMandMSetup", "AboutMandMId", "dbo.AboutMandM");
            DropIndex("dbo.DJImageSetup", new[] { "BandImage_BandImageId" });
            DropIndex("dbo.DJImageSetup", new[] { "DJImageId" });
            DropIndex("dbo.DJImageSetup", new[] { "SetupId" });
            DropIndex("dbo.ClickableArea", new[] { "CollageId" });
            DropIndex("dbo.BandImageSetup", new[] { "BandImageId" });
            DropIndex("dbo.BandImageSetup", new[] { "SetupId" });
            DropIndex("dbo.Setup", new[] { "CollageId" });
            DropIndex("dbo.AboutMandMSetup", new[] { "AboutMandMId" });
            DropIndex("dbo.AboutMandMSetup", new[] { "SetupId" });
            DropTable("dbo.DJImageSetup");
            DropTable("dbo.DJImage");
            DropTable("dbo.ClickableArea");
            DropTable("dbo.Collage");
            DropTable("dbo.BandImage");
            DropTable("dbo.BandImageSetup");
            DropTable("dbo.Setup");
            DropTable("dbo.AboutMandMSetup");
            DropTable("dbo.AboutMandM");
        }
    }
}
