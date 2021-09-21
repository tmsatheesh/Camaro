using Camaro.Foundation.Common.Search.Models;
using Newtonsoft.Json;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Converters;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;



namespace Camaro.Feature.Components.Models
{
    public class DealSearchResultItem: BaseSearchResultItem
    {
       
        [IndexField("title_t")]
        public virtual string DealTitle { get; set; }



       
        [IndexField("category_sm")]
        [TypeConverter(typeof(IndexFieldEnumerableConverter))]
        public List<Guid> Category { get; set; }

        
        [TypeConverter(typeof(IndexFieldEnumerableConverter))]
        [IndexField("sub_category_sm")]
        public List<Guid> SubCategory { get; set; }


       


    }
}