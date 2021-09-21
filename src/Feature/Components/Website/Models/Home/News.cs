using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models.Home
{
    public interface INews:IGlassBase
    {
        [SitecoreField(FieldName = "Heading")]
        string Heading { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "List Items")]
        IEnumerable<IMultiLinkList> multiLinkLists { get; set; }
    }
    public interface IMultiLinkList:IGlassBase
    {
        [SitecoreField(FieldName = "Image")]
        Image Image { get; set; }
        [SitecoreField(FieldName = "Title")]
        Link Title { get; set; }
        //string TitleText { get; set; }
        [SitecoreField(FieldName = "Admin")]
        Link Admin { get; set; }
        //string AdminText { get; set; }
        [SitecoreField(FieldName = "Calender")]
        Link Calendar { get; set; }
        //string CalendarText { get; set; }
        [SitecoreField(FieldName = "Comment")]
        Link Comment { get; set; }
        //string CommentText { get; set; }
        [SitecoreField(FieldName = "Read More")]
        Link ReadMore { get; set; }
        //string ReadMoreText { get; set; }


    }
}