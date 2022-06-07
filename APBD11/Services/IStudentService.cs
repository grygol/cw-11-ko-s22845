using System;
using System.Collections.Generic;
using APBD11.Data;

namespace APBD11.Services
{
	public interface IStudentService
	{
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public bool RemoveStudent(int id);
    }
}

