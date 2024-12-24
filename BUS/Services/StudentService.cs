using BUS.DTO;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class StudentService
    {
        DbStudent db = new DbStudent();
        public List<Student> GetAllStudents()
        {
            return db.Students.AsNoTracking().ToList();
        }

        public List<Student> GetAllNoMajor()
        {
            return db.Students.Where(s => s.MajorID == null).ToList();
        }
        public List<Student> GetAllNoMajor(int facultyID)
        {
            return db.Students.Where(s => s.MajorID == null && s.FacultyID == facultyID).ToList();
        }

        public Student FindById(string studentId)
        {
            return db.Students.FirstOrDefault(s => s.StudentID == studentId);
        }

        public void UpdateInsert(Student student)
        {
            db.Students.AddOrUpdate(student);
            db.SaveChanges();
        }

        public void Delete(Student student)
        {
            db.Students.Remove(student);
            db.SaveChanges();
        }

    }
}
