using System;
using System.Collections.Generic;

namespace DemoProject
{
    public class ListDemo
    {
        Student student = new Student();
        List<Student> students = new List<Student>();
        public void AddListOfStudent(Student student)
        {                    
            students.Add(student);
            Console.WriteLine("Student Added Successfully..");
        }
        public void DisplayStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.Name + item.RollNumber + item.Location);
            }
        }
        public void UpdateStudentName(int id, string Name)
        {
            student = students.Find(x => x.RollNumber == id);
            student.Name = Name;
            Console.WriteLine("Student Name Updated Successfully");
        }
        public void RemoveStudent(int id)
        {
            student = students.Find(x => x.RollNumber == id);
            students.Remove(student);
            Console.WriteLine("Student Removed Successfully");
        }
    }
}
