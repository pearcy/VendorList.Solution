using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorList.Models;
using System.Collections.Generic;
using System;

namespace VendorList.Tests
{
 [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

  [TestMethod]
  public void OrderConstructor_CreatesInstancesOfOrder_Order()
  {
    Order newOrder = new Order("test order");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }

  [TestMethod]
  public void GetTitle_ReturnsTitle_String()
  {
    string title = "Scone";

    Order newOrder = new Order(title);
    string result = newOrder.Title;

    Assert.AreEqual(title, result);

  }

  [TestMethod]
  public void SetTitle_SetTitle_String()
  {
    
    string title = "Scone";
    Order newOrder = new Order(title);

    string updatedTitle = "Do the dishes";
    newOrder.Title = updatedTitle;
    string result = newOrder.Title;

    Assert.AreEqual(updatedTitle, result);
  }

[TestMethod]
public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
{
  string title = "Scone1";
  Order newOrder = new Order(title);

  int result = newOrder.Id;

  Assert.AreEqual(1, result);
}




    

  }
}