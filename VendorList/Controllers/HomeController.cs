using Microsoft.AspNetCore.Mvc;
using VendorList.Models;

namespace VendorList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("Add first order list");
      return View(starterOrder);
    }

     [HttpGet("/orders")]
    public ActionResult New()
    {
      return View();
    }

     [HttpGet("/orders")]
    public ActionResult Create(string title)
    {
      Order myOrder = new Order(title);
      return View("Index", myOrder);
    }


  }
}