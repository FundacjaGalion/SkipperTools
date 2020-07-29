using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SkipperTools.Controllers
{
    [Authorize]
    public class WalletsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
