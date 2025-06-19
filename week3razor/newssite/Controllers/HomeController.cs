using System.Text.Json;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.Models;
 
namespace newssite.Controllers;
 
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
 
    private List <NewsItem> newsitems = new List<NewsItem>();
 
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
         string Json = System.IO.File.ReadAllText("data/news.json");
    newsitems = JsonSerializer.Deserialize<List<NewsItem>>(Json);    
    }
 
    public IActionResult Index()
    {
 
            return View(newsitems);
    }
 
    public IActionResult Privacy()
    {
        Privacy model = new Privacy();
        model.PolicyText = "We do not track anything.";
        return View();
    }
 
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}