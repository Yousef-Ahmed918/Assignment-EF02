using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF02.Entities
{
    internal class Course
    {
        //One to many RelationShip
        public int? TopicId { get; set; }
        public Topic? Topic { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

        public ICollection<Course_Inst> course_Insts { get; set; } =new HashSet<Course_Inst>();
    }
}
