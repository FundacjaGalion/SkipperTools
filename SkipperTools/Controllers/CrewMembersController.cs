using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkipperTools.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkipperTools.Controllers
{
    [Authorize]
    public class CrewMembersController : Controller
    {
        private readonly AppDbContext _db;
        public CrewMembersController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.CrewMembers.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var crewMemberFromDB = await _db.CrewMembers.FirstOrDefaultAsync(i => i.Id == id);
            if (crewMemberFromDB == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _db.CrewMembers.Remove(crewMemberFromDB);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
