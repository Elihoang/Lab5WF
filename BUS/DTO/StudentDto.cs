using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DTO
{
    public class StudentDto
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public double AverageScore { get; set; }
        public int? FacultyID { get; set; }  
        public int? MajorID { get; set; }   
        public string Avatar { get; set; }

        
        public virtual Faculty Faculty { get; set; }
        public virtual Major Major { get; set; }
    }
}
