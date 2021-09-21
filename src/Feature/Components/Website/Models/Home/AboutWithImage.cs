using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface IAboutWithImage:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Image")]
        Image Image { get; set; }
        //string CardStyle { get; set; }
        [SitecoreField(FieldName = "Info items")]
        IEnumerable<IInfo> InfoItems { get; set; }
    }
    public interface IInfo:IGlassBase
    {
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Description")]
        string Description { get; set; }
    }

}