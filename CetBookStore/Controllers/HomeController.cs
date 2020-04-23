using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CetBookStore.Models;
using CetBookStore.ViewModel;
using CetBookStore.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CetBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private object searchModel;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<ActionResult> Search()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id");
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Search(SearchViewModel searchModel)
        {
            var title = searchModel.SearchText;
            return View();
        }
    }
}
