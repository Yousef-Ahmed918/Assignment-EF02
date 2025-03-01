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
            builder.Property(s => s.StudentId)
                .HasColumnType("int");

            builder.Property(s => s.CourseId)
                .HasColumnType("int");

            builder.Property(s => s.Grade)
                .HasColumnType("int");

            builder.HasKey(k => new { k.StudentId, k.CourseId });

        }
    }
}
