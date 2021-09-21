using Camaro.Feature.Components.Models;
using Camaro.Foundation.Content.Services;
using Sitecore.Data;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers
{
    public class FooterController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public FooterController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        

        // GET: Footer
        public ActionResult Footer()
        {
            var datasource = _baseService.GetDataSourceItem<IFooter>();
            return View("~/Views/Camaro/Components/Footer/Footer.cshtml",datasource);
        }
    }
}