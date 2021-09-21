using Camaro.Feature.Components.Models.Home;
using Camaro.Foundation.Content.Services;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers.Home
{
    public class OffersController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public OffersController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: Offers
        public ActionResult Offers()
        {
            var datasourceitem = _baseService.GetDataSourceItem<IOffers>();
            return View("~/Views/Camaro/Components/Home/Offer.cshtml",datasourceitem);
        }
    }
}