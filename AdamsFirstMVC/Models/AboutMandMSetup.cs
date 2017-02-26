using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class AboutMandMSetup
    {
        public int AboutMandMSetupId { get; set; }
        public int SetupId { get; set; }
        public int AboutMandMId { get; set; }
        public virtual Setup Setup { get; set; }
        public virtual AboutMandM AboutMandM {get; set; }
    }
}