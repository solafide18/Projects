using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCoreTemplate.Models.Databases.MGS;
using WebCoreTemplate.Models.Datas;

namespace WebCoreTemplate.Web.Apps.Controllers
{
    public class barangsController : Controller
    {
        private readonly MGSContext _context;

        public barangsController(MGSContext context)
        {
            _context = context;
        }

        // GET: barangs
        public async Task<IActionResult> Index()
        {
            return View(await _context.barang.ToListAsync());
        }

        // GET: barangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barang = await _context.barang
                .FirstOrDefaultAsync(m => m.id == id);
            if (barang == null)
            {
                return NotFound();
            }

            return View(barang);
        }

        // GET: barangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: barangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,kode_barang,nama_barang,harga_beli,harga_jual,tipe,created_by,created_date")] barang barang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(barang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(barang);
        }

        // GET: barangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barang = await _context.barang.FindAsync(id);
            if (barang == null)
            {
                return NotFound();
            }
            return View(barang);
        }

        // POST: barangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,kode_barang,nama_barang,harga_beli,harga_jual,tipe,created_by,created_date")] barang barang)
        {
            if (id != barang.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(barang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!barangExists(barang.id))
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
            return View(barang);
        }

        // GET: barangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barang = await _context.barang
                .FirstOrDefaultAsync(m => m.id == id);
            if (barang == null)
            {
                return NotFound();
            }

            return View(barang);
        }

        // POST: barangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var barang = await _context.barang.FindAsync(id);
            _context.barang.Remove(barang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool barangExists(int id)
        {
            return _context.barang.Any(e => e.id == id);
        }
    }
}
