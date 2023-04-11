using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mummies.Models;

namespace Mummies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MummiesDatabaseContext _context { get; set; }

    public HomeController(ILogger<HomeController> logger, MummiesDatabaseContext temp)
    {
        _logger = logger;
        _context = temp;
    }

    ////////////////////
    /////   INDEX
    ////////////////////
    public IActionResult Index()
    {
        return View();
    }

    ////////////////////
    /////   BURIAL LIST
    ////////////////////
    public IActionResult BurialList()
    {
        var blah = _context.Burialmains.ToList();
        return View(blah);
    }

    ////////////////////
    /////   SUPERVISED
    ////////////////////
    public IActionResult Supervised()
    {
        return View();
    }

    ////////////////////
    /////   UNSUPERVISED
    ////////////////////
    public IActionResult Unsupervised()
    {
        return View();
    }

    ////////////////////
    /////   PRIVACY
    ////////////////////
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

