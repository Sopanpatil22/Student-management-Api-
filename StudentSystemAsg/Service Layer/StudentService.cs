using StudentSystemAsg.Models;
using StudentSystemAsg.Repository_Layer;

namespace StudentSystemAsg.Service_Layer
{
    public class StudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetAll()
            => await _repo.GetAll();

        public async Task<Student> GetById(int id)
        {
            var student = await _repo.GetById(id);
            if (student == null) throw new Exception("Student not found");
            return student;
        }

        public async Task Add(Student student)
            => await _repo.Add(student);

        public async Task Update(int id, Student student)
        {
            var existing = await _repo.GetById(id);
            if (existing == null) throw new Exception("Not found");

            existing.Name = student.Name;
            existing.Email = student.Email;
            existing.Age = student.Age;
            existing.Course = student.Course;

            await _repo.Update(existing);
        }

        public async Task Delete(int id)
        {
            var student = await _repo.GetById(id);
            if (student == null) throw new Exception("Not found");

            await _repo.Delete(student);
        }
    }
}
