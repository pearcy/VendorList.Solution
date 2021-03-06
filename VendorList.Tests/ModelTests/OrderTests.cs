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

    string updatedTitle = "Muffin";
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

[TestMethod]
  public void Find_ReturnsCorrectOrder_Order()
  {
    //Arrange
    string title01 = "scone1";
    string title02 = "scone2";
    Order newOrder1 = new Order(title01);
    Order newOrder2 = new Order(title02);

    //Act
    Order result = Order.Find(2);

    //Assert
    Assert.AreEqual(newOrder2, result);
  }




    

  }
}