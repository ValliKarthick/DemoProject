using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class EmployeeDetails
    {
        public enum Gender
        {
            Female = 1, 
            Male = 2, 
            Other = 3 
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Contact { get; }
        public string Seniority { get; set; }

        public void GetEmployeePersonalDetail() {
            for (int employeeCount = 1; employeeCount <= 10; employeeCount++)
            {
                Console.WriteLine("Enter Your Name");
                string employeeName = Console.ReadLine();
                Console.WriteLine("Enter Your Age");
                int employeeAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Contact");
                int employeeGender = Convert.ToInt32(Console.ReadLine())
                
            }
        }
        public int CalculateSalary() {
            int hra=10;
            int PF = 5;
            int salary;
            
            Looping:
            if (hra < 5)
            {
                if(PF > 100)
                {
                    salary = 10000 + 500 + 10;
                }
                else
                salary = 10000 + 500;
            }
                else if (hra > 5)
            {
                salary = 10000 + 5000;
            }
            else
            {
                salary = 10000 + 500;
                goto Looping;
            }
            
            return 100;
        }

        public string GetEmployeeWorkDetail()
        {
            return "Name";
        } 
    }
}
