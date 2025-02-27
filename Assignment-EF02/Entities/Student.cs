﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF02.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public required string FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }

        public int Dep_Id { get; set; }
    }
}
