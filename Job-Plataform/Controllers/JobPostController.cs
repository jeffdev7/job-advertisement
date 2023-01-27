using Job_Plataform.Data;
using Job_Plataform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace Job_Plataform.Controllers
{
    public class JobPostController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public JobPostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEditJobPost(int id)
        {
            return View();
        }
        public IActionResult CreateEditJob(JobPost job, IFormFile fileForImage)
        {
            if(fileForImage != null)
            {
                using(var ms = new MemoryStream())
                {
                    fileForImage.CopyTo(ms);
                    var bytes = ms.ToArray();
                    job.CompanyImage = bytes;
                }
            }

            if(job.Id == 0)
            {
                _dbContext.JobPosts.Add(job);
            }
            else
            {
                var jobFromDb = _dbContext.JobPosts
                    .SingleOrDefault(_ => _.Id == job.Id);

                if(jobFromDb == null)
                {
                    return NotFound();
                }

                jobFromDb.JobTitle = job.JobTitle;
                jobFromDb.JobLocation = job.JobLocation;
                jobFromDb.Descripton = job.Descripton;
                jobFromDb.Salary = job.Salary;
                jobFromDb.StartDate = job.StartDate;
                jobFromDb.CompanyName = job.CompanyName;
                jobFromDb.ContactPhone = job.ContactPhone;
                jobFromDb.ContactEmail = job.ContactEmail;
                jobFromDb.ContactWebSite = job.ContactWebSite;
                jobFromDb.CompanyImage = job.CompanyImage;
                
                _dbContext.JobPosts.Update(job);
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
