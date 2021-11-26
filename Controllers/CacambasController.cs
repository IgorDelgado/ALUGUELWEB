using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aluguel.Models;
using Aluguel.Models.Dominio;

namespace Aluguel.Controllers
{
    public class CacambasController : Controller
    {
        private readonly Contexto _context;

        public CacambasController(Contexto context)
        {
            _context = context;
        }

        // GET: Cacambas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Caçambas.ToListAsync());
        }

        // GET: Cacambas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cacamba = await _context.Caçambas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cacamba == null)
            {
                return NotFound();
            }

            return View(cacamba);
        }

        // GET: Cacambas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cacambas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Tamanho,Codigo,Observacao")] Cacamba cacamba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cacamba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cacamba);
        }

        // GET: Cacambas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cacamba = await _context.Caçambas.FindAsync(id);
            if (cacamba == null)
            {
                return NotFound();
            }
            return View(cacamba);
        }

        // POST: Cacambas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Tamanho,Codigo,Observacao")] Cacamba cacamba)
        {
            if (id != cacamba.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cacamba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CacambaExists(cacamba.ID))
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
            return View(cacamba);
        }

        // GET: Cacambas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cacamba = await _context.Caçambas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cacamba == null)
            {
                return NotFound();
            }

            return View(cacamba);
        }

        // POST: Cacambas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cacamba = await _context.Caçambas.FindAsync(id);
            _context.Caçambas.Remove(cacamba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CacambaExists(int id)
        {
            return _context.Caçambas.Any(e => e.ID == id);
        }
    }
}
