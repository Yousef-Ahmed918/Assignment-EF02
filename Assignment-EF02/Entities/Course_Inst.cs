﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF02.Entities
{
    internal class Course_Inst
    {
       
        
        public  string? Evaluate { get; set; }

        public Course Course { get; set; }
        public int  CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public int InstructorId { get; set; }
    }
}
