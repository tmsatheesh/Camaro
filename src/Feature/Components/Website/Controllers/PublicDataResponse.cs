﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Entry
        {
            public string API { get; set; }
            public string Description { get; set; }
            public string Auth { get; set; }
            public bool HTTPS { get; set; }
            public string Cors { get; set; }
            public string Link { get; set; }
            public string Category { get; set; }
        }

        public class PublicDataResponse
    {
            public int count { get; set; }
            public List<Entry> entries { get; set; }
        }


    
}
