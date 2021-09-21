using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.CheckOut
{
    public interface IBillingAddress:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
    }
}