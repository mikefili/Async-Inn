using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AsyncInn.Data;
using AsyncInn.Models;

namespace AsyncInn.Controllers
{
    public class RoomAmenitiesController : Controller
    {
        private readonly AsyncInnDbContext _context;

        public RoomAmenitiesController(AsyncInnDbContext context)
        {
            _context = context;
        }

        // GET: RoomAmenities
        public async Task<IActionResult> Index()
        {
            var asyncInnDbContext = _context.RoomAmenities.Include(r => r.Amenities).Include(r => r.Room);
            return View(await asyncInnDbContext.ToListAsync());
        }

        // GET: RoomAmenities/Details/5
        public async Task<IActionResult> Details(int? amenityID, int? roomID)
        {
            if (amenityID == null || roomID == null)
            {
                return NotFound();
            }

            var roomAmenities = await _context.RoomAmenities
                .Include(r => r.Amenities)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.AmenitiesID == amenityID && m.RoomID == roomID);
            if (roomAmenities == null)
            {
                return NotFound();
            }

            return View(roomAmenities);
        }

        // GET: RoomAmenities/Create
        public IActionResult Create()
        {
            ViewData["AmenitiesID"] = new SelectList(_context.Amenities, "ID", "Name");
            ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name");
            return View();
        }

        // POST: RoomAmenities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AmenitiesID,RoomID")] RoomAmenities roomAmenities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomAmenities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AmenitiesID"] = new SelectList(_context.Amenities, "ID", "Name", roomAmenities.AmenitiesID);
            ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name", roomAmenities.RoomID);
            return View(roomAmenities);
        }

        // GET: RoomAmenities/Edit/5
        public async Task<IActionResult> Edit(int? amenityID, int? roomID)
        {
            if (amenityID == null || roomID == null)
            {
                return NotFound();
            }

            var roomAmenities = await _context.RoomAmenities.FirstOrDefaultAsync(m => m.AmenitiesID == amenityID && m.RoomID == roomID);
            if (roomAmenities == null)
            {
                return NotFound();
            }
            ViewData["AmenitiesID"] = new SelectList(_context.Amenities, "ID", "Name", roomAmenities.AmenitiesID);
            ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name", roomAmenities.RoomID);
            return View(roomAmenities);
        }

        // POST: RoomAmenities/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int amenityID, int roomID, [Bind("AmenitiesID,RoomID")] RoomAmenities roomAmenities)
        //{
        //    if (amenityID != roomAmenities.AmenitiesID || roomID != roomAmenities.RoomID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(roomAmenities);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RoomAmenitiesExists(roomAmenities.AmenitiesID, roomAmenities.RoomID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AmenitiesID"] = new SelectList(_context.Amenities, "ID", "Name", roomAmenities.AmenitiesID);
        //    ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name", roomAmenities.RoomID);
        //    return View(roomAmenities);
        //}

        // GET: RoomAmenities/Delete/5
        public async Task<IActionResult> Delete(int? roomID, int? amenityID)
        {
            if (roomID == null || amenityID == null)
            {
                return NotFound();
            }

            var roomAmenities = await _context.RoomAmenities
                .Include(r => r.Amenities)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.AmenitiesID == amenityID && m.RoomID == roomID);

            if (roomAmenities == null)
            {
                return NotFound();
            }

            return View(roomAmenities);
        }

        // POST: RoomAmenities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int amenityID, int roomID)
        {
            var roomAmenities = await _context.RoomAmenities.FirstOrDefaultAsync(m => m.AmenitiesID == amenityID && m.RoomID == roomID);
            _context.RoomAmenities.Remove(roomAmenities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomAmenitiesExists(int id)
        {
            return _context.RoomAmenities.Any(e => e.AmenitiesID == id);
        }
    }
}
