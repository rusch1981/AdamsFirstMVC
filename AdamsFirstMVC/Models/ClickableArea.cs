using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AdamsFirstMVC.Models
{
    public class ClickableArea
    {
        public int CollageID { get; set; }
        public int ClickableAreaID { get; set; }
        public string ClickableAreaName { get; set; }
        public string Coordinates { get; set; }
        public string URL { get; set; }
    }
}