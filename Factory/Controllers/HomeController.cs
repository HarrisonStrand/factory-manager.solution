using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    // public ActionResult List()
    // {
    //   var tables = new ViewAll  
    //   {  
    //       Engineers=_db.Engineers.ToList(),
    //       Machines=_db.Machines.ToList()
    //   };
    //     return View(tables);
    // }
  }
}