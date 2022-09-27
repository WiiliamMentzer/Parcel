using System;

namespace Parcel.Models
{
  public class ParcelStorage
  {

    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int Cost { get; set; }
    public string Error { get; set; }
      
    public int findVol()
    {
      this.Volume = (this.Length * this.Width * this.Height);
      return Volume;
    }

    public int findCost()
    {
      this.Cost = this.Volume + (this.Weight * 5);
      return Cost;
    }

    public string error()
    {
      this.Error = "errorpage";
      return Error;
    }
  }
}