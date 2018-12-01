using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nhom4.Controllers
{
    public class DanhSachNhomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}