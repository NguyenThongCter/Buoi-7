using System.Collections.Generic;
using System.Linq;
using WinFormsApp4.DAL;

namespace WinFormsApp4.BLL
{
    public class StudentService
    {
        public List<Student> GetAllStudents()
        {
            using (var context = new AppDbContext())
            {
                return context.Students.ToList();
            }
        }
    }
}