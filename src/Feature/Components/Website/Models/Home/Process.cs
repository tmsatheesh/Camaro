using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface IProcess:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "List Items")]
        IEnumerable<IProcessList> processLists { get; set; }
    }
    public interface IProcessList: IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Details")]
        string Details { get; set; }

    }
}