using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkipperTools.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkipperTools.Data;

namespace SkipperTools.Controllers
{
    [Authorize]
    public class CrewsController : Controller
    {
        private AppDbContext _db { get; set; }
        public CrewMemberModel CrewMember { get; set; }
        public IActionResult Index()
        {

            return View();
        }
    }
}
