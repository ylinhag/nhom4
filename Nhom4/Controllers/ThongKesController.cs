using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nhom4.Models;

namespace Nhom4.Controllers
{
    public class ThongKesController : Controller
    {
        private readonly TinTucContext _context;

        public ThongKesController(TinTucContext context)
        {
            _context = context;
        }

        // GET: ThongKes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TinTuc.ToListAsync());
        }

    }
}
