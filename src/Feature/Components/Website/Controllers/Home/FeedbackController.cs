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
    public class FeedbackController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public FeedbackController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: CardWithImage
        public ActionResult Feedback()
        {
            var data = _baseservice.GetDataSourceItem<IFeedback>();
            var style = RenderingContext.CurrentOrNull.Rendering.Parameters["Feedback Class"];
            data.ClassStyle = style;
            return View("~/Views/Camaro/Components/Home/Feedback.cshtml",data);
        }
    }
}