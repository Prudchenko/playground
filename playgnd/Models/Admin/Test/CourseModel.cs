using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace playgnd.Models.Admin.Test
{
    public class CourseModel
    {
        public Int32 Id { get; set; } //id of the course
        public string Name { get; set; } //name of the course
        public Int32 Count { get; set; } //number of tests in the course
    }
}
