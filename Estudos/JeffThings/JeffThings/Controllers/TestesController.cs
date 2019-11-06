﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JeffThings.Contexts;
using JeffThings.Domains;

namespace JeffThings.Controllers
{
    public class TestesController : Controller
    {
        private readonly JeffThingsContext _context;

        public TestesController(JeffThingsContext context)
        {
            _context = context;
        }

        // GET: Testes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Testes.ToListAsync());
        }

        // GET: Testes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testes = await _context.Testes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testes == null)
            {
                return NotFound();
            }

            return View(testes);
        }

        // GET: Testes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Testes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInicio,DataFim,HoraInicio,HoraFim")] Testes testes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testes);
        }

        // GET: Testes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testes = await _context.Testes.FindAsync(id);
            if (testes == null)
            {
                return NotFound();
            }
            return View(testes);
        }

        // POST: Testes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInicio,DataFim,HoraInicio,HoraFim")] Testes testes)
        {
            if (id != testes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestesExists(testes.Id))
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
            return View(testes);
        }

        // GET: Testes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testes = await _context.Testes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testes == null)
            {
                return NotFound();
            }

            return View(testes);
        }

        // POST: Testes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testes = await _context.Testes.FindAsync(id);
            _context.Testes.Remove(testes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestesExists(int id)
        {
            return _context.Testes.Any(e => e.Id == id);
        }
    }
}
