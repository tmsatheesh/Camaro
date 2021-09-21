using Camaro.Feature.Components.Models.Services;
using Camaro.Foundation.Content.Services;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers.Services
{
    public class ArmedSecurityController : SitecoreController
    {
        private readonly IBaseService _baseservice;
        public ArmedSecurityController(IBaseService baseService)
        {
            _baseservice = baseService;
        }
        // GET: ArmedSecurity
        public ActionResult ArmedSecurity()
        {
            var data = _baseservice.GetDataSourceItem<IArmedSecurity>();
            return View("~/Views/Camaro/Components/Services/ArmedSecurity.cshtml", data);
        }
    }
}