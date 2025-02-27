using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_EF02.Data
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property<int>("Id")
                .HasColumnType("int")
                .UseIdentityColumn();

            builder.Property<string>("Name")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property<int>("Bouns")
                .HasColumnType("int");

            builder.Property<decimal>("Salary")
            .HasColumnType("decimal(12,2)");

            builder.Property<string>("Address")
                .HasColumnType("varchar")
                .HasMaxLength(50);

           builder.Property<int> ("HourRate")
                .HasColumnType("int");
           
            builder.Property<int> ("Dept_Id")
                .HasColumnType("int");
        }
    }
}
