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
    public class TypePaiementsController : Controller
    {
        private readonly OpticAppContext _context;

        public TypePaiementsController(OpticAppContext context)
        {
            _context = context;
        }

        // GET: TypePaiements
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypePaiements.ToListAsync());
        }

        // GET: TypePaiements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typePaiement = await _context.TypePaiements
                .FirstOrDefaultAsync(m => m.ID == id);
            if (typePaiement == null)
            {
                return NotFound();
            }

            return View(typePaiement);
        }

        // GET: TypePaiements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypePaiements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,libelleTypePaiement")] TypePaiement typePaiement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typePaiement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typePaiement);
        }

        // GET: TypePaiements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typePaiement = await _context.TypePaiements.FindAsync(id);
            if (typePaiement == null)
            {
                return NotFound();
            }
            return View(typePaiement);
        }

        // POST: TypePaiements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,libelleTypePaiement")] TypePaiement typePaiement)
        {
            if (id != typePaiement.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typePaiement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypePaiementExists(typePaiement.ID))
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
            return View(typePaiement);
        }

        // GET: TypePaiements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typePaiement = await _context.TypePaiements
                .FirstOrDefaultAsync(m => m.ID == id);
            if (typePaiement == null)
            {
                return NotFound();
            }

            return View(typePaiement);
        }

        // POST: TypePaiements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typePaiement = await _context.TypePaiements.FindAsync(id);
            _context.TypePaiements.Remove(typePaiement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypePaiementExists(int id)
        {
            return _context.TypePaiements.Any(e => e.ID == id);
        }
    }
}
