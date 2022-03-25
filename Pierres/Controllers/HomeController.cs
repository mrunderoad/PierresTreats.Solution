using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using System.Linq;

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

  }
}