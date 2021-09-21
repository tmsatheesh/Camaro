using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camaro.Feature.Components.Models
{
    public interface IFooter: IGlassBase
    {
        [SitecoreField(FieldName = "Logo")]
        Image Logo { get; set; }
        [SitecoreField(FieldName = "Logo Link")]
        Link LogoLink { get; set; }
        [SitecoreField(FieldName = "Logo Description")]
        string LogoDescription { get; set; }
        [SitecoreField(FieldName = "FB Link")]
        Link fbLink { get; set; }
        [SitecoreField(FieldName = "TW Link")]
        Link twLink { get; set; }
        [SitecoreField(FieldName = "Vimeo Link")]
        Link vmLink { get; set; }
        [SitecoreField(FieldName = "Linkedin Link")]
        Link lnLink { get; set; }
        [SitecoreField(FieldName = "Title Service")]
        string TitleService { get; set; }
        [SitecoreField(FieldName = "Link Items")]
        IEnumerable<ILinkItem> linkItems { get; set; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; set; }
        [SitecoreField(FieldName = "Image Link Items")]
        IEnumerable<IImageLinkItems> imageLinks { get; set; }
        [SitecoreField(FieldName = "Title News")]
        string TitleNews { get; set; }
        [SitecoreField(FieldName = "Description News")]
        string DescripNews { get; set; }
        [SitecoreField(FieldName = "Email")]
        string Email { get; set; }
        [SitecoreField(FieldName = "Button")]
        string Button { get; set; }
        [SitecoreField(FieldName = "Company Link")]
        Link CompanyLink { get; set; }
        [SitecoreField(FieldName = "Message")]
        
        
        string Message { get; set; }
        


    }
    public interface ILinkItem:IGlassBase
    {
        [SitecoreField(FieldName = "Linking Items")]
        Link LinkingItems { get; set; }
        //[SitecoreField(FieldName = "Email Link")]
        //string LinkingText { get; set; }
    }
    public interface IImageLinkItems:IGlassBase
    {
        [SitecoreField(FieldName = "Image")]
        Image Image { get; set; }
        [SitecoreField(FieldName = "Image Link")]
        Link ImageLink { get; set; }
    }
}