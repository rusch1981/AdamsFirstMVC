using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class BandImageSetup
    {
        public int BandImageSetupID { get; set; }
        public int SetupID { get; set; }
        public virtual Setup Setup { get; set; }
    }
}