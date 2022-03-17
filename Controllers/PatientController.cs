using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HMS.Models;

namespace HMS.Controllers;

public class PatientController : Controller
{
    private readonly ApplicationDbContext db;

    public PatientController(ApplicationDbContext db)
    {
        this.db = db;
    }

    public IActionResult Index()
    {
        var data = db.Patient.ToList();
        return View(data);
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
