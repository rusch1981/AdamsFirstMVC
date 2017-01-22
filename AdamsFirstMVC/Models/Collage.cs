using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class Collage
    {
        public int CollageID { get; set; }
        public string CollageName { get; set; }
        public string CollageSrc { get; set; }
        public string CollageAlt { get; set; }

        public virtual ICollection<ClickableArea> ClickableAreas { get; set; }
    }

}