using Camaro.Feature.Components.Models;
using Camaro.Foundation.Common.Core.Extensions;
using Camaro.Foundation.Common.Search.BaseSearch;
using Camaro.Foundation.Content.Services;
using Sitecore.Data;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers
{
    public class DealController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public DealController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: Header
        public ActionResult Deals()
        {

            var datasourceItem = _baseService.GetDataSourceItem<IDeallist>();

            return View("~/Views/Camaro/Components/Deals/Deals.cshtml", datasourceItem);
        }


        [HttpPost]
        public JsonResult GetSolrDeals(DealRequest dealRequest)
        {

            var dealsList = new List<Deals>();

            var settingsitem = Sitecore.Context.Database.GetItem(ID.Parse(dealRequest.settingsid));
            if (settingsitem != null)
            {

                var MaxResults = Convert.ToInt32(settingsitem.Fields["Max Results"].Value);
                if (MaxResults <= 0)
                {
                    MaxResults = 10;
                }
                string parentPath = string.Empty;
                var parentitem = settingsitem.GetInternalLinkFieldItem("Parent Path");
                if (parentitem != null)
                {
                    parentPath = parentitem.ID.ToString();
                }
                if (!string.IsNullOrEmpty(parentPath))
                {

                    Expression<Func<DealSearchResultItem, object>> order = x => x.DealTitle;

                    List<Expression<Func<DealSearchResultItem, bool>>> filters = new List<Expression<Func<DealSearchResultItem, bool>>>();
                    if (!string.IsNullOrEmpty(dealRequest.categoryid))
                    {
                        filters.Add(x => x.Category.Contains(Guid.Parse(dealRequest.categoryid)));

                    }
                    if (!string.IsNullOrEmpty(dealRequest.subcategoryid))
                    {
                        filters.Add(x => x.SubCategory.Contains(Guid.Parse(dealRequest.subcategoryid)));

                    }
                    if (!string.IsNullOrEmpty(dealRequest.SearchQuery))
                    {
                        filters.Add(x => x.DealTitle.ToLower().Contains(dealRequest.SearchQuery.ToLower()));

                    }
                    var basesearchservice = new BaseSearchService();
                    var result = basesearchservice.QueryItems<DealSearchResultItem>(parentFolderIds: new List<ID> { ID.Parse(parentPath) },
                        includeTemplateIds: new List<ID> { ID.Parse(Constants.DealsTemplateID) },

                        //parentFolderIds: new List<ID>() { ID.Parse(parentPath) },
                        // includeTemplateIds: new List<ID>() { ID.Parse(Constants.DealsTemplateID) },
                        filters: filters,
                        order: order
                        );

                    if (result != null && result.TotalRows > 0)
                    {
                        var dealItems = result.Items;
                        foreach (var dealItem in dealItems)
                        {
                            var deal = new Deals()
                            {
                                Title = dealItem.GetFieldValue("Title"),
                                Description = dealItem.GetFieldValue("Description"),
                                ImageURL = dealItem.GetFieldValue("Image URL"),
                                OfferValue = dealItem.GetFieldValue("Offer Value"),
                                ExpiryDate = Convert.ToDateTime(dealItem.GetDateFieldValue("Expiry Date")).ToString("dd-MMM-yyyy"),
                                Active = dealItem.GetCheckboxValue("Active"),
                            };
                            var categoryItem = dealItem.GetInternalLinkFieldItem("Category");
                            if (categoryItem != null)
                            {
                                deal.Category = new Category()
                                {
                                    CategoryId = categoryItem.ID,
                                    Text = categoryItem.GetFieldValue("Text"),
                                    Value = categoryItem.GetFieldValue("Value")
                                };
                            }

                            var subcategoryitem = dealItem.GetMultilistField("Sub Category");

                            var subcatlist = new List<Category>();

                            foreach (var item in subcategoryitem)
                            {
                                subcatlist.Add(new Category()
                                {
                                    CategoryId = item.ID,
                                    Text = item.GetFieldValue("Text"),
                                    Value = item.GetFieldValue("Value")
                                });
                            }
                            deal.SubCategory = subcatlist;
                            dealsList.Add(deal);
                        }

                    }
                   

                }
            }
            return Json(dealsList, JsonRequestBehavior.AllowGet);
        }
    }
}