using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_9
{
    public class StudentManagementSystem
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(string name, int age)
        {
            students.Add(new Student(name,age));
        }
        public void RemoveStudent(string name)
        {
            foreach (Student student in students)
            {
                if(student.Name == name)
                {
                    students.Remove(student);
                }
            }  
        }

        public Student GetStudent(string name)
        {
            var s = students.Find(x => x.Name == name);
            return s;
        }

        public void Print()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age}");
            }

        }
        


    }
}
