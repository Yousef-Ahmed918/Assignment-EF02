using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment_EF02.Data
{
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.Property<int>("inst_ID")
                 .HasColumnType("int");
           
            builder.Property<int>("Course_ID")
                 .HasColumnType("int");

            builder.Property<string> ("Evaluate")
                .HasColumnType("varchar")
                .HasMaxLength (30);

            builder.HasKey(table => new { table.Inst_ID, table.Course_ID });

        }
    }
}
