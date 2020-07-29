using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SkipperTools.Controllers
{
    [Authorize]
    public class VesselsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
