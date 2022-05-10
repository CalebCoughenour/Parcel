using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
    public class ParcelsController : Controller
    {

      [HttpGet("/parcels")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpGet("/parcels/form")]
      public ActionResult CreateParcelForm()
      {
        return View();
      }
      [HttpPost("/parcels/create")]
      public ActionResult CreateParcel(double height, double width, double length, double weight)
      {
        ParcelItem parcel = new ParcelItem(height, width, length, weight);
        ViewBag.parcel = parcel;
        ViewBag.total = parcel.CalculateCost();
        return View();
      }
   }
}