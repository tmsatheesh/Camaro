using Camaro.Foundation.Common.Core.Extensions;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data;
using Sitecore.Data.Items;
using System.Collections.Generic;
using System.Linq;

namespace Camaro.Foundation.Common.Search.ComputedFields
{
    public class CategoryTextIndexField : IComputedIndexField
    {
        public string FieldName { get; set; }

        public string ReturnType { get; set; }

        public object ComputeFieldValue(IIndexable indexable)
        {
            
            var indexItem = indexable as SitecoreIndexableItem;

            if (indexItem == null) return null;

            var item = indexItem.Item;
            if (item.TemplateID.ToString() == "{2B503564-75D3-4373-AED2-E21535E0512D}")
            {


                var category = item.GetInternalLinkFieldItem("Category");
                if (category != null)
                {
                    return category.GetFieldValue("Text");
                }
            }
            return string.Empty;
        }
    }

}