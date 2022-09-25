using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{

    internal class Program
    {
        class Average
        {
            public string department;
            public double average=0;
            public int count = 0;
        }
        class Employee
        {
            public string name;
            public double salary;
            public string position;
            public string department;
            public string email="n/a";
            public int age= -1;
        }
        static Employee EmployeeCreate(string[] array1)
        {
            Employee employee = new Employee();
            employee.name = array1[0];
            employee.salary = Math.Round(Convert.ToDouble(array1[1]),2);
            employee.position = array1[2];
            employee.department = array1[3];
            if (array1.Length==6)
            {
                employee.email = array1[4];
                employee.age = Convert.ToInt32(array1[5]);
            }else if (array1.Length==5)
            {
                try
                {
                    employee.age = Convert.ToInt32(array1[4]);
                }
                catch (Exception)
                {
                    employee.email = array1[4];
                }
            }
            return (employee);
        }
        static void Print(Employee employeetoprint)
        {
            Console.WriteLine(employeetoprint.name + " " + employeetoprint.salary + " " + employeetoprint.position + " " + employeetoprint.department + " " + employeetoprint.email + " " + employeetoprint.age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of people: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] people = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                people[i] = EmployeeCreate(array1);
            }
            string[] arraydeprtments=new string[people.Length];
            for (int i = 0; i < arraydeprtments.Length; i++)
            {
                arraydeprtments[i] = people[i].department;
            }
            arraydeprtments= arraydeprtments.Distinct().ToArray();
            Average[] average = new Average[arraydeprtments.Length];
            for (int i = 0; i < average.Length; i++)
            {
                average[i].department = arraydeprtments[i];
                for (int j = 0; j < people.Length; j++)
                {
                    if (people[j].department == average[i].department)
                    {
                        average[i].count++;
                        average[i].average += people[j].salary;
                    }
                }
                average[i].average = average[i].average / average[i].count;
            }
            Average result = average.Max();
            Console.WriteLine("Highest average Salary : " + result.department);
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].department == result.department)
                {
                    Print(people[i]);
                }
            }
        }
    }
}
/*
*Pesho 120 Dev Development pesho@abv.com 28
*Toncho 333,33 Manager Marketing 33
*Ivan 840,2 ProjectLeader Development ivan@ivan
*Gosho 0,2 Freeloader Nowhere 18
 */

