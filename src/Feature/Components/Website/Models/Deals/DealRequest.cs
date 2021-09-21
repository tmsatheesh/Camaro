using Camaro.Foundation.Common.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models
{
    public class DealRequest
    {
        public string settingsid { get; set; }
        public string categoryid { get; set; }
        public string subcategoryid { get; set; }
        public string SearchQuery { get; set; }
        //public string searchlocation { get; set; }
        //public string searchtitle { get; set; }


    }
}