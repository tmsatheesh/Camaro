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
    public class NewsController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public NewsController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: CardWithImage
        public ActionResult News()
        {
            var data = _baseservice.GetDataSourceItem<INews>();
            return View("~/Views/Camaro/Components/Home/News.cshtml", data);
        }
    }
}