using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface IOffers: IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Link Items")]

        IEnumerable<IInfoWithLinks> InfoItems { get; set; }

    }
    public interface IInfoWithLinks:IGlassBase
    {
        [SitecoreField(FieldName = "CTA Link")]
        Link CTALink { get; set; }
        [SitecoreField(FieldName = "Title")]
        string LinkTitle { get; set; }
        [SitecoreField(FieldName = "Description")]
        string LinkDescription { get; set; }
    }
}