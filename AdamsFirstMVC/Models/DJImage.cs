using System.Collections.Generic;

namespace AdamsFirstMVC.Models
{
    public class DJImage
    {
        public int DJImageId { get; set; }
        public string DJImageName { get; set; }
        public string DJImageSrc { get; set; }
        public string DJImageAlt { get; set; }
        public string DJHref { get; set; }
        public string DJToolTip { get; set; }
        public virtual ICollection<DJImageSetup> DJSetups { get; set; }
    }

}