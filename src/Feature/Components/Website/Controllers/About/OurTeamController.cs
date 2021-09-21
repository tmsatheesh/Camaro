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
    public class OurTeamController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public OurTeamController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: AboutTitle
        public ActionResult OurTeam()
        {
            var datasorce = _baseService.GetDataSourceItem<IOurTeam>();
            return View("~/Views/Camaro/Components/About/OurTeam.cshtml", datasorce);
        }
    }
}