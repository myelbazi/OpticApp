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
    public class PaiementsController : Controller
    {
        private readonly OpticAppContext _context;

        public PaiementsController(OpticAppContext context)
        {
            _context = context;
        }

        // GET: Paiements
        public async Task<IActionResult> Index()
        {
            var opticAppContext = _context.Paiements.Include(p => p.typePaiement).Include(p => p.visite);
            return View(await opticAppContext.ToListAsync());
        }

        // GET: Paiements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paiement = await _context.Paiements
                .Include(p => p.typePaiement)
                .Include(p => p.visite)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (paiement == null)
            {
                return NotFound();
            }

            return View(paiement);
        }

        // GET: Paiements/Create
        public IActionResult Create()
        {
            ViewData["typePaiementID"] = new SelectList(_context.TypePaiements, "ID", "ID");
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID");
            return View();
        }

        // POST: Paiements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,visiteID,datePaiement,typePaiementID,montant,remarque")] Paiement paiement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paiement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["typePaiementID"] = new SelectList(_context.TypePaiements, "ID", "ID", paiement.typePaiementID);
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID", paiement.visiteID);
            return View(paiement);
        }

        // GET: Paiements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paiement = await _context.Paiements.FindAsync(id);
            if (paiement == null)
            {
                return NotFound();
            }
            ViewData["typePaiementID"] = new SelectList(_context.TypePaiements, "ID", "ID", paiement.typePaiementID);
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID", paiement.visiteID);
            return View(paiement);
        }

        // POST: Paiements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,visiteID,datePaiement,typePaiementID,montant,remarque")] Paiement paiement)
        {
            if (id != paiement.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paiement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaiementExists(paiement.ID))
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
            ViewData["typePaiementID"] = new SelectList(_context.TypePaiements, "ID", "ID", paiement.typePaiementID);
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID", paiement.visiteID);
            return View(paiement);
        }

        // GET: Paiements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paiement = await _context.Paiements
                .Include(p => p.typePaiement)
                .Include(p => p.visite)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (paiement == null)
            {
                return NotFound();
            }

            return View(paiement);
        }

        // POST: Paiements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paiement = await _context.Paiements.FindAsync(id);
            _context.Paiements.Remove(paiement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaiementExists(int id)
        {
            return _context.Paiements.Any(e => e.ID == id);
        }
    }
}
