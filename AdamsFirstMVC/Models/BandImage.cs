﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class BandImage
    {
        public int BandImageID { get; set; }
        public string BandImageName { get; set; }
        public string BandImageSrc { get; set; }
        public string BandImageAlt { get; set; }
        public string BandHref { get; set; }

    }

}