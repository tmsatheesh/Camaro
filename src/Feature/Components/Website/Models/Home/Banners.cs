using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models
{
    public interface IBanners:IGlassBase
    {
        [SitecoreField(FieldName = "List Items")]
        IEnumerable<INameWithLinks> NameLinkItems { get; set; }
        [SitecoreField(FieldName = "Background Image")]
        Image BGImage { get; set; }
    }
    public interface INameWithLinks:IGlassBase
    {
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Description")]
        string Description { get; set; }
        [SitecoreField(FieldName = "CTA Link")]
        Link CTALink { get; set; }
        


    }
}