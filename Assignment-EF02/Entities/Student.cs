using System;
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
        public int? Age { get; set; }


        //One to many RelationShip
        public int? DepartmentId { get; set; } //Navigation Property+(Id Name) in principle Table
        public Department? Department { get; set; } //Navigation Property

        public ICollection<Stud_Course> Stud_Courses { get; set; } =new HashSet<Stud_Course>();
    } 

}
