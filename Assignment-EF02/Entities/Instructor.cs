using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment_EF02.Entities
{
    internal class Instructor
    {
        //instructor department relation (Work)
        [InverseProperty(nameof(Entities.Department.Instructors))]
        public Department? Department { get; set; }

        //instructor department relation (Manage)
        [InverseProperty(nameof(Entities.Department.Manager))]
        public Department? ManageDepartment { get; set; }

        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
