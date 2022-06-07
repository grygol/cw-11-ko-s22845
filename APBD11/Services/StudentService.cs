using System;
using System.Collections.Generic;
using System.Linq;
using APBD11.Data;

namespace APBD11.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>
            {
                 new Student {
                    ID = 1,
                    FirstName = "Nigel",
                    LastName = "Navarro",
                    Birthdate = new DateTime(2001, 04, 16),
                    Studies = "IT"
                },
                new Student {
                    ID = 2,
                    FirstName = "Scott",
                    LastName = "Nolan",
                    Birthdate = new DateTime(1987, 11, 12),
                    Studies = "Architecture",
                    AvatarUrl = "https://randomuser.me/api/portraits/men/75.jpg"
                },
                new Student {
                    ID = 3,
                    FirstName = "Melyssa",
                    LastName = "Clark",
                    Birthdate = new DateTime(1992, 06, 12),
                    Studies = "Music",
                    AvatarUrl = "https://randomuser.me/api/portraits/women/2.jpg"
                },
                new Student {
                    ID = 4,
                    FirstName = "Justine",
                    LastName = "Kinney",
                    Birthdate = new DateTime(1992, 2,4),
                    Studies = "Mechanics",
                    AvatarUrl = "https://randomuser.me/api/portraits/lego/5.jpg"
                },
                new Student {
                    ID = 5,
                    FirstName = "Wing",
                    LastName = "Collier",
                    Birthdate = new DateTime(1997, 10, 25),
                    Studies = "Anthropology"
                }
            };
        }

        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(e => e.ID == id);
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public bool RemoveStudent(int id)
        {
            return _students.Remove(_students.FirstOrDefault(e => e.ID == id));
        }
    }
}

