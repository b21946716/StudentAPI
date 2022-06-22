using StudentAPI2.Model;
using System.Collections.Generic;

namespace StudentAPI2.Interface
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudent(int id);
    }
}
