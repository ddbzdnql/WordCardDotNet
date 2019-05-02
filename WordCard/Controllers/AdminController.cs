using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WordCard.Models;

namespace WordCard.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyDbContext _context;
        private IWordRepository repo;
        private static string AddOrSave = "Add";
        private static int[] EditOrUpdate;

        public AdminController(IWordRepository repository){
            repo = repository;
            _context = repository.ctxt;
            if (EditOrUpdate == null){
                EditOrUpdate = new int[repo.Words.CountAsync().Result];
            }
        }

        // GET: Admin
        public IActionResult Display(){
            ViewBag.AddOrSave = AddOrSave;
            Console.Write("ViewBag: " + AddOrSave);
            return View(repo);
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id){
            if (id == null)
            {
                return NotFound();
            }

            var word = await _context.Words
                .FirstOrDefaultAsync(m => m.Index == id);
            if (word == null)
            {
                return NotFound();
            }

            return View(word);
        }

        // GET: Admin/Create
        public IActionResult Create(){
            AddOrSave = "Save";
            Console.Write("ViewBag: " + AddOrSave);
            return RedirectToAction(nameof(Display));
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Explanation,Index,TimesAccessed,TimesCorrect")] Word word)
        {
            if (ModelState.IsValid)
            {
                _context.Add(word);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Display));
            }
            return View(word);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var word = await _context.Words.FindAsync(id);
            if (word == null)
            {
                return NotFound();
            }
            return View(word);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Explanation,Index,TimesAccessed,TimesCorrect")] Word word)
        {
            if (id != word.Index)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(word);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WordExists(word.Index))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Display));
            }
            return View(word);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {


            var word = _context.Words
                .FirstOrDefaultAsync(m => m.Index == id);

            Task<Word> w = _context.Words.FindAsync(id);
            _context.Remove(w.Result);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Display));
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var word = await _context.Words.FindAsync(id);
            _context.Words.Remove(word);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Display));
        }

        private bool WordExists(int id)
        {
            return _context.Words.Any(e => e.Index == id);
        }
    }
}
