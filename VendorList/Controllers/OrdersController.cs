using Microsoft.AspNetCore.Mvc;
using VendorList.Models;
using System.Collections.Generic;


namespace VendorList.Controllers
{
  public class OrdersController :Controller
  {

      [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

     [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string title)
    {
      Order myOrder = new Order(title);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }


  }
}

