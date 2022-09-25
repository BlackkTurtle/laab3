using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{

    internal class Program
    {
        class Car
        {
            public string model;
            public double fuel;
            public double consumption;
            public int distance = 0;
        }
        static Car CarCreate(string[] array1)
        {
            Car carcreate=new Car();
            carcreate.model=array1[0];
            carcreate.fuel = Convert.ToDouble(array1[1]);
            carcreate.consumption = Convert.ToDouble(array1[2]);
            return (carcreate);
        }
        static void Print(Car cartoprint)
        {
            Console.WriteLine(cartoprint.model + " " + cartoprint.fuel + " " + cartoprint.distance );
        }
        static void Drive(string[] array1, ref Car[] cars)
        {
            string carname=array1[1];
            int km = Convert.ToInt32(array1[2]);
            for (int i = 0; i < cars.Length; i++)
            {
                if (carname == cars[i].model)
                {
                    if (km * cars[i].consumption > cars[i].fuel)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                    else
                    {
                        cars[i].fuel -= km * cars[i].consumption;
                        cars[i].distance += km;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Cars: ");
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                cars[i] = CarCreate(array1);
            }
            while (true)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                if (array1[0] == "Drive")
                {
                    Drive(array1,ref cars);
                }
                else
                {
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Print(cars[i]);
                    }
                }
            }
        }
    }
}
