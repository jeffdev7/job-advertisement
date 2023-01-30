using Job_Plataform.Data;
using Job_Plataform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Plataform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var allJobs = _dbContext.JobPosts.ToList();
            return View(allJobs);
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

        [HttpGet]
        public IActionResult GetJobPostById(int id)
        {
            if (id == 0)
                return BadRequest();

            var jobPostFromDb = _dbContext.JobPosts.SingleOrDefault(_ => _.Id == id);

            if(jobPostFromDb == null)
                return NotFound();

            return Ok(jobPostFromDb);
        }
    }
}
