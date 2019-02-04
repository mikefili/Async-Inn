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
    public class HotelRoomsController : Controller
    {
        /// <summary>
        /// Brings in private, read only database context 
        /// </summary>
        private readonly AsyncInnDbContext _context;

        /// <summary>
        /// Publicly brings in db context
        /// </summary>
        /// <param name="context">Database context</param>
        public HotelRoomsController(AsyncInnDbContext context)
        {
            _context = context;
        }

        // GET: HotelRooms
        /// <summary>
        /// This method gets the created hotel rooms to display
        /// </summary>
        /// <returns>Index view</returns>
        public async Task<IActionResult> Index()
        {
            var asyncInnDbContext = _context.HotelRooms.Include(h => h.Hotel).Include(h => h.Room);
            return View(await asyncInnDbContext.ToListAsync());
        }

        // GET: HotelRooms/Details/5
        /// <summary>
        /// This method allows the user to view a hotel room's details
        /// </summary>
        /// <param name="hotelID">Hotel id</param>
        /// <param name="roomID">Room id</param>
        /// <returns>Details view</returns>
        public async Task<IActionResult> Details(int? hotelID, int? roomID)
        {
            if (hotelID == null || roomID == null)
            {
                return NotFound();
            }

            var hotelRoom = await _context.HotelRooms
                .Include(h => h.Hotel)
                .Include(h => h.Room)
                .FirstOrDefaultAsync(m => m.HotelID == hotelID && m.RoomID == roomID);
            if (hotelRoom == null)
            {
                return NotFound();
            }

            return View(hotelRoom);
        }

        // GET: HotelRooms/Create
        /// <summary>
        /// THis method initiates the hotel room create operation
        /// </summary>
        /// <returns>Create view</returns>
        public IActionResult Create()
        {
            ViewData["HotelID"] = new SelectList(_context.Hotels, "ID", "Name");
            ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name");
            return View();
        }

        // POST: HotelRooms/Create
        /// <summary>
        /// This method posts a new hotel room
        /// </summary>
        /// <param name="hotelRoom">newly created hotel room</param>
        /// <returns>Redirects user back to HotelRoom index view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int HotelID, int RoomNumber, [Bind("HotelID,RoomID,RoomNumber,Rate,PetFriendly")] HotelRoom hotelRoom)
        {
            if (RoomNumber != hotelRoom.RoomNumber)
            {
                var concurrency = _context.HotelRooms.Where(m => m.HotelID == hotelRoom.HotelID && m.RoomNumber == hotelRoom.RoomNumber);
                if (concurrency != null)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(hotelRoom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelRoomExists(hotelRoom.HotelID, hotelRoom.RoomID))
                    {
                        return NotFound("Page Not Found");
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["HotelID"] = new SelectList(_context.Hotels, "ID", "Name", hotelRoom.HotelID);
            ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name", hotelRoom.RoomID);
            return View(hotelRoom);
        }

        // GET: HotelRooms/Edit/5
        /// <summary>
        /// This method gets the room to be edited by composite key ID
        /// </summary>
        /// <param name="hotelID">Hotel ID</param>
        /// <param name="roomID">Room ID</param>
        /// <returns>Hotel room to be edited</returns>
        public async Task<IActionResult> Edit(int? hotelID, int? roomID)
        {
            if (hotelID == null || roomID == null)
            {
                return NotFound();
            }

            var hotelRoom = await _context.HotelRooms.FirstOrDefaultAsync(hr => hr.HotelID == hotelID && hr.RoomID == roomID);
            if (hotelRoom == null)
            {
                return NotFound();
            }
            ViewData["HotelID"] = new SelectList(_context.Hotels, "ID", "Name", hotelRoom.HotelID);
            ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name", hotelRoom.RoomID);
            return View(hotelRoom);
        }

        // POST: HotelRooms/Edit/5
        /// <summary>
        /// This method posts the desired edit and takes the user back to the HotelRoom index
        /// </summary>
        /// <param name="hotelID">Hotel id</param>
        /// <param name="roomID">Room id</param>
        /// <param name="hotelRoom">Hotel room to be edited</param>
        /// <returns>Redirects user back to HotelRoom index view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int hotelID, int roomID, [Bind("HotelID,RoomID,RoomNumber,Rate,PetFriendly")] HotelRoom hotelRoom)
        {
            if (hotelID != hotelRoom.HotelID || roomID != hotelRoom.RoomID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelRoom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelRoomExists(hotelRoom.HotelID, hotelRoom.RoomID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["HotelID"] = new SelectList(_context.Hotels, "ID", "Name", hotelRoom.HotelID);
            ViewData["RoomID"] = new SelectList(_context.Rooms, "ID", "Name", hotelRoom.RoomID);
            return View(hotelRoom);
        }

        // GET: HotelRooms/Delete/5
        /// <summary>
        /// This method initiates the delete operation by getting the room to be deleted
        /// </summary>
        /// <param name="hotelID">Hotel id</param>
        /// <param name="roomID">Room id</param>
        /// <returns>Hotel room to be deleted</returns>
        public async Task<IActionResult> Delete(int? hotelID, int? roomID)
        {
            if (hotelID == null || roomID == null)
            {
                return NotFound();
            }

            var hotelRoom = await _context.HotelRooms
                .Include(h => h.Hotel)
                .Include(h => h.Room)
                .FirstOrDefaultAsync(m => m.HotelID == hotelID && m.RoomID == roomID);

            if (hotelRoom == null)
            {
                return NotFound();
            }

            return View(hotelRoom);
        }

        // POST: HotelRooms/Delete/5
        /// <summary>
        /// This method completes the delete function by posting back to the index
        /// </summary>
        /// <param name="hotelID">Hotel id</param>
        /// <param name="roomID">Room id</param>
        /// <returns>Redirects user back to HotelRoom index view</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int hotelID, int roomID)
        {
            var hotelRoom = await _context.HotelRooms.FirstOrDefaultAsync(m => m.HotelID == hotelID && m.RoomID == roomID);
            _context.HotelRooms.Remove(hotelRoom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// This method confirms a hotel room exists by hotel & room IDs
        /// </summary>
        /// <param name="hotelID">Hotel id</param>
        /// <param name="roomID">Room id</param>
        /// <returns>Desired HotelRoom</returns>
        private bool HotelRoomExists(int hotelID, int roomID)
        {
            return _context.HotelRooms.Any(e => e.HotelID == hotelID && e.RoomID == roomID);
        }
    }
}
