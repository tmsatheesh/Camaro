using Camaro.Feature.Components.Models;
using Camaro.Feature.Components.Models.Home;
using Camaro.Foundation.Content.Services;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Home
{
    public class ServicesController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public ServicesController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: CardWithImage
        public ActionResult Services()
        {
            var data = _baseservice.GetDataSourceItem<IServices>();
            var style = RenderingContext.CurrentOrNull.Rendering.Parameters["Services Style"];
            data.Style = style;
            
            return View("~/Views/Camaro/Components/Home/Services.cshtml",data);
        }
    }
}