using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{

    internal class Program
    {
        class DateModifier
        {
            public DateTime firstdate;
            public DateTime seconddate;
            public int difference;
        }
        static int DifferenceBetweenDates(DateTime d1, DateTime d2)
        {
            return (int)(d1 - d2).TotalDays;
        }
        static void Main(string[] args)
        {
            DateModifier a= new DateModifier();
            a.firstdate = Convert.ToDateTime(Console.ReadLine());
            a.seconddate = Convert.ToDateTime(Console.ReadLine());
            a.difference= DifferenceBetweenDates(a.firstdate, a.seconddate);
            if (a.difference < 0)
            {
                a.difference=Math.Abs(a.difference);
            }
            Console.WriteLine(a.difference);
        }
    }
}