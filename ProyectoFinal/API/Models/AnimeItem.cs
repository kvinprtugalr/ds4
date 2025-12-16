using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class AnimeItem
    {
        public int AnimeId { get; set; }
        public string title { get; set; }
        public string imageLarge { get; set; }
        public string imageSmall { get; set; }
        public string imageMedium { get; set; }
        public string synopsis { get; set; }
        public string genre { get; set; }

        public int? episodes { get; set; }         
        public string status { get; set; }        
        public string statusValue { get; set; }
    }
}