using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult ParcelHome() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/parceldisplay")]
    public ActionResult ParcelDisplay(int length, int width, int height, int weight)
    {
      ParcelStorage newParcel = new ParcelStorage();
      newParcel.Length = length;
      newParcel.Width = width;
      newParcel.Height = height;
      newParcel.Weight= weight;
      newParcel.Volume = newParcel.findVol();
      newParcel.Cost = newParcel.findCost();
      if (length <= 0 || width <= 0 || height <= 0 || weight <= 0)
      {
        newParcel.Error = newParcel.error();
        return View(newParcel.Error);
      }
      else
      {
        return View(newParcel);
      }
    }
  }
}