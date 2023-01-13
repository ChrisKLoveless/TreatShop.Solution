using Microsoft.AspNetCore.Mvc;
using TreatShop.Models;

namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatShopContext _db;
    public HomeController(TreatShopContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("Treats", treats);
      model.Add("Flavors", flavors);
      return View(model);
    }
  }
}