using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{

    internal class Program
    {
        class Person
        {
            private string name;
            private int age;
            public string Name;
            public int Age;
        }
        static Person PersonNameplusAge(string b, int a)
        {
            Person personnoname = new Person();
            personnoname.Name = b;
            personnoname.Age = a;
            return (personnoname);
        }
        static Person TheOldestPerson(Person[] people)
        {
            var oldestperson=people[0];
            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldestperson.Age)
                {
                    oldestperson=people[i];
                }
            }
            return (oldestperson);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of people: ");
            int n=int.Parse(Console.ReadLine());
            Person[] people= new Person[n];
            for (int i = 0; i < n; i++)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                string str = array1[0];
                int b = Convert.ToInt32(array1[1]);
                people[i] = PersonNameplusAge(str, b);
            }
            var oldestperson = TheOldestPerson(people);
            Console.WriteLine(oldestperson.Name + " " + oldestperson.Age);
        }  
    }
}
