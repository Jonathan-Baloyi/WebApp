using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Models;

namespace WebApp.Controllers
{

    [Route("api/subjects")]
    public class SubjectController : Controller
    {

        private SchoolContext context;

        public SubjectController(SchoolContext _context)
        {
            this.context = _context;
            
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Subjects> Get()
        {
            return context.Subjects.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Subjects Get(int id)
        {
            return context.Subjects.Find(id);
        }

        // POST api/values
        [HttpPost]
        public Subjects Post([FromBody] Subjects subjects)
        {
            context.Subjects.Add(subjects);
            context.SaveChanges();
            return subjects;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Subjects Put(int id, [FromBody] Subjects subjects)
        {
            if(id != subjects.Id)
            {
                throw new Exception("invalid operation");
            }

            context.Subjects.Update(subjects);
            context.SaveChanges();

            return subjects;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var subject = context.Subjects.Find(id);
            context.Subjects.Remove(subject);
            context.SaveChanges();

        }
    }
}