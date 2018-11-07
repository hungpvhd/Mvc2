using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrabStudent.Models
{
    public class CrabStudentContext : DbContext
    {
        public CrabStudentContext (DbContextOptions<CrabStudentContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    RollNumber = "D00529",
                    FirstName = "Hoang",
                    LastName = "Hung",
                    Email = "hungpvh00529@fpt.edu.vn"
                    
                },
                new Student()
                {
                    RollNumber = "D00530",
                    FirstName = "Hung",
                    LastName = "Hoang",
                    Email = "hungpvh00530@fpt.edu.vn"

                }
           );

            modelBuilder.Entity<Mark>().HasData(
                new Mark()
                {
                    Id = 9999,
                    SubjectName = "Java",
                    SubjectMark = 9,
                    StudentRollNumber = "D00529"
                },
                new Mark()
                {
                    Id = 9998,
                    SubjectName = "Uwp",
                    SubjectMark = 0,
                    StudentRollNumber = "D00530"
                }

                );
        }


        public DbSet<CrabStudent.Models.Student> Student { get; set; }
        public DbSet<CrabStudent.Models.Mark> Mark { get; set; }


    }
}
