using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class DJImageSetup
    {
        public int DJImageSetupId { get; set; }
        public int SetupId { get; set; }
        public int DJImageId { get; set; }
        public virtual Setup Setup { get; set; }
        public virtual BandImage BandImage { get; set; }
    }
}