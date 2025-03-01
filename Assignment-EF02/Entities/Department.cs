using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF02.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Ins_Id { get; set; }
        public DateOnly HiringDate { get; set; }

        //One to many RelationShip (Stud dept)
        public ICollection<Student> students { get; set; }= new HashSet<Student>();

        //Instructor Department Relation (Work)
        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; }= new HashSet<Instructor>();

        //Instructor Department Relation (Manage)
        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        //Inverse Property
        [InverseProperty(nameof(Instructor.ManageDepartment))]
        public Instructor Manager { get; set; }
    }
}  
