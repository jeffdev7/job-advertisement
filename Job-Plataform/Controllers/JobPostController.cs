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
            var jobFromDb = _dbContext.JobPosts.Where(_ => _.OwnerUserName == User.Identity.Name).ToList();
            return View(jobFromDb);
        }
        public IActionResult CreateEditJobPost(int id)
        {
            if(id != 0)
            {
                var jobFromDb = _dbContext.JobPosts.SingleOrDefault(_ => _.Id == id);

                if(jobFromDb != null)
                {
                    return View(jobFromDb);
                }
                else
                {
                    return NotFound();
                }
                
            }
            return View();
        }
        public IActionResult CreateEditJob(JobPost job, IFormFile fileForImage)
        {
            job.OwnerUserName = User.Identity.Name;

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
                jobFromDb.OwnerUserName = job.OwnerUserName;
                
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult DeleteJobPost(int id)
        {
            if(id == 0)
                return BadRequest();

            var jobFromDb = _dbContext.JobPosts.SingleOrDefault(_ => _.Id == id);

            if( jobFromDb == null)
                return NotFound();

            _dbContext.JobPosts.Remove(jobFromDb);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}