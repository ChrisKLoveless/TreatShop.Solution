using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TreatShop.Controllers
{
  public class FlavorsController : Controller
  {
     private readonly TreatShopContext _db;
  }

  public FlavorsController(TreatShopContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    List<Flavor> flavors = _db.Flavors.ToList();
    return View(flavors);
  }
}