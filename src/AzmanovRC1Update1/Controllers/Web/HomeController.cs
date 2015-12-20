using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Azmanov.Data;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AzmanovRC1Update1.Controllers.Web
{
    public class HomeController : Controller
    {
        private AzmanovContext _context;

        public HomeController(AzmanovContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var v = _context.Autobiographies.ToList();
            return View();
        }
    }
}
