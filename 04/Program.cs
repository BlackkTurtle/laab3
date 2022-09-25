using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
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
        static int HigherInAlphabet(Person persona,Person personb)
        {
            string str;
            str = persona.Name;
            char[] array1 = str.ToCharArray();
            str = personb.Name;
            char[] array2 = str.ToCharArray();
            if (array1.Length <= array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    char chara = Convert.ToChar(array1[i]);
                    int a = char.ToUpper(chara) - 64;
                    char charb = Convert.ToChar(array2[i]);
                    int b = char.ToUpper(charb) - 64;
                    if (a < b)
                    {
                        return 1;
                    }
                    else if (i == array1.Length - 1)
                    {
                        return 1;
                    }
                    else if (b < a)
                    {
                        return 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    char chara = Convert.ToChar(array1[i]);
                    int a = char.ToUpper(chara) - 64;
                    char charb = Convert.ToChar(array2[i]);
                    int b = char.ToUpper(charb) - 64;
                    if (a > b)
                    {
                        return 0;
                    }
                    else if (i == array2.Length - 1)
                    {
                        return 0;
                    }
                    else if (b > a)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        static Person PersonNameplusAge(string b, int a)
        {
            Person personnoname = new Person();
            personnoname.Name = b;
            personnoname.Age = a;
            return (personnoname);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of people: ");
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                string str = array1[0];
                int b = Convert.ToInt32(array1[1]);
                people[i] = PersonNameplusAge(str, b);
            }
            people=people.Where(x => x.Age > 30).ToArray();
            if (people.Length > 1)
            {
                for (int i = 0; i < people.Length - 1; i++)
                {
                    for (int j = 0; j < people.Length - 1; j++)
                    {
                        if (HigherInAlphabet(people[j], people[j + 1]) > 0==false)
                        {
                            var higherpeople=people[j];
                            people[j] = people[j + 1];
                            people[j + 1] = higherpeople;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine(people[0].Name + " - " + people[0].Age);
            }
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Name+" - "+people[i].Age);
            }
        }
    }
}
