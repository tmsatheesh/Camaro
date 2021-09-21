using Camaro.Feature.Components.Models;
using Camaro.Foundation.Content.Services;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers
{
    public class BannerController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public BannerController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: Banner
        public ActionResult Banner()
        {
            var datasourceitem = _baseService.GetDataSourceItem<IBanners>();
            
            return View("~/Views/Camaro/Components/Banner.cshtml", datasourceitem);
        }
    }
}