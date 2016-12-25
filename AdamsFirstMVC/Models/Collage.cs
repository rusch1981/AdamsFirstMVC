using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdamsFirstMVC.Models
{
    public class Collage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<ClickableArea> ClickableAreas { get; set; }
    }

}