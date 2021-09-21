using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models
{
    public interface IBaseData:IGlassBase
    {
        [SitecoreField(FieldName = "Base URL")]
        string BaseURL { get; set; }
        [SitecoreField(FieldName = "Response URL")]
        string ResponseURL { get; set; }

    }

}