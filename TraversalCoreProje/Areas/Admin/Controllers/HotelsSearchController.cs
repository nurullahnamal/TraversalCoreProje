using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]

    public class HotelsSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://travel-advisor.p.rapidapi.com/hotels/list-in-boundary?bl_latitude=11.847676&bl_longitude=108.473209&tr_longitude=109.149359&tr_latitude=12.838442&limit=30&currency=USD&subcategory=hotel%2Cbb%2Cspecialty&adults=1"),
                Headers =
                {
                    { "X-RapidAPI-Key", "da4c4353e1mshe701c3dc6cbccf3p12ec5djsn2346aa10286f" },
                    { "X-RapidAPI-Host", "travel-advisor.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<HotelsSearchViewModel>(body);

                return View(values.data);
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetLocation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetLocation(string p)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://travel-advisor.p.rapidapi.com/hotels/list?location_id={p}&adults=1&rooms=1&nights=2&offset=0&currency=USD&order=asc&limit=30&sort=recommended&lang=en_US"),
                Headers =
            {
                { "X-RapidAPI-Key", "da4c4353e1mshe701c3dc6cbccf3p12ec5djsn2346aa10286f" },
                { "X-RapidAPI-Host", "travel-advisor.p.rapidapi.com" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }

            return View();
        }
    }
}

