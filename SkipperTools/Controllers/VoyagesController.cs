using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkipperTools.Data;
using SkipperTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkipperTools.Controllers
{
    [Authorize]
    public class VoyagesController : Controller
    {
        private readonly AppDbContext _db;
        [BindProperty]
        public VoyageModel Voyages { get; set; }



        public VoyagesController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(Guid? id)
        {
            Voyages = new VoyageModel();
            if (id == null)
            {
                //create
                return View(Voyages);
            }
            //update
            Voyages = _db.Voyages.FirstOrDefault(u => u.Id == id);
            if (Voyages == null)
            {
                return NotFound();
            }
            return View(Voyages);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)

            {
                if (Voyages.Id == null)
                { //create
                    _db.Voyages.Add(Voyages);
                }
                else
                {
                    _db.Voyages.Update(Voyages);
                }

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Voyages);
        }

        #region API Calls
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Json(new { data = await _db.Voyages.ToListAsync() });
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(Guid id)
        {
            var voyagesFromDb = await _db.Voyages.FirstOrDefaultAsync(u => u.Id == id);
            if (voyagesFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _db.Voyages.Remove(voyagesFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
