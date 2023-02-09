using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChuckNorrisASP.NET.Models;

namespace ChuckNorrisASP.NET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var joke = new ChuckJoke();

        if (joke == null)
        {
            return View(joke);
        }

        var repo = new ChuckJokeRepo();

        joke = repo.GetChuckJoke();

        return View(joke);
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

