using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace T1708E_Website.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string RollNumber { get; set; }
        public string Name { get; set; }
    }
}
