using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Services
{
    public interface IArmedSecurity : IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }

        [SitecoreField(FieldName = "Other Links")]
        IEnumerable<IListItem> ListItems { get; set; }
        [SitecoreField(FieldName = "Logo")]
        Image Logo { get; set; }
        [SitecoreField(FieldName = "Main Heading")]
        string MainHeading { get; set; }
        [SitecoreField(FieldName = "Description")]
        string Description { get; set; }
        [SitecoreField(FieldName = "Sub Image")]
        Image SubImage { get; set; }
        [SitecoreField(FieldName = "Sub Heading")]
        string SubHeading { get; set; }
        [SitecoreField(FieldName = "Sub Image Description")]
        string SubImageDescription { get; set; }
        [SitecoreField(FieldName = "Sub Description")]
        string SubDescription { get; set; }
    }
      
    public interface IListItem: IGlassBase
    {
        
        [SitecoreField(FieldName = "Linking Items")]
        Link Links { get; set; }
        
        
    }
}