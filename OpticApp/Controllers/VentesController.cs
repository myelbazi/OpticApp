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
    public class VentesController : Controller
    {
        private readonly OpticAppContext _context;

        public VentesController(OpticAppContext context)
        {
            _context = context;
        }

        // GET: Ventes
        public async Task<IActionResult> Index()
        {
            var opticAppContext = _context.Ventes.Include(v => v.article).Include(v => v.articlePosition).Include(v => v.visite);
            return View(await opticAppContext.ToListAsync());
        }

        // GET: Ventes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vente = await _context.Ventes
                .Include(v => v.article)
                .Include(v => v.articlePosition)
                .Include(v => v.visite)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vente == null)
            {
                return NotFound();
            }

            return View(vente);
        }

        // GET: Ventes/Create
        public IActionResult Create()
        {
            ViewData["articleID"] = new SelectList(_context.Articles, "ID", "ID");
            ViewData["articlePositionID"] = new SelectList(_context.ArticlePositions, "ID", "ID");
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID");
            return View();
        }

        // POST: Ventes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,visiteID,articleID,articlePositionID,montant")] Vente vente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["articleID"] = new SelectList(_context.Articles, "ID", "ID", vente.articleID);
            ViewData["articlePositionID"] = new SelectList(_context.ArticlePositions, "ID", "ID", vente.articlePositionID);
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID", vente.visiteID);
            return View(vente);
        }

        // GET: Ventes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vente = await _context.Ventes.FindAsync(id);
            if (vente == null)
            {
                return NotFound();
            }
            ViewData["articleID"] = new SelectList(_context.Articles, "ID", "ID", vente.articleID);
            ViewData["articlePositionID"] = new SelectList(_context.ArticlePositions, "ID", "ID", vente.articlePositionID);
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID", vente.visiteID);
            return View(vente);
        }

        // POST: Ventes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,visiteID,articleID,articlePositionID,montant")] Vente vente)
        {
            if (id != vente.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VenteExists(vente.ID))
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
            ViewData["articleID"] = new SelectList(_context.Articles, "ID", "ID", vente.articleID);
            ViewData["articlePositionID"] = new SelectList(_context.ArticlePositions, "ID", "ID", vente.articlePositionID);
            ViewData["visiteID"] = new SelectList(_context.Visites, "ID", "ID", vente.visiteID);
            return View(vente);
        }

        // GET: Ventes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vente = await _context.Ventes
                .Include(v => v.article)
                .Include(v => v.articlePosition)
                .Include(v => v.visite)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vente == null)
            {
                return NotFound();
            }

            return View(vente);
        }

        // POST: Ventes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vente = await _context.Ventes.FindAsync(id);
            _context.Ventes.Remove(vente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VenteExists(int id)
        {
            return _context.Ventes.Any(e => e.ID == id);
        }
    }
}
