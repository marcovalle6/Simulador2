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
    public class AlumnosController : Controller
    {
        private readonly Simulador2Context _context;

        public AlumnosController(Simulador2Context context)
        {
            _context = context;
        }

        // GET: Alumnos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alumnos.ToListAsync());
        }

        // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnos = await _context.Alumnos
                .SingleOrDefaultAsync(m => m.Idperfil == id);
            if (alumnos == null)
            {
                return NotFound();
            }

            return View(alumnos);
        }

        // GET: Alumnos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idperfil,Nombres,ApellidosP,ApellidosM,Rfc,NumTelefono,Email,Domicilio,Colonia,CodigoPostal,Estado,Ciudad")] Alumnos alumnos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumnos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alumnos);
        }

        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnos = await _context.Alumnos.SingleOrDefaultAsync(m => m.Idperfil == id);
            if (alumnos == null)
            {
                return NotFound();
            }
            return View(alumnos);
        }

        // POST: Alumnos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Idperfil,Nombres,ApellidosP,ApellidosM,Rfc,NumTelefono,Email,Domicilio,Colonia,CodigoPostal,Estado,Ciudad")] Alumnos alumnos)
        {
            if (id != alumnos.Idperfil)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumnos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnosExists(alumnos.Idperfil))
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
            return View(alumnos);
        }

        // GET: Alumnos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnos = await _context.Alumnos
                .SingleOrDefaultAsync(m => m.Idperfil == id);
            if (alumnos == null)
            {
                return NotFound();
            }

            return View(alumnos);
        }

        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var alumnos = await _context.Alumnos.SingleOrDefaultAsync(m => m.Idperfil == id);
            _context.Alumnos.Remove(alumnos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlumnosExists(long id)
        {
            return _context.Alumnos.Any(e => e.Idperfil == id);
        }
    }
}
