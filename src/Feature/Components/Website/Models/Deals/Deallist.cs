using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models
{
    public interface IDeallist: IGlassBase
    {
        [SitecoreField(FieldName = "Parent Path")]
        string ParentPath { get; set; }
        [SitecoreField(FieldName = "Max Results")]
        int MaxResults { get; set; }

        [SitecoreField(FieldName = "Category List")]
        IEnumerable<ICategory> Categories { get; set; }
        [SitecoreField(FieldName = "Sub Category List")]
        IEnumerable<ICategory> SubCategories { get; set; }
    }
    public interface ICategory: IGlassBase
    {
        [SitecoreField(FieldName = "Text")]
        string Text { get; set; }
        [SitecoreField(FieldName = "Value")]
        string Value { get; set; }
    }

}