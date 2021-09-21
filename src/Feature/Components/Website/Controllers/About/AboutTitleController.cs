using Camaro.Feature.Components.Models.About;
using Camaro.Foundation.Content.Services;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers.About
{
    public class AboutTitleController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public AboutTitleController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: AboutTitle
        public ActionResult AboutTitle()
        {
            var datasorce = _baseService.GetDataSourceItem<IAboutTitle>();
            return View("~/Views/Camaro/Components/About/AboutTitle.cshtml",datasorce);
        }
    }
}