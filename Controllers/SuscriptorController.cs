using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using asp_net_core.Models;

namespace asp_net_core.Controllers
{
    public class SuscriptorController : Controller
    {
        private readonly SuscriptorContext _context;

        public SuscriptorController(SuscriptorContext context)
        {
            _context = context;
        }

        // GET: Suscriptor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Suscriptores.ToListAsync());
        }

        // public IActionResult Index()
        // {
        //     var oEscuela = (    from d in escuela
        //                         where d.NumeroDocumento == 42888333
        //                         select d);
                                
        //     return View(oEscuela);
        // }

        // GET: Suscriptor/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscriptor = await _context.Suscriptores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suscriptor == null)
            {
                return NotFound();
            }

            return View(suscriptor);
        }

        // GET: Suscriptor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suscriptor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumeroDocumento,Dirección,Email,NombreUsuario,Password,TipoDocumento,Id,Nombre,Apellido")] Suscriptor suscriptor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suscriptor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suscriptor);
        }

        // GET: Suscriptor/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscriptor = await _context.Suscriptores.FindAsync(id);
            if (suscriptor == null)
            {
                return NotFound();
            }
            return View(suscriptor);
        }

        // POST: Suscriptor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NumeroDocumento,Dirección,Email,NombreUsuario,Password,TipoDocumento,Id,Nombre,Apellido")] Suscriptor suscriptor)
        {
            if (id != suscriptor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suscriptor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuscriptorExists(suscriptor.Id))
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
            return View(suscriptor);
        }

        // GET: Suscriptor/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscriptor = await _context.Suscriptores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suscriptor == null)
            {
                return NotFound();
            }

            return View(suscriptor);
        }

        // POST: Suscriptor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var suscriptor = await _context.Suscriptores.FindAsync(id);
            _context.Suscriptores.Remove(suscriptor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuscriptorExists(string id)
        {
            return _context.Suscriptores.Any(e => e.Id == id);
        }
    }
}
