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
    public class ArticlePositionsController : Controller
    {
        private readonly OpticAppContext _context;

        public ArticlePositionsController(OpticAppContext context)
        {
            _context = context;
        }

        // GET: ArticlePositions
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArticlePositions.ToListAsync());
        }

        // GET: ArticlePositions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articlePosition = await _context.ArticlePositions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (articlePosition == null)
            {
                return NotFound();
            }

            return View(articlePosition);
        }

        // GET: ArticlePositions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArticlePositions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Libelle")] ArticlePosition articlePosition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(articlePosition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(articlePosition);
        }

        // GET: ArticlePositions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articlePosition = await _context.ArticlePositions.FindAsync(id);
            if (articlePosition == null)
            {
                return NotFound();
            }
            return View(articlePosition);
        }

        // POST: ArticlePositions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Libelle")] ArticlePosition articlePosition)
        {
            if (id != articlePosition.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articlePosition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticlePositionExists(articlePosition.ID))
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
            return View(articlePosition);
        }

        // GET: ArticlePositions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articlePosition = await _context.ArticlePositions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (articlePosition == null)
            {
                return NotFound();
            }

            return View(articlePosition);
        }

        // POST: ArticlePositions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var articlePosition = await _context.ArticlePositions.FindAsync(id);
            _context.ArticlePositions.Remove(articlePosition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticlePositionExists(int id)
        {
            return _context.ArticlePositions.Any(e => e.ID == id);
        }
    }
}
