using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Grades
    {
        public int Id { get; set; }
        public Subjects Subjects { get; set; }
        public int Score { get; set; }
        public TestType TestType { get; set; }
    }
}
