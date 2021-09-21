using Camaro.Foundation.Common.ORM.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Sitecore.Pipelines.Search.CategorizeResults;

namespace Camaro.Feature.Components.Models
{
    public class Deals
    {
        //[SitecoreField(FieldName = "Title")]
        public string Title { get; set; }
        //[SitecoreField(FieldName = "Description")]
        public string Description { get; set; }
        //[SitecoreField(FieldName = "Image URL")]
        public string ImageURL { get; set; }
        //[SitecoreField(FieldName = "Offer Value")]
        public string OfferValue { get; set; }
        //[SitecoreField(FieldName = "Category")]
        public Category Category { get; set; }
        //[SitecoreField(FieldName = "Sub Category")]
        public List<Category> SubCategory     { get; set; }
        //[SitecoreField(FieldName = "Expiry Date")]
        public string ExpiryDate { get; set; }
        //[SitecoreField(FieldName = "Active")]
        public bool Active { get; set; }
       
    }
    public class Category
    {
        //[SitecoreField(FieldName = "Item ID")]
        public ID CategoryId { get; set; }
        //[SitecoreField(FieldName = "Text")]
        public string Text { get; set; }
        //[SitecoreField(FieldName = "Value")]
        public string Value { get; set; }
    }
}