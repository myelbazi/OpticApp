using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpticApp.Data;
using OpticApp.Models;
using OpticApp.Models.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace OpticApp.Controllers
{
    public class VisitesController : Controller
    {
        private readonly OpticAppContext _context;
        private IWebHostEnvironment _host;
        public VisitesController(OpticAppContext context, IWebHostEnvironment host)
        {
            _context = context;
            _host = host;
        }

        // GET: Visites
        public async Task<IActionResult> Index()
        {

            var opticAppContext = _context.Visites.Include(v => v.client).Include(v => v.etatVisite);
            return View(await opticAppContext.ToListAsync());
        }

        // GET: Visites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visite = await _context.Visites
                .Include(v => v.client)
                .Include(v => v.etatVisite)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (visite == null)
            {
                return NotFound();
            }

            return View(visite);
        }

        // GET: Visites/Create
        public IActionResult Create()
        {
            ViewData["clientID"] = new SelectList(_context.Clients, "ID", "nomComplet");
            ViewData["etatVisiteID"] = new SelectList(_context.EtatVisites, "ID", "ID");
            ViewData["ArticleVerreID"] = _context.Articles.Where(a => a.typeArticle.ID == 3).ToList();
            ViewData["ArticleMontureID"] = _context.Articles.Where(a => a.typeArticle.ID == 2).ToList();
            ViewData["ArticleAccessoireID"] = _context.Articles.Where(a => a.typeArticle.ID == 6).ToList();
            return View();
        }
        public IActionResult Create1()
        {
            ViewData["clientID"] = new SelectList(_context.Clients, "ID", "nomComplet");
            ViewData["etatVisiteID"] = new SelectList(_context.EtatVisites, "ID", "ID");
            return View();
        }
        // POST: Visites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,clientID,ophtalmo,date_visite,DateLivraison,DatePrescription,OD_loinSphere,OD_loincylindre,OD_loinAxe,OD_loinAdd,OD_loinPrisme,OD_loinBase,OD_IntermSphere,OD_Intermcylindre,OD_IntermAxe,OD_IntermAdd,OD_IntermPrisme,OD_IntermBase,OD_presSphere,OD_prescylindre,OD_presAxe,OD_presPrisme,OD_presBase,OD_ecart1,OD_ecart2,OD_ht1,OD_ht2,OD_doct1,OD_doct2,OG_loinSphere,OG_loincylindre,OG_loinAxe,OG_loinAdd,OG_loinPrisme,OG_loinBase,OG_IntermSphere,OG_Intermcylindre,OG_IntermAxe,OG_IntermAdd,OG_IntermPrisme,OG_IntermBase,OG_presSphere,OG_prescylindre,OG_presAxe,OG_presPrisme,OG_presBase,OG_ecart1,OG_ecart2,OG_ht1,OG_ht2,OG_doct1,OG_doct2,total,reste,attachements,etatVisiteID,remarques")] Visite visite, VenteArticles venteArticles)//
        {
            if (ModelState.IsValid)
            {
                _context.Add(visite);
                await _context.SaveChangesAsync();
                await InsertArticlesAsync(visite.ID, venteArticles);
                return RedirectToAction(nameof(Index));
            }
            ViewData["clientID"] = new SelectList(_context.Clients, "ID", "ID", visite.clientID);
            ViewData["etatVisiteID"] = new SelectList(_context.EtatVisites, "ID", "ID", visite.etatVisiteID);
            ViewData["ArticleVerreID"] = _context.Articles.Where(a => a.typeArticle.ID == 3).ToList();
            ViewData["ArticleMontureID"] = _context.Articles.Where(a => a.typeArticle.ID == 2).ToList();
            ViewData["ArticleAccessoireID"] = _context.Articles.Where(a => a.typeArticle.ID == 6).ToList();

            return View(visite);
        } 

        // GET: Visites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visite = await _context.Visites.FindAsync(id);
            if (visite == null)
            {
                return NotFound();
            }
            ViewData["clientID"] = new SelectList(_context.Clients, "ID", "ID", visite.clientID);
            ViewData["etatVisiteID"] = new SelectList(_context.EtatVisites, "ID", "ID", visite.etatVisiteID);
            ViewData["ArticleVerreID"] = _context.Articles.Where(a => a.typeArticle.ID == 3).ToList();
            ViewData["ArticleMontureID"] = _context.Articles.Where(a => a.typeArticle.ID == 2).ToList();
            ViewData["ArticleAccessoireID"] = _context.Articles.Where(a => a.typeArticle.ID == 6).ToList();
            return View(visite);
        }

        // POST: Visites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,clientID,ophtalmo,date_visite,DateLivraison,DatePrescription,OD_loinSphere,OD_loincylindre,OD_loinAxe,OD_loinAdd,OD_loinPrisme,OD_loinBase,OD_IntermSphere,OD_Intermcylindre,OD_IntermAxe,OD_IntermAdd,OD_IntermPrisme,OD_IntermBase,OD_presSphere,OD_prescylindre,OD_presAxe,OD_presPrisme,OD_presBase,OD_ecart1,OD_ecart2,OD_ht1,OD_ht2,OD_doct1,OD_doct2,OG_loinSphere,OG_loincylindre,OG_loinAxe,OG_loinAdd,OG_loinPrisme,OG_loinBase,OG_IntermSphere,OG_Intermcylindre,OG_IntermAxe,OG_IntermAdd,OG_IntermPrisme,OG_IntermBase,OG_presSphere,OG_prescylindre,OG_presAxe,OG_presPrisme,OG_presBase,OG_ecart1,OG_ecart2,OG_ht1,OG_ht2,OG_doct1,OG_doct2,total,reste,attachements,etatVisiteID,remarques")] Visite visite)
        {
            if (id != visite.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisiteExists(visite.ID))
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
            ViewData["clientID"] = new SelectList(_context.Clients, "ID", "ID", visite.clientID);
            ViewData["etatVisiteID"] = new SelectList(_context.EtatVisites, "ID", "ID", visite.etatVisiteID);
            ViewData["ArticleVerreID"] = _context.Articles.Where(a => a.typeArticle.ID == 3).ToList();
            ViewData["ArticleMontureID"] = _context.Articles.Where(a => a.typeArticle.ID == 2).ToList();
            ViewData["ArticleAccessoireID"] = _context.Articles.Where(a => a.typeArticle.ID == 6).ToList();
            return View(visite);
        }

        // GET: Visites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visite = await _context.Visites
                .Include(v => v.client)
                .Include(v => v.etatVisite)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (visite == null)
            {
                return NotFound();
            }

            return View(visite);
        }

        // POST: Visites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visite = await _context.Visites.FindAsync(id);
            _context.Visites.Remove(visite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisiteExists(int id)
        {
            return _context.Visites.Any(e => e.ID == id);
        }

        [HttpPost]
        public JsonResult AjaxMethod(int idArticle)
        {
            string ss = "0";
            
            if (idArticle != 0)
            {
                Article s = _context.Articles.Where(e => e.ID == idArticle).FirstOrDefault();
                ss = s.prixVenteHT.ToString();
            }
            
            return Json(ss);
        }

        private async Task InsertArticlesAsync(int visiteID, VenteArticles venteArticles)
        {
            Vente vente = new Vente();
            if (venteArticles.accessoire != "0")
            {
                vente.visiteID = visiteID;
                vente.articleID = int.Parse(venteArticles.accessoire);
                vente.montant = int.Parse(venteArticles.MT_accessoire);
                vente.articlePositionID = 7;
                _context.Add(vente);
            }
            if (venteArticles.Loin_verre_OD != "0")
            {
                vente = new Vente();
                vente.visiteID = visiteID;
                vente.articleID = int.Parse(venteArticles.Loin_verre_OD);
                vente.montant = int.Parse(venteArticles.MT_Loin_verre_OD);
                vente.articlePositionID = 2;
                _context.Add(vente);
            }
            if (venteArticles.Loin_verre_OG != "0")
            {
                vente = new Vente();
                vente.visiteID = visiteID;
                vente.articleID = int.Parse(venteArticles.Loin_verre_OG);
                vente.montant = int.Parse(venteArticles.MT_Loin_verre_OG);
                vente.articlePositionID = 1;
                _context.Add(vente);
            }
            if (venteArticles.Loin_monture != "0")
            {
                vente = new Vente();
                vente.visiteID = visiteID;
                vente.articleID = int.Parse(venteArticles.Loin_monture);
                vente.montant = int.Parse(venteArticles.MT_Loin_monture);
                vente.articlePositionID = 3;
                _context.Add(vente);
            }
            if (venteArticles.pres_verre_OD != "0")
            {
                vente = new Vente();
                vente.visiteID = visiteID;
                vente.articleID = int.Parse(venteArticles.pres_verre_OD);
                vente.montant = int.Parse(venteArticles.MT_pres_verre_OD);
                vente.articlePositionID = 5;
                _context.Add(vente);
            }
            if (venteArticles.pres_verre_OG != "0")
            {
                vente = new Vente();
                vente.visiteID = visiteID;
                vente.articleID = int.Parse(venteArticles.pres_verre_OG);
                vente.montant = int.Parse(venteArticles.MT_pres_verre_OG);
                vente.articlePositionID = 4;
                _context.Add(vente);
            }
            if (venteArticles.pres_monture != "0")
            {
                vente = new Vente();
                vente.visiteID = visiteID;
                vente.articleID = int.Parse(venteArticles.pres_monture);
                vente.montant = int.Parse(venteArticles.MT_pres_monture);
                vente.articlePositionID = 6;
                _context.Add(vente);
            }

            await _context.SaveChangesAsync();
        }
        public async Task<IActionResult> Download(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visite = await _context.Visites
                .Include(v => v.client)
                .Include(v => v.etatVisite)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (visite == null)
            {
                return NotFound();
            }

            var ventes = _context.Ventes
                .Include(v=>v.article)
                .Where(v => v.visiteID == id)
                .ToList();

            Document doc = new Document(PageSize.Letter);
            FileStream file = new FileStream("test.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            PdfWriter writer = PdfWriter.GetInstance(doc, file);
            doc.AddAuthor("unes");
            doc.AddTitle("bonjour");
            doc.Open();
            //**************
            //Chunk chunk = new Chunk("ECOLULETTE", FontFactory.GetFont("Arial", 20, Font.BOLDITALIC, BaseColor.Gray));
            //doc.Add(chunk);


            string path = _host.ContentRootPath+ "\\wwwroot\\img\\logo.JPG";

            //Table
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            table.SpacingBefore = 0f;
            table.SpacingAfter = 0f;
            
            //Cell no 1
            PdfPCell cell = new PdfPCell();
            cell.Border = 0;
            Image image = Image.GetInstance(path);
            image.ScaleAbsolute(200, 150);
            cell.AddElement(image);
            table.AddCell(cell);

            //Cell no 2
            Chunk chunk = new Chunk("Mieux voir, mieux vivre", FontFactory.GetFont("Montserrate Alternates", 20, Font.BOLDITALIC, BaseColor.Gray));
            
            cell = new PdfPCell();
            cell.Border = 0;
            cell.Colspan = 1;
            //cell.PaddingLeft = 15f;
            cell.AddElement(chunk);
            table.AddCell(cell);

            //Add table to document    
            doc.Add(table);







            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.Black, Element.ALIGN_LEFT, 1)));
            doc.Add(line);


            //Table
             table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            //Cell no 1
             cell = new PdfPCell();
            cell.Border = 0;
            chunk = new Chunk("ECOLUNETTE\nAdresse: Guiche laoudaya Rue laayoune\n  N° 44 . Temara \nTél: 05 37 56 02, \n INPE: 105025985", FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.Black));
            cell = new PdfPCell();
            cell.Border = 0;
            //cell.PaddingRight = 15f;
            cell.AddElement(chunk);
            table.AddCell(cell);

            //Cell no 2
            chunk = new Chunk(visite.client.nomComplet+"\nAdresse: "+ visite.client.adresse + " \n "+ visite.client.ville+ " \n Maroc ", FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.Black));
            cell = new PdfPCell();
            cell.Border = 0;
            cell.PaddingLeft = 15f;
            cell.AddElement(chunk);
            table.AddCell(cell);

            //Add table to document    
            doc.Add(table);







            //Table
            table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.HorizontalAlignment = 1;
            
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            cell = new PdfPCell();
            cell = new PdfPCell();
            cell.Border = 0;
            chunk = new Chunk("Facture N° : ***");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.Colspan = 2;
            cell.Border = 0;
            table.AddCell(cell);

            cell = new PdfPCell();
            cell = new PdfPCell();
            cell.Border = 0;
            chunk = new Chunk("Temara Le : " + DateTime.Today.ToShortDateString());
            cell.AddElement(chunk);
            //cell.BackgroundColor = BaseColor.LightGray;
            table.AddCell(cell);
            //Add table to document
            doc.Add(table);


            //Table
            table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.HorizontalAlignment = 1;
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            //Cell
            cell = new PdfPCell();
            /*chunk = new Chunk("This Month's Transactions of your Credit Card");
            cell.AddElement(chunk);
            cell.Colspan = 5;
            cell.BackgroundColor = BaseColor.Black;
            table.AddCell(cell);
            */
            cell = new PdfPCell();
            chunk = new Chunk("DESIGNATION");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Qté");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("PU (DH)");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Total HT (DH)");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            table.AddCell(cell);

            //table.AddCell("Qté");
            //table.AddCell("PU (DH)");
            //table.AddCell("Total HT (DH)");

            //table.AddCell("Test test Test test Test test Test test");
            //table.AddCell("1");
            //table.AddCell("500");
            //table.AddCell("500");

            double total_ht = 0;
            double tva = 0;
            double total_ttc = 0;
            foreach (Vente vente in ventes)
            {
                table.AddCell(vente.article.libelleArticle);
                table.AddCell("1");
                table.AddCell(vente.montant.ToString());
                table.AddCell(vente.montant.ToString());
                total_ht = total_ht + double.Parse(vente.montant.ToString());
            }

            tva = total_ht * 20 / 100;
            total_ttc = total_ht + tva;

            cell = new PdfPCell();
            cell.Colspan = 2;
            cell.Border = 0;
            table.AddCell(cell);

            //table.AddCell("Total HT (DH)");
            cell = new PdfPCell();
            chunk = new Chunk("Total HT (DH)");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            table.AddCell(total_ht.ToString());

            cell = new PdfPCell();
            cell.Colspan = 2;
            cell.Border = 0;
            table.AddCell(cell);

            //table.AddCell("TVA (20%)");
            cell = new PdfPCell();
            chunk = new Chunk("TVA (20%)");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            cell.HorizontalAlignment = 2;
            table.AddCell(cell);
            table.AddCell(tva.ToString());

            cell = new PdfPCell();
            cell.Colspan = 2;
            cell.Border = 0;
            table.AddCell(cell);
            //table.AddCell("Total TTC (DH)");
            cell = new PdfPCell();
            chunk = new Chunk("Total TTC (DH)");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LightGray;
            cell.HorizontalAlignment = 2;
            table.AddCell(cell);
            table.AddCell(total_ttc.ToString());
            //Add table to document
            doc.Add(table);

            //**************
            //doc.Add(new Phrase("bonjour"));
            writer.Close();
            doc.Close();
            file.Dispose();
            var pdf = new FileStream("test.pdf", FileMode.Open, FileAccess.Read);
            return File(pdf, "application/pdf");

        }
    }
}
