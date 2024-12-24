using BUS.DTO;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class MajorService
    {
        DbStudent db = new DbStudent();
        public List<Major> GetAllMajors()
        {
            return db.Majors.ToList();
        }
        public List<Major> GetAllFaculty(int facultyId)
        {
            return db.Majors.Where(m => m.FacultyID == facultyId).ToList();
        }
    }
}
