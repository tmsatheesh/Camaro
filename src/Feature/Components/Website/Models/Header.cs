using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models
{
    public interface IHeader : IGlassBase
    {
        [SitecoreField(FieldName = "Email Link")]
        Link EmailLink { get; set; }
        ////[SitecoreField(FieldName = "Email Link")]
        ////string EmailText { get; set; }

        [SitecoreField(FieldName = "Phone Link")]
        Link PhoneLink { get; set; }
        //string PhoneText { get; set; }
        [SitecoreField(FieldName = "FB Link")]
        Link FBlink { get; set; }
        [SitecoreField(FieldName = "Twitter Link")]
        Link TWlink { get; set; }
        [SitecoreField(FieldName = "Vimeo Link")]
        Link VMlink { get; set; }
        [SitecoreField(FieldName = "GP Link")]
        Link GPlink { get; set; }
        [SitecoreField(FieldName = "Menu Items")]
        IEnumerable<IMenuItem> MenuItems { get; set; }
    }
    public interface IMenuItem: IGlassBase
    {
        [SitecoreField(FieldName = "Link")]
        Link Link { get; set; }
        [SitecoreField(FieldName = "Link Text")]
        string LinkText { get; set; }
        [SitecoreField(FieldName = "Sub Menu")]
        IEnumerable<IMenuItem> SubMenuItems { get; set; }
    }
}