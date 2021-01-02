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
    public class ArticlesController : Controller
    {
        private readonly OpticAppContext _context;

        public ArticlesController(OpticAppContext context)
        {
            _context = context;
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var opticAppContext = _context.Articles.Include(a => a.fournisseur).Include(a => a.typeArticle);
            return View(await opticAppContext.ToListAsync());
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.fournisseur)
                .Include(a => a.typeArticle)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            ViewData["fournisseurID"] = new SelectList(_context.Fournisseurs, "ID", "nomFournisseur");
            ViewData["typeArticleID"] = new SelectList(_context.TypeArticles, "ID", "libelleTypeArticle");
            return View(article);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["fournisseurID"] = new SelectList(_context.Fournisseurs, "ID", "nomFournisseur");
            ViewData["typeArticleID"] = new SelectList(_context.TypeArticles, "ID", "libelleTypeArticle");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,code,libelleArticle,prixAchat,prixVenteHT,stock,typeArticleID,fournisseurID")] Article article)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["fournisseurID"] = new SelectList(_context.Fournisseurs, "ID", "ID", article.fournisseurID);
            ViewData["typeArticleID"] = new SelectList(_context.TypeArticles, "ID", "ID", article.typeArticleID);
            return View(article);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["fournisseurID"] = new SelectList(_context.Fournisseurs, "ID", "nomFournisseur", article.fournisseurID);
            ViewData["typeArticleID"] = new SelectList(_context.TypeArticles, "ID", "libelleTypeArticle", article.typeArticleID);


            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,code,libelleArticle,prixAchat,prixVenteHT,stock,typeArticleID,fournisseurID")] Article article)
        {
            if (id != article.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ID))
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
            ViewData["fournisseurID"] = new SelectList(_context.Fournisseurs, "ID", "ID", article.fournisseurID);
            ViewData["typeArticleID"] = new SelectList(_context.TypeArticles, "ID", "ID", article.typeArticleID);
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.fournisseur)
                .Include(a => a.typeArticle)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            ViewData["fournisseurID"] = new SelectList(_context.Fournisseurs, "ID", "nomFournisseur");
            ViewData["typeArticleID"] = new SelectList(_context.TypeArticles, "ID", "libelleTypeArticle");

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.ID == id);
        }
    }
}
