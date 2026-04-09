using StudentSystemAsg.Models;

namespace StudentSystemAsg.Repository_Layer
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(int id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(Student student);
    }
}
