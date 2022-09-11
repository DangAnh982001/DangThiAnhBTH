using Microsoft.AspNetCore.Mvc;
using DangThiAnhBTH.Models;

namespace DangThiAnhBTH.Controllers;
public class PersonController: Controller
{
   
    public IActionResult Index(Person std)
    {
        ViewBag.Ps = std.PersonID + "-"+ std.PersonName + "-" + std.Address; 
        return View();
    }
    public IActionResult Create ()
    {
        return View();
    }
}