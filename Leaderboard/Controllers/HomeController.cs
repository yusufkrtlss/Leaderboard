using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Leaderboard.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace Leaderboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
     

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _userService = userService;
       
        }

        [HttpGet]
        public IActionResult Index()
        {
            string url = "https://cdn.mallconomy.com/testcase/points.json";
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                dynamic data = JsonConvert.DeserializeObject<List<User>>(json);
                _userService.GetAllUsers();
                return View(data);
            }

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