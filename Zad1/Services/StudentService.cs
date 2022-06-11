using System.Collections.Generic;
using Zad1.Models;

namespace Zad1.Services
{
    public class StudentService
    {

        private StudentFileWriter _writer;

        public StudentService()
        {
            _writer = new StudentFileWriter();
        }

        public IEnumerable<Student> getStudents()
        {
            List<string> lines = (List<string>)_writer.getStudentsFromFile();
            List<Student> students = new List<Student>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
            }
            return students;
        }

        public string addStudent(Student student)
        {
            return "";
        }
    }
}
