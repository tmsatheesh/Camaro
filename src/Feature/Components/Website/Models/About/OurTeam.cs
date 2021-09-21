using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.About
{
    public interface IOurTeam : IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }


        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }


        [SitecoreField(FieldName = "List Items")]
        IEnumerable<IListItem> ListItems { get; set; }
    }
      
    public interface IListItem: IGlassBase
    {
        [SitecoreField(FieldName = "Image")]
        Image Image { get; set; }
        [SitecoreField(FieldName = "Name")]
        string TeamName { get; set; }

        [SitecoreField(FieldName = "Position")]
        string Position { get; set; }

        [SitecoreField(FieldName = "FB Link")]
        Link FBlink { get; set; }
        [SitecoreField(FieldName = "TW Link")]
        Link TWlink { get; set; }
        [SitecoreField(FieldName = "VM Link")]
        Link VMlink { get; set; }
        [SitecoreField(FieldName = "LN Link")]
        Link LNlink { get; set; }
        
    }
}