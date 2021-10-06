using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaPhuongNam675.Data;
using LaPhuongNam675.Models;

namespace LaPhuongNam675.Controllers
{
    public class LPN675Controller : Controller
    {
        private readonly LaPhuongNam675Context _context;

        public LPN675Controller(LaPhuongNam675Context context)
        {
            _context = context;
        }

        // GET: NTH0668
        public async Task<IActionResult> Index()
        {
            return View(await _context.LPN0675.ToListAsync());
        }

        // GET: NTH0668/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var LPN0675 = await _context.LPN0675
                .FirstOrDefaultAsync(m => m.LPNId == id);
            if (LPN0675 == null)
            {
                return NotFound();
            }

            return View(LPN0675);
        }

        // GET: NTH0668/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTH0668/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LPNId,LPNName,LPNGender")] LPN0675 LPN0675)
        {
            if (ModelState.IsValid)
            {
                _context.Add(LPN0675);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(LPN0675);
        }

        // GET: LPN0675/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var LPN0675 = await _context.LPN0675.FindAsync(id);
            if (LPN0675 == null)
            {
                return NotFound();
            }
            return View(LPN0675);
        }

        // POST: LPN0675/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LPNId,LPNName,LPNGender")] LPN0675 LPN0675)
        {
            if (id != LPN0675.LPNId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(LPN0675);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LPN0675Exists(LPN0675.LPNId))
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
            return View(LPN0675);
        }

        // GET: LPN0675/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var LPN0675 = await _context.LPN0675
                .FirstOrDefaultAsync(m => m.LPNId == id);
            if (LPN0675 == null)
            {
                return NotFound();
            }

            return View(LPN0675);
        }

        // POST: LPN0675/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var LPN0675 = await _context.LPN0675.FindAsync(id);
            _context.LPN0675.Remove(LPN0675);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LPN0675Exists(string id)
        {
            return _context.LPN0675.Any(e => e.LPNId == id);
        }
    }
}