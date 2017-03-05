using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class AboutMandM
    {
        public int AboutMandMid { get; set; }

        public string HeadingH1 { get; set; }

        public string HeadingH2 { get; set; }

        public string HeadingH3 { get; set; }

        public ICollection<AboutMandMSetup> AboutMandMSetups { get; set; }
    }
}