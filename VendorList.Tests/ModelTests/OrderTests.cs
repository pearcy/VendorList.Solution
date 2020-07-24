using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorList.Models;
using System.Collections.Generic;
using System;

namespace VendorList.Tests
{
 [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    

  }
}