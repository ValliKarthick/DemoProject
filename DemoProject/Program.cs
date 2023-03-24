using System;

namespace DemoProject
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.GetEmployeePersonalDetail();
            employeeDetails.GetEmployeeWorkDetail();
            Console.ReadLine();

        //Employee employee = new Employee();
        //Student student = new Student();
        //employee.GetAge();
        //Console.WriteLine("Enter Your Age:");
        //int userAge = Convert.ToInt32(Console.ReadLine());
        //employee.DisplayAge(userAge);
        //Console.ReadLine();

            //Student student = new Student();
            //ListDemo listDemo = new ListDemo();

            ////Add
            //Console.WriteLine("Enter Your Name : ");
            //student.Name = Console.ReadLine();

            //Console.WriteLine("Enter Your RollNumber");
            //student.RollNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Your Location");
            //student.Location = Console.ReadLine();

            //listDemo.AddListOfStudent(student);

            ////Display
            //listDemo.DisplayStudents();

            ////Update
            //Console.WriteLine("Enter Id of the Student to be updated");
            //int idToBeUpdated = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the new name of the student");
            //string nameToBeUpdated = Console.ReadLine();

            //listDemo.UpdateStudentName(idToBeUpdated, nameToBeUpdated);

            ////Delete
            //Console.WriteLine("Enter Id of the Student to be Deleted");
            //int idToBeDeleted = Convert.ToInt32(Console.ReadLine());
            //listDemo.RemoveStudent(idToBeDeleted);




            //Employee employee = new Employee();
            //int ageOfEmployee = employee.GetAge();
            //employee.DisplayAge(ageOfEmployee);
            //student.PrintStudentName();
            //Console.WriteLine("User Name = " + student.Name);
            //Console.WriteLine("Roll Number = " + student.RollNumber);

            //if (student.Location == "Ch")
            //    student.State = "Tamilnadu";

            //else if (student.Location == "Ti")
            //    student.State = "Kerela";

            //int[] evenNums = new int[5];
            //evenNums[0] = 2;
            //evenNums[1] = 4;
            //Console.WriteLine(evenNums[0]);  //prints 2
            //Console.WriteLine(evenNums[1]);

            //Console.ReadLine();
    }
}
}
