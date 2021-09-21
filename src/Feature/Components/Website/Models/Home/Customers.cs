using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface ICustomers:IGlassBase
    {
        [SitecoreField(FieldName = "List Items")]
        IEnumerable<IHeadAndDet> HeadDet { get; set; }
    }
    public interface IHeadAndDet
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Description")]
        string Details { get; set; }
    }
}