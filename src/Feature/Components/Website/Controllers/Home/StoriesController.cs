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
    public class StoriesController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public StoriesController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: CardWithImage
        public ActionResult Stories()
        {
            var data = _baseservice.GetDataSourceItem<IStories>();
            return View("~/Views/Camaro/Components/Home/Stories.cshtml",data);
        }
    }
}