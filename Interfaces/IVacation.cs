using System;

namespace Vacay.Interfaces
{
  public interface IVacation
  {
    int Id { get; set; }
    int Price { get; set; }
    string Destination { get; set; }
    string Type { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
  }
}