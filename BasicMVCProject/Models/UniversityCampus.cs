using System;
using System.Collections.Generic;

namespace BasicMVCProject.Models
{
    public class UniversityCampus
    {
        public UniversityCampus()
        {
            Students = new List<Student>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
