using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        DbStudent db = new DbStudent();
        public List<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }

        public List<Student> GetAllNoMajor()
        {
            return db.Students.Where(s => s.MajorID == null).ToList();
        }
        public List <Student> GetAllNoMajor(int facultyID) 
        { 
            return db.Students.Where(s =>s.MajorID ==null && s.FacultyID == facultyID).ToList();
        }

        public Student Find(string studentId)
        {
            return db.Students.FirstOrDefault(s => s.StudentID == studentId);
        }

        public void Update(Student student)
        {
            db.Students.AddOrUpdate(student);
            db.SaveChanges();
        }
        public List<Major> GetAllMajors()
        {
            return db.Majors.ToList(); 
        }
        public List<Major> GetAllFaculty(int facultyId)
        {
            return db.Majors.Where(m => m.FacultyID == facultyId).ToList();
        }
        public List<Faculty> GetAll()
        {
            return db.Faculties.ToList();
        }
    }
}
