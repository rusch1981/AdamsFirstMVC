﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class BandImageSetup
    {
        public int BandImageSetupId { get; set; }
        public int SetupId { get; set; }
        public int BandImageId { get; set; }
        public virtual Setup Setup { get; set; }
        public virtual BandImage BandImage { get; set; }
    }
}