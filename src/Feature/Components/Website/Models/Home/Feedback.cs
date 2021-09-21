using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface IFeedback:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "List Items")]
        IEnumerable<IFeedbackList> fblist { get; set; }
        string ClassStyle { get; set; }

    }
    public interface IFeedbackList: IInfoWithImage, IGlassBase
    {
        [SitecoreField(FieldName = "Name")]
        string ClientName { get; set; }
    }
}