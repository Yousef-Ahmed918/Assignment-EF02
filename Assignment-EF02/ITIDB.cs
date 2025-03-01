using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_EF02.Data;
using Assignment_EF02.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment_EF02
{
    internal class ITIDB :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L9C5J8O;Database=ITI ; Integrated Security =True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(e =>
            {
                e.Property<int>("Id")
                .UseIdentityColumn()
                .HasColumnType("int");


                e.Property<string>("Name")
                .HasColumnType("varchar")
                .HasMaxLength(50);

                e.Property<int>("Duration")
                .HasColumnType("int");

                e.Property<string>("Description")
                .HasColumnType("varchar")
                .HasMaxLength(250);

                e.Property<int>("Top_Id")
               .HasColumnType("int");
            });

            //Student Department Relation
            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.students)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(e=>e.DepartmentId)
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.NoAction); 

            //modelBuilder.Entity<Student>()
            //    .HasOne(d => d.Department)
            //    .WithMany(s => s.students);

            //Instructor Department manage Relation
            //modelBuilder.Entity<Department>()
            //    .HasOne(i => i.Manager)
            //    .WithOne(d => d.ManageDepartment)
            //    .HasForeignKey<Department>(d => d.ManagerId)
            //    .IsRequired(false);

            //modelBuilder.Entity<Instructor>()
            //    .HasOne(d=>d.Department)
            //    .WithOne(i=>i.Manager) 
            //    .HasForeignKey<Department>(d=>d.ManagerId)

            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
        }
    public DbSet<Student> Students { get; set; }
    public DbSet<Topic> topics { get; set; }
    public DbSet<Department> Departments { get; set; }
    }

}
