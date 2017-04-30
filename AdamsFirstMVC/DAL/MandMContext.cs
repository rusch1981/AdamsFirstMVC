using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AdamsFirstMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AdamsFirstMVC.DAL
{
    public class MandMContext : DbContext
    { 
        public MandMContext() : base("MandMContext")
        {

        }

        public DbSet<Setup> Setups { get; set; }

        public DbSet<BandImageSetup> BandImageSetups { get; set; }

        public DbSet<AboutMandMSetup> AboutMandMSetups { get; set; }

        public DbSet<DJImageSetup> DJImageSetups { get; set; }

        public DbSet<Collage> Collages { get; set; }

        public DbSet<ClickableArea>ClickableAreas { get; set; }

        public DbSet<BandImage>BandImages { get; set; }

        public DbSet<AboutMandM>AboutMandM { get; set; }

        public DbSet<DJImage> DJImages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}