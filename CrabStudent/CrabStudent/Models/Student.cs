using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrabStudent.Models
{
    public class Student
    {
        [Key]
        public String RollNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public StudentStatus Status { get; set; }

        public List<Mark> Marks { get; set; }
        public Student()
        {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Status = StudentStatus.Activated;

        }
    }

    public enum StudentStatus
    {
        Activated = 1,
        Deactived = 0
    }
}
