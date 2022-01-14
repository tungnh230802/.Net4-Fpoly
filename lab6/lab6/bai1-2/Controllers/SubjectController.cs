using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab3.Models;
using lab3.services;
using Microsoft.Extensions.Logging;

namespace lab3.Controllers
{

    public class SubjectController : Controller
    {
        private readonly ILogger<SubjectController> _logger;

        public SubjectController(ILogger<SubjectController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SubjectService subjects = new SubjectService();

            return View(subjects);
        }

    }
}

