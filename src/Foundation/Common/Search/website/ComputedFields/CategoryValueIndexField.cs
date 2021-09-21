using Camaro.Foundation.Common.Core.Extensions;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data.Items;
using System.Collections.Generic;
using System.Linq;

namespace Camaro.Foundation.Common.Search.ComputedFields
{
    public class CategoryValueIndexField : IComputedIndexField
    {
        public string FieldName { get; set; }

        public string ReturnType { get; set; }

        public object ComputeFieldValue(IIndexable indexable)
        {
            var indexItem = indexable as SitecoreIndexableItem;

            if (indexItem == null) return null;

            var item = indexItem.Item;

            var category = item.GetInternalLinkFieldItem("Category");
            if (category != null)
            {
                return category.GetFieldValue("Value");
            }
            return string.Empty;
        }
    }
}