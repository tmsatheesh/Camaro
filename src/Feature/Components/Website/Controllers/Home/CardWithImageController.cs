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
    public class CardWithImageController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public CardWithImageController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: CardWithImage
        public ActionResult CardwithImage()
        {
            var data = _baseservice.GetDataSourceItem<ICardWithImage>();
            var cardStyle = RenderingContext.CurrentOrNull.Rendering.Parameters["Card Model"];
            data.ImgStyle = cardStyle;
            return View("~/Views/Camaro/Components/Home/CardWithImage.cshtml",data);
        }
    }
}