using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface IBrands:IGlassBase
    {
        [SitecoreField(FieldName = "Image List")]
        IEnumerable<IImageListField> imageListFields { get; set; }
        string ClassStyle { get; set; }
    }
    public interface IImageListField: IGlassBase
    {
        [SitecoreField(FieldName = "Image")]
        Image Image { get; set; }
    }
}