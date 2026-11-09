using System;
using System.Collections.Generic;

namespace BasicMVCProject.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int CampusId { get; set; }
        public virtual UniversityCampus Campus { get; set; }
    }
}
