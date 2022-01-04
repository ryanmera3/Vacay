using System;
using Vacay.Interfaces;

namespace Vacay.Models
{
  public class Cruise : IVacation
  {
    public int Id { get; set; }
    public int Price { get; set; }
    public string Destination { get; set; }
    public string Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}