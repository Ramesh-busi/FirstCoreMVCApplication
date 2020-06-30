using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }
        public string Gender { get; set; }
    }

    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
        List<Student> GetStudents();
    }

    public class TestStudentrepository : IStudentRepository
    {

        private List<Student> _studentList;
        public TestStudentrepository()
        {
            _studentList = new List<Student>()
            {
                new Student(){StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male"},
                new Student(){StudentId = 102, Name = "Kirtesh", Branch = "IT", Section = "B", Gender = "Male"},
                new Student(){StudentId = 102, Name = "Ramesh", Branch = "IT", Section = "A", Gender = "Male"},
                new Student(){StudentId = 104, Name = "Chiru", Branch = "CIVIL", Section = "B", Gender = "Male"},
                new Student(){StudentId = 105, Name = "Vinod", Branch = "EEE", Section = "A", Gender = "Male"},
                new Student(){StudentId = 106, Name = "Kishore", Branch = "EEE", Section = "B", Gender = "Male"}
                
            };
        }
        public Student GetStudentById(int studentid)
        {
            return this._studentList.FirstOrDefault(e => e.StudentId == studentid); 
        }

        public List<Student> GetStudents()

        {
            return this._studentList;
        }
    }
}
