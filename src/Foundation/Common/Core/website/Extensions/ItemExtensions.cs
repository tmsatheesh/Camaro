using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Camaro.Foundation.Common.Core.Utilities;
using Sitecore.Data;
using Sitecore.Data.Fields;

namespace Camaro.Foundation.Common.Core.Extensions
{
    public static class ItemExtensions
    {
        public static string GetImageFieldURL(this Item source, string fieldName)
        {
            Sitecore.Data.Fields.ImageField imgField = (Sitecore.Data.Fields.ImageField)source.Fields[fieldName];
            if (imgField != null && imgField.MediaItem != null)
            {
                MediaItem image = new MediaItem(imgField.MediaItem);

                if (image != null)
                {
                    return SitecoreUtil.GetMediaUrlWithServer(image);
                }
            }
            return string.Empty;
        }
        public static string GetCustomAttributes(this Item source, string fieldName)
        {
            Sitecore.Data.Fields.LinkField linkField = (Sitecore.Data.Fields.LinkField)source.Fields[fieldName];
            if (linkField != null)
            {
                return linkField.GetAttribute("customattributes");
            }
            return string.Empty;
        }
        public static string GetFieldValue(this Item source, string fieldName)
        {
            if (source.Fields[fieldName] != null && !string.IsNullOrEmpty(source.Fields[fieldName].Value))
            {
                return source.Fields[fieldName].Value.Trim();
            }

            return string.Empty;
        }
        public static Item GetInternalLinkFieldItem(this Item item, string fieldName)
        {
            Item targetItem = null;
            var itemValue = item.GetFieldValue(fieldName);
            if (!string.IsNullOrEmpty(itemValue))
            {
                targetItem = GetItemByPath(itemValue);
            }
            return targetItem;
        }
        public static Item GetInternalLinkFieldItem(this Item item, string fieldName, Database database)
        {
            Item targetItem = null;
            var itemValue = item.GetFieldValue(fieldName);
            if (!string.IsNullOrEmpty(itemValue))
            {
                if (database != null)
                {
                    targetItem = database.SelectSingleItem(itemValue);
                }
                else
                {
                    targetItem = Sitecore.Context.Database.SelectSingleItem(itemValue);
                }
            }
            return targetItem;
        }
        public static Item GetItemByPath(string itemPath, string database = "web")
        {
            Item currentItem = null;
            Database currentDb = Database.GetDatabase(database);
            if (!string.IsNullOrEmpty(itemPath))
            {
                currentItem = currentDb.SelectSingleItem(itemPath);
            }
            return currentItem;
        }
        public static int GetNumericFieldValue(this Item source, string fieldName)
        {
            if (source.Fields[fieldName] != null && !string.IsNullOrEmpty(source.Fields[fieldName].Value))
            {
                string value = source.Fields[fieldName].Value;
                if(Int32.TryParse(value,out int result))
                {
                    return result;
                }
            }
            return 0;
        }
        public static DateTime? GetDateFieldValue(this Item item, string fieldName)
        {
            DateTime? date = null;
            var dateField = item.Fields[fieldName] == null ? null : (DateField)item.Fields[fieldName];
            if (dateField != null && dateField.DateTime != DateTime.MinValue)
            {
                date = dateField.DateTime;
            }
            return date;
        }
        public static string GetLinkFieldValue(this Item source, string fieldName)
        {
            Sitecore.Links.UrlBuilders.ItemUrlBuilderOptions options = new Sitecore.Links.UrlBuilders.ItemUrlBuilderOptions();
            Sitecore.Data.Fields.LinkField linkField = (Sitecore.Data.Fields.LinkField)source.Fields[fieldName];

            string url = string.Empty;
            if (linkField != null)
            {
                switch (linkField.LinkType.ToLower())
                {
                    case "internal":
                        {
                            url = linkField.TargetItem != null ? Sitecore.Links.LinkManager.GetItemUrl(linkField.TargetItem, options).ToLower() : string.Empty;
                            break;
                        }
                    case "media":
                        {
                            url = linkField.TargetItem != null ? Sitecore.Resources.Media.MediaManager.GetMediaUrl(linkField.TargetItem) : string.Empty;
                            break;
                        }
                    case "external":
                        {
                            url = linkField.Url;
                            break;
                        }
                    case "anchor":
                        {
                            url = !string.IsNullOrEmpty(linkField.Anchor) ? "#" + linkField.Anchor : string.Empty;
                            break;
                        }
                    case "mailto":
                        {
                            url = linkField.Url;
                            break;
                        }
                    case "javascript":
                        {
                            url = linkField.Url;
                            break;
                        }
                    default:
                        {
                            url = linkField.Url;
                            break;
                        }
                }
                url = string.Format("{0}{1}", url, string.IsNullOrEmpty(linkField.QueryString) ? string.Empty : string.Format("?{0}", linkField.QueryString));
            }
            return url;
        }
        public static bool HasContextLanguage(this Item item)
        {
            if (item == null || item.Versions == null || item.Versions.Count == 0)
                return false;
            var latestLanguageVersion = item.Versions.GetLatestVersion();
            return (latestLanguageVersion != null) && (latestLanguageVersion.Versions.Count > 0);
        }
        public static List<Item> GetMultilistField(this Item source, string fieldname)
        {
            MultilistField multilistField = source.Fields[fieldname];
            if (multilistField != null && multilistField.TargetIDs != null)
            {

                return multilistField.GetItems().ToList();
            }
            return new List<Item>();
        }
        public static bool GetCheckboxValue(this Item item, string fieldName)
        {
            CheckboxField chkbxvalue = null;
            if (item != null && !string.IsNullOrEmpty(fieldName))
            {
                if (item.Fields[fieldName] != null)
                {
                    chkbxvalue = item.Fields[fieldName];
                    return chkbxvalue.Checked;
                }
            }
            return false;
        }
    }
}