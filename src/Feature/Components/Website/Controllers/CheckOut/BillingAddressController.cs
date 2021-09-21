using Camaro.Feature.Components.Models.CheckOut;
using Camaro.Foundation.Content.Services;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers.CheckOut
{
    public class BillingAddressController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public BillingAddressController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: BillingAddress
        public ActionResult Billing()
        {
            var data = _baseService.GetDataSourceItem<IBillingAddress>();
            return View("~/Views/Camaro/Components/BillingAddress/BillingAddress.cshtml", data);
           
        }
    }
}