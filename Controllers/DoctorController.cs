using System.Diagnostics;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using HMS.Models;

namespace HMS.Controllers;

public class DoctorController : Controller
{
    private readonly ApplicationDbContext db;

    public DoctorController(ApplicationDbContext db)
    {
        this.db = db;
    }

    public IActionResult Index()
    {
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