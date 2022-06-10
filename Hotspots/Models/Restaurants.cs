using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotspots.Models
{
  public class Restaurant
  {
    public string Name { get; set; }
    public int Id { get; set; }
    public string City { get; set; }
    public string Cuisine { get; set; }
  }
}