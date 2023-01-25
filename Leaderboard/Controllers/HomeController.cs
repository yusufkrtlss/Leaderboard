

using EntityLayer.Concrete;
using Leaderboard.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Leaderboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
     

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
       
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            /*  var database = client.GetDatabase("LeaderboardDb");

             string url = "https://cdn.mallconomy.com/testcase/points.json";
             var jsonString = System.IO.File.ReadAllText(url);

             var users = JsonConvert.DeserializeObject<List<UserModel>>(jsonString);
            var collection = database.GetCollection<User>("Test");
             var test = new User()
             {
                 Id = ObjectId.GenerateNewId(),
                 UserId = 6,
                 TotalPoint = 250,
                 IsApproved = true
             };
             collection.InsertOne(test);
             _logger.LogInformation("Bu ilk logum");*/
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}