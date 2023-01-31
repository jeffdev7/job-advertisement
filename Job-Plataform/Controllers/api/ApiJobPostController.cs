using Job_Plataform.Data;
using Job_Plataform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Job_Plataform.Controllers.api
{
    [Route("api/jobposts")]
    [ApiController]
    public class ApiJobPostController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ApiJobPostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {           
            var allPosts = _dbContext.JobPosts.ToArray();
            return Ok(allPosts);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var jobpostById = _dbContext.JobPosts.SingleOrDefault(_ => _.Id == id);

            if(jobpostById == null)
                return NotFound();

            return Ok(jobpostById);
        }

        [HttpPost("Add")]
        public IActionResult Add(JobPost job)
        {
            if(job.Id != 0)
                return BadRequest("This id already exists.");

             _dbContext.JobPosts.Add(job);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult Remove(int id)
        {
            var jobpost = _dbContext.JobPosts.SingleOrDefault(_ => _.Id == id);

            if (jobpost == null)
                return NotFound();
            
            _dbContext.JobPosts.Remove(jobpost);
            _dbContext.SaveChanges();

            return Ok("Object was deleted.");
        }

        [HttpPut("Update")]
        public IActionResult Update(JobPost job)
        {
            if (job.Id == 0)
                return BadRequest();

            _dbContext.JobPosts.Update(job);
            _dbContext.SaveChanges();

            return Ok("Object was updated.");
        }
    }
}