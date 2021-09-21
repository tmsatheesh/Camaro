using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.About
{
    public interface IAboutTitle:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        String Heading { get; set; }
        [SitecoreField(FieldName = "Home Link")]
        Link HomeLink { get; set; }
        [SitecoreField(FieldName = "Text")]
        String Text { get; set; }
        [SitecoreField(FieldName = "Background Image")]
        Image image { get; set; }

    }
}