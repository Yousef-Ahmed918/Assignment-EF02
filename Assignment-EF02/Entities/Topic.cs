﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF02.Entities
{
    internal class Topic
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //One to many RelationShip
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
