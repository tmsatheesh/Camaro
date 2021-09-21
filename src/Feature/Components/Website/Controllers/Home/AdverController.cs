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
    public class AdverController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public AdverController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: CardWithImage
        public ActionResult Addver()
        {
            var data = _baseservice.GetDataSourceItem<IAddver>();
            return View("~/Views/Camaro/Components/Home/Addver.cshtml", data);
        }
    }
}