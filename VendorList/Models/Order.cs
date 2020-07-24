using System.Collections.Generic;

namespace VendorList.Models
{
    public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title)
    {
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
      
    } 

    
  }
}

