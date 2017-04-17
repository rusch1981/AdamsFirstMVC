using System.Collections.Generic;

namespace AdamsFirstMVC.Models
{
    public class BandImage
    {
        public int BandImageId { get; set; }
        public string BandImageName { get; set; }
        public string BandImageSrc { get; set; }
        public string BandImageAlt { get; set; }
        public string BandHref { get; set; }
        public string BandToolTip { get; set; }
        public virtual ICollection<BandImageSetup> BandImageSetups { get; set; }
    }

}