using Camaro.Feature.Components.Models;
using Camaro.Feature.Components.Models.Home;
using Camaro.Foundation.Content.Services;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Home
{
    public class CustomerController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public CustomerController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: CardWithImage
        public ActionResult Customers()
        {
            var data = _baseservice.GetDataSourceItem<ICustomers>();
            return View("~/Views/Camaro/Components/Home/Customers.cshtml", data);
        }
    }
}