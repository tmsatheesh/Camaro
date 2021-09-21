using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {

        static void Main(string[] args)
        {
            GetPublicData();
            //GetCurrencyResponse();

            //Uri baseUrl = new Uri("https://api.coindesk.com");
            //IRestClient client = new RestClient(baseUrl);
            //IRestRequest request = new RestRequest("v1/bpi/currentprice.json", Method.GET);

            ////request.AddHeader("Authorization", "Bearer qaPmk9Vw8o7r7UOiX-3b-8Z_6r3w0Iu2pecwJ3x7CngjPp2fN3c61Q_5VU3y0rc-vPpkTKuaOI2eRs3bMyA5ucKKzY1thMFoM0wjnReEYeMGyq3JfZ-OIko1if3NmIj79ZSpNotLL2734ts2jGBjw8-uUgKet7jQAaq-qf5aIDwzUo0bnGosEj_UkFxiJKXPPlF2L4iNJSlBqRYrhw08RK1SzB4tf18Airb80WVy1Kewx2NGq5zCC-SCzvJW-mlOtjIDBAQ5intqaRkwRaSyjJ_MagxJF_CLc4BNUYC3hC2ejQDoTE6HYMWMcg0mbyWghMFpOw3gqyfAGjr6LPJcIly__aJ5__iyt-BTkOnMpDAZLTjzx4qDHMPWeND-TlzKWXjVb5yMv5Q6Jg6UmETWbuxyTdvGTJFzanUg1HWzPr7gSs6GLEv9VDTMiC8a5sNcGyLcHBIJo8mErrZrIssHvbT8ZUPWtyJaujKvdgazqsrad9CO3iRsZWQJ3lpvdQwucCsyjoRVoj_mXYhz3JK3wfOjLff16Gy1NLbj4gmOhBBRb8rJnUXnP7rBHs00FAk59BIpKLIPIyMgYBApDCut8V55AgXtGs4MgFFiJKbuaKxq8cdMYEVBTzDJ-S1IR5d6eiTGusD5aFlUkAs9NV_nFw");
            ////request.AddParameter("clientId", 123);

            //var response = client.Execute(request);

            //if (response.IsSuccessful)
            //{
            //    var currencyResponse = JsonConvert.DeserializeObject<CurrencyResponse>(response.Content);

            //    Console.WriteLine("Chart Name : {0}, {1}", currencyResponse.chartName, currencyResponse.bpi);
            //    Console.WriteLine("USD Rate : {0}", currencyResponse.bpi.USD.rate);


            //}
            //else
            //{
            //    Console.WriteLine(response.ErrorMessage);
            //}


            //using (WebClient webClient = new WebClient())
            //{
            //    webClient.BaseAddress = "https://api.coindesk.com";
            //    var json = webClient.DownloadString("v1/bpi/currentprice.json");
            //    // var list = JsonConvert.DeserializeObject<List<CityInfo>>(json);
            //    Console.WriteLine("{0}", json);

            //}
            Console.ReadLine();


        }
        public static void GetPublicData()
            {
            Uri baseUrl = new Uri("https://api.publicapis.org");
            IRestClient client = new RestClient(baseUrl);
            IRestRequest request = new RestRequest("entries", Method.GET);

            //request.AddHeader("Authorization", "Bearer qaPmk9Vw8o7r7UOiX-3b-8Z_6r3w0Iu2pecwJ3x7CngjPp2fN3c61Q_5VU3y0rc-vPpkTKuaOI2eRs3bMyA5ucKKzY1thMFoM0wjnReEYeMGyq3JfZ-OIko1if3NmIj79ZSpNotLL2734ts2jGBjw8-uUgKet7jQAaq-qf5aIDwzUo0bnGosEj_UkFxiJKXPPlF2L4iNJSlBqRYrhw08RK1SzB4tf18Airb80WVy1Kewx2NGq5zCC-SCzvJW-mlOtjIDBAQ5intqaRkwRaSyjJ_MagxJF_CLc4BNUYC3hC2ejQDoTE6HYMWMcg0mbyWghMFpOw3gqyfAGjr6LPJcIly__aJ5__iyt-BTkOnMpDAZLTjzx4qDHMPWeND-TlzKWXjVb5yMv5Q6Jg6UmETWbuxyTdvGTJFzanUg1HWzPr7gSs6GLEv9VDTMiC8a5sNcGyLcHBIJo8mErrZrIssHvbT8ZUPWtyJaujKvdgazqsrad9CO3iRsZWQJ3lpvdQwucCsyjoRVoj_mXYhz3JK3wfOjLff16Gy1NLbj4gmOhBBRb8rJnUXnP7rBHs00FAk59BIpKLIPIyMgYBApDCut8V55AgXtGs4MgFFiJKbuaKxq8cdMYEVBTzDJ-S1IR5d6eiTGusD5aFlUkAs9NV_nFw");
            //request.AddParameter("clientId", 123);

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var publicdataresponse = JsonConvert.DeserializeObject<PublicDataResponse>(response.Content);
                var result = publicdataresponse.entries.Where(m => m.API.Contains("Cat Facts")).SingleOrDefault();
                var SortedList = publicdataresponse.entries.OrderBy(o => o.API).ThenBy(o => o.Auth).ToList();
                var GroupedList = publicdataresponse.entries.GroupBy(x => x.Category).ToList();
                var SelectedList = publicdataresponse.entries.Select(x => new { Name = x.Category, Descrip = x.API  }).ToList();
                var skiplist = publicdataresponse.entries.Skip(150).Take(10);

                var date = DateTime.Now.ToString("dd/MM/yyyy, HH:mm:ss, dddd, MMMM");

                //var dt = DateTime.UtcNow;
                //var tz = TimeZoneInfo.FindSystemTimeZoneById("Indian Standard Time");
                //var localTimeInNewYork = TimeZoneInfo.ConvertTimeFromUtc(dt, tz);

                
                for(int i=1; i<11; i++)
                {
                    Console.WriteLine(i);
                }
                //Console.WriteLine("Current date : {0}", localTimeInNewYork);

                //Console.WriteLine("Before skip : {0}", publicdataresponse.entries.Count());
                //Console.WriteLine("After skip : {0}", skiplist.Count());
                //foreach (var item in skiplist)
                //{
                //    Console.WriteLine("Selected items : {0}", item.Category);
                //}
                //if (SelectedList != null)
                //{
                //    foreach (var item in SelectedList)
                //    {
                //        Console.WriteLine("Selected Category : {0}", item.Name);
                //        Console.WriteLine("Selected API : {0}", item.Descrip);
                //    }
                //}
                //if (SortedList!=null)
                //{
                //    foreach(var item in SortedList)
                //    {
                //        Console.WriteLine("sorted Item : {0}, {1}", item.API, item.Auth);
                //    }
                //}
                //foreach(var g in GroupedList)
                //{
                //    Console.WriteLine("Grouped Item : {0}", g.Key);
                //    foreach(var f in g)
                //    {
                //        Console.WriteLine("2nd Item : {0}", f.API);
                //    }
                //}


                //Random rnd = new Random();
                //var randomItem = SortedList[rnd.Next(0, SortedList.Count)];
                //if (randomItem != null)
                //{
                //    Console.WriteLine("Random Item : {0}", randomItem.API);
                //}

                //foreach (var item in SortedList)
                //{
                //    Console.WriteLine("Sorted Item : {0}", item.API);
                //}
                //if (SortedList != null)
                //{
                //    Console.WriteLine("Sorted Item : {0}", SortedList.API);
                //}

                //Console.WriteLine("Total Count : {0}", publicdataresponse.count);
                //if (result!=null)
                //{ 
                //Console.WriteLine("Search Item : {0}", result.Category);
                //}



            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }

        private static void GetCurrencyResponse()
        {
            // string apiURL = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.coindesk.com");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync("v1/bpi/currentprice.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var dataObjects = response.Content.ReadAsStringAsync().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                Console.WriteLine("{0}", dataObjects);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();
        }
    }


}
