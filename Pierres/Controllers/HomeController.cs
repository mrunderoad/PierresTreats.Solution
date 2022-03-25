using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {

    public readonly PierresContext _db;
    public HomeController(PierresContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Search(string Search)
    {
      var flavors = _db.Flavors.Where(flavor => (flavor.Name.Contains(Search) || (flavor.Name == Search))).ToList();
      var treats = _db.Treats.Where(treat => (treat.Name.Contains(Search) || (treat.Name == Search))).ToList();
      ViewBag.Flavors = flavors;
      ViewBag.Treats = treats;
      return View();
    }

    public ActionResult All()
    {
      var treats = _db.Treats.ToList();
      var flavors = _db.Flavors.ToList();
      ViewBag.Treats = treats;
      ViewBag.Flavors = flavors;
      return View();
    }
  }
}