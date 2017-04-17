using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AdamsFirstMVC.Models
{
    public class ClickableArea
    {
        public int CollageId { get; set; }
        public int ClickableAreaId { get; set; }
        public string ClickableAreaName { get; set; }
        public string ClickableAreaCoordinates { get; set; }
        public string ClickableAreaHref { get; set; }
        public string ClickableAreaShape { get; set; }
        public string ClickableAreaAlt { get; set; }
        public string BandToolTip { get; set; }

        public virtual Collage Collage { get; set; }
    }
}