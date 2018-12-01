using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nhom4.Models;

namespace Nhom4.Controllers
{
    public class CRUDTinTucController : Controller
    {
        private readonly TinTucContext _context;

        public CRUDTinTucController(TinTucContext context)
        {
            _context = context;
        }

        // GET: CRUDTinTuc
        public async Task<IActionResult> Index()
        {
            return View(await _context.TinTuc.ToListAsync());
        }

        // GET: CRUDTinTuc/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTuc
                .FirstOrDefaultAsync(m => m.MaTin == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // GET: CRUDTinTuc/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CRUDTinTuc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTin,TieuDe,NoiDung,Anh,NgayDang,NguoiDang,MaTheLoai")] TinTuc tinTuc, string fHinh)
        {
           
            if (ModelState.IsValid)
            {
                tinTuc.Anh = fHinh;
                _context.Add(tinTuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tinTuc);
        }

        // GET: CRUDTinTuc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTuc.FindAsync(id);
            if (tinTuc == null)
            {
                return NotFound();
            }
            return View(tinTuc);
        }

        // POST: CRUDTinTuc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTin,TieuDe,NoiDung,Anh,NgayDang,NguoiDang,MaTheLoai")] TinTuc tinTuc)
        {
            if (id != tinTuc.MaTin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinTuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinTucExists(tinTuc.MaTin))
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
            return View(tinTuc);
        }

        // GET: CRUDTinTuc/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTuc = await _context.TinTuc
                .FirstOrDefaultAsync(m => m.MaTin == id);
            if (tinTuc == null)
            {
                return NotFound();
            }

            return View(tinTuc);
        }

        // POST: CRUDTinTuc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinTuc = await _context.TinTuc.FindAsync(id);
            _context.TinTuc.Remove(tinTuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TinTucExists(int id)
        {
            return _context.TinTuc.Any(e => e.MaTin == id);
        }
    }
}
