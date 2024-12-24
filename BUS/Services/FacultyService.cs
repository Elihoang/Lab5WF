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
    public class FacultyService
    {
        DbStudent db = new DbStudent();
        public List<Faculty> GetAll()
        {
            return db.Faculties.ToList();
        }
    }
}
