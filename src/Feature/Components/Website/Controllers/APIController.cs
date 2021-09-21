using Camaro.Feature.Components.Models;
using Camaro.Foundation.Content.Services;
using Newtonsoft.Json;
using RestSharp;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Camaro.Feature.Components.Controllers
{
    public class APIController : SitecoreController
    {
        private readonly IBaseService _baseService;
        public APIController(IBaseService baseService)
        {
            _baseService = baseService;
        }
        // GET: API
        public ActionResult GetAPI()
        {
            var datasourceItem = _baseService.GetDataSourceItem<IBaseData>();
            var data = new PublicDataResponse();

            Uri baseUrl = new Uri(datasourceItem.BaseURL);
            IRestClient client = new RestClient(baseUrl);
            IRestRequest request = new RestRequest(datasourceItem.ResponseURL, Method.GET);

            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var itemsAPI = JsonConvert.DeserializeObject<PublicDataResponse>(response.Content);
                var skiplist = itemsAPI.Entries.Skip(150).Take(10);
                var SelectedList = itemsAPI.Entries.Select(x => new { Name = x.Category, Descrip = x.API }).ToList();
                var SortedList = itemsAPI.Entries.OrderBy(o => o.API).ThenBy(o => o.Category).ToList().Skip(250).Take(20);
                var result = itemsAPI.Entries.Skip(250).Take(200).Where(m => m.Category.Contains("Government")).ToList();
                data.Count = itemsAPI.Count;
                data.Entries = result.ToList();

            }

            //using (WebClient webClient = new WebClient())
            //{
            //    webClient.BaseAddress = datasourceItem.BaseURL;
            //    var json = webClient.DownloadString(datasourceItem.ResponseURL);
            //    var list = JsonConvert.DeserializeObject<PublicDataResponse>(json);
            //    var skiplist = list.Entries.Skip(150).Take(10);
            //    //var SelectedList = list.Entries.Select(x => new { Name = x.Category, Descrip = x.API }).ToList();
            //    var SortedList = list.Entries.OrderBy(o => o.API).ThenBy(o => o.Category).ToList().Skip(250).Take(20);
            //    var result = list.Entries.Skip(250).Take(200).Where(m => m.Category.Contains("Government")).ToList();
            //    data.Count = list.Count;
            //    data.Entries = result.ToList();
                               
            //}
            


            return View("~/Views/Camaro/Components/API/API.cshtml", data);
        }
    }
}