using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_EF02.Data
{
    internal class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.Property(s => s.Stud_ID)
                .HasColumnName("Stud_ID")
                .HasColumnType("int");

            builder.Property(s => s.Course_ID)
                .HasColumnName("Course_ID")
                .HasColumnType("int");

            builder.Property(s => s.Grade)
                .HasColumnName("Grade")
                .HasColumnType("int");

            builder.HasKey(k => new { k.Stud_ID, k.Course_ID });

        }
    }
}
