using StudentAPI2.Interface;
using StudentAPI2.Model;
using System.Collections.Generic;
using System.Linq;

namespace StudentAPI2.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public Student GetStudent(int id)
        {
            return _applicationDbContext.Students.FirstOrDefault(x => x.Id == id);

        }
        public List<Student> GetAllStudents()
        {
            return _applicationDbContext.Students.ToList();
        }
    }
}
