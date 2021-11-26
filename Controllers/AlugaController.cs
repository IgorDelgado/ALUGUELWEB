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
    public class AlugaController : Controller
    {
        private readonly Contexto _context;

        public AlugaController(Contexto context)
        {
            _context = context;
        }

        // GET: Aluga
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Alugueis.Include(a => a.NomeCliente).Include(a => a.NomeColaborador);
            return View(await contexto.ToListAsync());
        }

        // GET: Aluga/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluga = await _context.Alugueis
                .Include(a => a.NomeCliente)
                .Include(a => a.NomeColaborador)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aluga == null)
            {
                return NotFound();
            }

            return View(aluga);
        }

        // GET: Aluga/Create
        public IActionResult Create()
        {
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Contato");
            ViewData["ColaboradorID"] = new SelectList(_context.Colaboradores, "ID", "Funcao");
            return View();
        }

        // POST: Aluga/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ClienteID,Data_aluguel,Data_devolucao,Valor,ColaboradorID")] Aluga aluga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Contato", aluga.ClienteID);
            ViewData["ColaboradorID"] = new SelectList(_context.Colaboradores, "ID", "Funcao", aluga.ColaboradorID);
            return View(aluga);
        }

        // GET: Aluga/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluga = await _context.Alugueis.FindAsync(id);
            if (aluga == null)
            {
                return NotFound();
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Contato", aluga.ClienteID);
            ViewData["ColaboradorID"] = new SelectList(_context.Colaboradores, "ID", "Funcao", aluga.ColaboradorID);
            return View(aluga);
        }

        // POST: Aluga/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ClienteID,Data_aluguel,Data_devolucao,Valor,ColaboradorID")] Aluga aluga)
        {
            if (id != aluga.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlugaExists(aluga.ID))
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
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Contato", aluga.ClienteID);
            ViewData["ColaboradorID"] = new SelectList(_context.Colaboradores, "ID", "Funcao", aluga.ColaboradorID);
            return View(aluga);
        }

        // GET: Aluga/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluga = await _context.Alugueis
                .Include(a => a.NomeCliente)
                .Include(a => a.NomeColaborador)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aluga == null)
            {
                return NotFound();
            }

            return View(aluga);
        }

        // POST: Aluga/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluga = await _context.Alugueis.FindAsync(id);
            _context.Alugueis.Remove(aluga);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlugaExists(int id)
        {
            return _context.Alugueis.Any(e => e.ID == id);
        }
    }
}
