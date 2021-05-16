using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PredmetiController : Controller
    {
        // mora biti static jer se ponovo napravi controller za svaki visit
        static List<Predmet> predmeti = new List<Predmet>()
        {
            new Predmet(1, "OOAD", 6.0),
            new Predmet(2, "AFJ", 5.0),
            new Predmet(3, "RA", 4.0),
            new Predmet(4, "ORM", 3.0),
        };

        //private readonly ApplicationDbContext _context;

        public PredmetiController(ApplicationDbContext context)
        {
            

            //_context = context;
        }

        // GET: Predmeti
        /*public async Task<IActionResult> Index()
        {
            return View(await _context.Predmet.ToListAsync());
        }*/

        public IActionResult Index()
        {
            return View(predmeti);
        }

        // GET: Predmeti/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            { 
                return NotFound();
            }

            //var predmet = await _context.Predmet.FirstOrDefaultAsync(m => m.ID == id);
            var predmet = predmeti.Find(m => m.ID == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // GET: Predmeti/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Predmeti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Naziv,ECTS")] Predmet predmet)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(predmet);
                predmeti.Add(predmet);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(predmet);
        }

        // GET: Predmeti/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var predmet = await _context.Predmet.FindAsync(id);
            var predmet = predmeti.Find(p => p.ID == id);
            if (predmet == null)
            {
                return NotFound();
            }
            return View(predmet);
        }

        // POST: Predmeti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Naziv,ECTS")] Predmet predmet)
        {
            if (id != predmet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Predmet p = predmeti.Find(p => p.ID == predmet.ID);
                    predmeti.Remove(p);
                    predmeti.Add(predmet);
                    //_context.Update(predmet);
                    // await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredmetExists(predmet.ID))
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
            return View(predmet);
        }

        // GET: Predmeti/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Predmet predmet = predmeti.Find(p => p.ID == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // POST: Predmeti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var predmet = predmeti.Find(p => p.ID == id);
            predmeti.Remove(predmet);
            // _context.Predmet.Remove(predmet);
            // await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredmetExists(int id)
        {
            return predmeti.Any(e => e.ID == id);
        }
    }
}
