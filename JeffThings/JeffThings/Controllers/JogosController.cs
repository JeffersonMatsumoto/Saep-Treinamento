using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JeffThings.Contexts;
using JeffThings.Domains;
using Microsoft.AspNetCore.Http;

namespace JeffThings.Controllers
{
    public class JogosController : Controller
    {
        private readonly JeffThingsContext _context;

        public JogosController(JeffThingsContext context)
        {
            _context = context;
        }

        // GET: Jogos
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Usuarios");
            }

            var jeffThingsContext = _context.Jogos.Include(j => j.TiposJogos);
            return View(await jeffThingsContext.ToListAsync());
        }

        // GET: Jogos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogos = await _context.Jogos
                .Include(j => j.TiposJogos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jogos == null)
            {
                return NotFound();
            }

            return View(jogos);
        }

        // GET: Jogos/Create
        public IActionResult Create()
        {
            ViewData["TiposJogosId"] = new SelectList(_context.TiposJogos, "Id", "Nome");
            return View();
        }

        // POST: Jogos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataLancamento,Descricao,Preco,Coop,TiposJogosId")] Jogos jogos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jogos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TiposJogosId"] = new SelectList(_context.TiposJogos, "Id", "Nome", jogos.TiposJogosId);
            return View(jogos);
        }

        // GET: Jogos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogos = await _context.Jogos.FindAsync(id);
            if (jogos == null)
            {
                return NotFound();
            }
            ViewData["TiposJogosId"] = new SelectList(_context.TiposJogos, "Id", "Nome", jogos.TiposJogosId);
            return View(jogos);
        }

        // POST: Jogos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataLancamento,Descricao,Preco,Coop,TiposJogosId")] Jogos jogos)
        {
            if (id != jogos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JogosExists(jogos.Id))
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
            ViewData["TiposJogosId"] = new SelectList(_context.TiposJogos, "Id", "Nome", jogos.TiposJogosId);
            return View(jogos);
        }

        // GET: Jogos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogos = await _context.Jogos
                .Include(j => j.TiposJogos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jogos == null)
            {
                return NotFound();
            }

            return View(jogos);
        }

        // POST: Jogos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jogos = await _context.Jogos.FindAsync(id);
            _context.Jogos.Remove(jogos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JogosExists(int id)
        {
            return _context.Jogos.Any(e => e.Id == id);
        }
    }
}
