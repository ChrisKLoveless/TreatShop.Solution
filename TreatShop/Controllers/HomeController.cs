using Microsoft.AspNetCore.Mvc;

namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}