using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Simulador2.Models;

namespace Simulador2.Controllers
{
    public class EstimacionServiciosController : Controller
    {
        private readonly Simulador2Context _context;

        public EstimacionServiciosController(Simulador2Context context)
        {
            _context = context;
        }

        // GET: EstimacionServicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstimacionServicios.ToListAsync());
        }

        // GET: EstimacionServicios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacionServicios = await _context.EstimacionServicios
                .SingleOrDefaultAsync(m => m.Idsuscripcion == id);
            if (estimacionServicios == null)
            {
                return NotFound();
            }

            return View(estimacionServicios);
        }

        // GET: EstimacionServicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstimacionServicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idsuscripcion,unidad_produccion,TotalSuscripciones,TotalMensual")] EstimacionServicios estimacionServicios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estimacionServicios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estimacionServicios);
        }

        // GET: EstimacionServicios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacionServicios = await _context.EstimacionServicios.SingleOrDefaultAsync(m => m.Idsuscripcion == id);
            if (estimacionServicios == null)
            {
                return NotFound();
            }
            return View(estimacionServicios);
        }

        // POST: EstimacionServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Idsuscripcion,unidad_produccion,TotalSuscripciones,TotalMensual")] EstimacionServicios estimacionServicios)
        {
            if (id != estimacionServicios.Idsuscripcion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estimacionServicios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstimacionServiciosExists(estimacionServicios.Idsuscripcion))
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
            return View(estimacionServicios);
        }

        // GET: EstimacionServicios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacionServicios = await _context.EstimacionServicios
                .SingleOrDefaultAsync(m => m.Idsuscripcion == id);
            if (estimacionServicios == null)
            {
                return NotFound();
            }

            return View(estimacionServicios);
        }

        // POST: EstimacionServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var estimacionServicios = await _context.EstimacionServicios.SingleOrDefaultAsync(m => m.Idsuscripcion == id);
            _context.EstimacionServicios.Remove(estimacionServicios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstimacionServiciosExists(long id)
        {
            return _context.EstimacionServicios.Any(e => e.Idsuscripcion == id);
        }
    }
}
