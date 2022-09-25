using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
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
        static Person PersonNoName()
        {
            Person personnoname=new Person();
            personnoname.Name = "NoName";
            personnoname.Age = 1;
            return(personnoname);
        }
        static Person PersonNoNameplusAge(int a)
        {
            Person personnoname = new Person();
            personnoname.Name = "NoName";
            personnoname.Age = a;
            return (personnoname);
        }
        static Person PersonNameplusAge(string b,int a)
        {
            Person personnoname = new Person();
            personnoname.Name = b;
            personnoname.Age = a;
            return (personnoname);
        }
        static void Main(string[] args)
        {
            var person=PersonNoName();
            Console.WriteLine(person.Name+" "+person.Age);
            int a=int.Parse(Console.ReadLine());
            var person2 = PersonNoNameplusAge(a);
            Console.WriteLine(person2.Name + " " + person2.Age);
            string str=Console.ReadLine();
            int b =int.Parse(Console.ReadLine());
            var person3 = PersonNameplusAge(str, b);
            Console.WriteLine(person3.Name + " " + person3.Age);
        }
    }
}