using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface IStories:IGlassBase
    {
        [SitecoreField(FieldName = "List Items")]
        IEnumerable<IListWithHead> Infoitems { get; set; }

    }
    public interface IListWithHead:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Details")]
        string Description { get; set; }
    }
}