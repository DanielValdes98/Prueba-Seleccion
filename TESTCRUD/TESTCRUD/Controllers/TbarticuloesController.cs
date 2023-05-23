using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TESTCRUD.Models;

namespace TESTCRUD.Controllers
{
    public class TbarticuloesController : Controller
    {
        private readonly BdContext _context;

        public TbarticuloesController(BdContext context)
        {
            _context = context;
        }

        // GET: Tbarticuloes
        public async Task<IActionResult> Index()
        {
            var bdContext = _context.Tbarticulos.Include(t => t.FkIdProveedorNavigation);
            return View(await bdContext.ToListAsync());
        }

        // GET: Tbarticuloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tbarticulos == null)
            {
                return NotFound();
            }

            var tbarticulo = await _context.Tbarticulos
                .Include(t => t.FkIdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tbarticulo == null)
            {
                return NotFound();
            }

            return View(tbarticulo);
        }

        // GET: Tbarticuloes/Create
        public IActionResult Create()
        {
            ViewData["FkIdProveedor"] = new SelectList(_context.Tbproveedores, "IdProveedor", "IdProveedor");
            return View();
        }

        // POST: Tbarticuloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,Estado,FkIdProveedor")] Tbarticulo tbarticulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbarticulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkIdProveedor"] = new SelectList(_context.Tbproveedores, "IdProveedor", "IdProveedor", tbarticulo.FkIdProveedor);
            return View(tbarticulo);
        }

        // GET: Tbarticuloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tbarticulos == null)
            {
                return NotFound();
            }

            var tbarticulo = await _context.Tbarticulos.FindAsync(id);
            if (tbarticulo == null)
            {
                return NotFound();
            }
            ViewData["FkIdProveedor"] = new SelectList(_context.Tbproveedores, "IdProveedor", "IdProveedor", tbarticulo.FkIdProveedor);
            return View(tbarticulo);
        }

        // POST: Tbarticuloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,Estado,FkIdProveedor")] Tbarticulo tbarticulo)
        {
            if (id != tbarticulo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbarticulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbarticuloExists(tbarticulo.Id))
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
            ViewData["FkIdProveedor"] = new SelectList(_context.Tbproveedores, "IdProveedor", "IdProveedor", tbarticulo.FkIdProveedor);
            return View(tbarticulo);
        }

        // GET: Tbarticuloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tbarticulos == null)
            {
                return NotFound();
            }

            var tbarticulo = await _context.Tbarticulos
                .Include(t => t.FkIdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tbarticulo == null)
            {
                return NotFound();
            }

            return View(tbarticulo);
        }

        // POST: Tbarticuloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tbarticulos == null)
            {
                return Problem("Entity set 'BdContext.Tbarticulos'  is null.");
            }
            var tbarticulo = await _context.Tbarticulos.FindAsync(id);
            if (tbarticulo != null)
            {
                _context.Tbarticulos.Remove(tbarticulo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbarticuloExists(int id)
        {
          return _context.Tbarticulos.Any(e => e.Id == id);
        }
    }
}
