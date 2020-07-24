using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorList.Models;

namespace VendorList.Controllers
{
  public class VendorsController : Controller
  {
     [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

     [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

     [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

     [HttpGet("/orders/{orderId}/orders/{orderId}")]
      public ActionResult Show(int vendorId, int orderId)
      {
        Order order = Order.Find(orderId);
        Vendor vendor = Vendor.Find(vendorId);
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("order", order);
        model.Add("vendor", vendor);
        return View(model);
      }

     [HttpPost("/vendors/{vendorId}/orders")]
      public ActionResult Create(int vendorId, string orderDescription)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor foundVendor = Vendor.Find(vendorId);
        Order newOrder = new Order(orderDescription);
        foundVendor.AddOrder(newOrder);
        List<Order> vendorOrders = foundVendor.Orders;
        model.Add("orders", vendorOrders);
        model.Add("vendor", foundVendor);
        return View("Show", model);
      }



  }
}