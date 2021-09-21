using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface IServices:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Link Items")]
        IEnumerable<IInfoWithImage> Infoimage { get; set; }
        string Style { get; set; }
    }
    public interface IInfoWithImage: IGlassBase, IInfoWithLinks
    {
        [SitecoreField(FieldName = "Image")]
        Image Image { get; set; }

    }

}