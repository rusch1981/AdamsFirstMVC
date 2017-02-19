using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class Setup
    {
        public int SetupID { get; set; }
        public int AboutMandMID { get; set; }
        public int CollageID { get; set; }
        public virtual ICollection<BandImageSetup> BandImageSetups { get; set; }
    }
}