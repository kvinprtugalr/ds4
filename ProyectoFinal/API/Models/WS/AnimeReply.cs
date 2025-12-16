using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models.WS
{
    public class AnimeReply
    {
        public int result { get; set; }
        public string message { get; set; }
        public List<AnimeItem> data { get; set; }
    }
}