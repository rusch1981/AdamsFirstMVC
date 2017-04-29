using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class Setup
    {
        public int SetupId { get; set; }
        public bool IsCurrentSetUp { get; set; }
        public DateTime SetupDate { get; set; }
        public int CollageId { get; set; }
        public string SetupName { get; set; }
        public virtual ICollection<BandImageSetup> BandImageSetups { get; set; }
        public virtual  ICollection<AboutMandMSetup> AboutMandMSetups { get; set; }
        public virtual Collage Collage { get; set; }
    }
}