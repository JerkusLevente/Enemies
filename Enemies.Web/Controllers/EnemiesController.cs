using Enemies.Core.Models;
using Enemies.Web.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Enemies.Web.Controllers
{
    public class EnemiesController : Controller
    {
        private readonly EFContext _context;

        public EnemiesController(EFContext context)
        {
            _context = context;
        }

        // GET: Enemies
        public async Task<IActionResult> Index(
            string? Name,
            UnitType? Type,
            float? Health,
            int? Speed,
            int? Value
            )
        {
            var data = _context.Enemies.AsQueryable();
            if (Name != null) data = from el in data where el.Name == Name select el;
            if (Type != null) data = from el in data where el.Type == Type select el;
            if (Health != null) data = from el in data where el.Health >= Health select el;
            if (Speed != null) data = from el in data where el.Speed >= Speed select el;
            if (Value != null) data = from el in data where el.Value >= Value select el;
            return View(await data.ToListAsync());
        }

        // GET: Enemies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Enemies == null)
            {
                return NotFound();
            }

            var enemy = await _context.Enemies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enemy == null)
            {
                return NotFound();
            }

            return View(enemy);
        }

        // GET: Enemies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enemies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Health,Speed,Value")] Enemy enemy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enemy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enemy);
        }

        // GET: Enemies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Enemies == null)
            {
                return NotFound();
            }

            var enemy = await _context.Enemies.FindAsync(id);
            if (enemy == null)
            {
                return NotFound();
            }
            return View(enemy);
        }

        // POST: Enemies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Health,Speed,Value")] Enemy enemy)
        {
            if (id != enemy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enemy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnemyExists(enemy.Id))
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
            return View(enemy);
        }

        // GET: Enemies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Enemies == null)
            {
                return NotFound();
            }

            var enemy = await _context.Enemies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enemy == null)
            {
                return NotFound();
            }

            return View(enemy);
        }

        // POST: Enemies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Enemies == null)
            {
                return Problem("Entity set 'EFContext.Enemies'  is null.");
            }
            var enemy = await _context.Enemies.FindAsync(id);
            if (enemy != null)
            {
                _context.Enemies.Remove(enemy);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnemyExists(int id)
        {
            return _context.Enemies.Any(e => e.Id == id);
        }
    }
}
