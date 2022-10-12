
using StudentAdminPortalAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortalAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid Id);
        Task<List<Gender>> GetAllGenderAsync();
        Task<bool> Exists(Guid studentId);
        Task<Student> UpdateStudentAsync(Guid studentId, Student student);
        Task<Student> DeleteStudentAsync(Guid studentId);

    }
}
