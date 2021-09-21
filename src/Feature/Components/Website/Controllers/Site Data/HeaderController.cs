using Camaro.Feature.Components.Models;
using Camaro.Foundation.Content.Services;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers
{
    public class HeaderController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public HeaderController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: Header
        public ActionResult Header()
        {
            var datasourceItem = _baseService.GetDataSourceItem<IHeader>();
            return View("~/Views/Camaro/Components/Header/Header.cshtml", datasourceItem);
        }
    }
}