using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpticApp.Data;
using OpticApp.Models;

namespace OpticApp.Controllers
{
    public class EtatVisitesController : Controller
    {
        private readonly OpticAppContext _context;

        public EtatVisitesController(OpticAppContext context)
        {
            _context = context;
        }

        // GET: EtatVisites
        public async Task<IActionResult> Index()
        {
            return View(await _context.EtatVisites.ToListAsync());
        }

        // GET: EtatVisites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etatVisite = await _context.EtatVisites
                .FirstOrDefaultAsync(m => m.ID == id);
            if (etatVisite == null)
            {
                return NotFound();
            }

            return View(etatVisite);
        }

        // GET: EtatVisites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EtatVisites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,libelleEtatVisite")] EtatVisite etatVisite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(etatVisite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(etatVisite);
        }

        // GET: EtatVisites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etatVisite = await _context.EtatVisites.FindAsync(id);
            if (etatVisite == null)
            {
                return NotFound();
            }
            return View(etatVisite);
        }

        // POST: EtatVisites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,libelleEtatVisite")] EtatVisite etatVisite)
        {
            if (id != etatVisite.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(etatVisite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EtatVisiteExists(etatVisite.ID))
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
            return View(etatVisite);
        }

        // GET: EtatVisites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etatVisite = await _context.EtatVisites
                .FirstOrDefaultAsync(m => m.ID == id);
            if (etatVisite == null)
            {
                return NotFound();
            }

            return View(etatVisite);
        }

        // POST: EtatVisites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var etatVisite = await _context.EtatVisites.FindAsync(id);
            _context.EtatVisites.Remove(etatVisite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EtatVisiteExists(int id)
        {
            return _context.EtatVisites.Any(e => e.ID == id);
        }
    }
}
