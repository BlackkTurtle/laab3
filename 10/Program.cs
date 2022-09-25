using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _10
{

    internal class Program
    {
        class Engine
        {
            public string model;
            public int power;
            public int displacement;
            public string efficiency="n/a";
        }
        class Car
        {
            public string model;
            public string engine;
            public string weight="n/a";
            public string color = "n/a";
        }
        static Car CarCreate(string[] array1)
        {
            Car carcreate = new Car();
            carcreate.model = array1[0];
            carcreate.engine = array1[1];
            if(array1.Length == 4)
            {
                carcreate.weight = array1[2];
                carcreate.color= array1 [3];
            }else if(array1.Length == 3)
            {
                try
                {
                    int exception=Convert.ToInt32(array1[2]);
                    carcreate.weight = array1[2];
                }
                catch (Exception)
                {
                    carcreate.color=array1[2];
                }
            }
            return (carcreate);
        }
        static Engine EngineCreate(string[] array1)
        {
            Engine enginecreate = new Engine();
            enginecreate.model = array1[0];
            enginecreate.power = Convert.ToInt32(array1[1]);
            enginecreate.displacement=Convert.ToInt32(array1[2]);
            if (array1.Length == 4)
            {
                enginecreate.efficiency = array1[3];
            }
            return (enginecreate);
        }
        static void Print(Car cartoprint,Engine enginetoprint)
        {
            Console.WriteLine(cartoprint.model+" :");
            Console.WriteLine(cartoprint.engine+" :");
            Console.WriteLine("Power : "+enginetoprint.power);
            Console.WriteLine("Dosplacement : "+enginetoprint.displacement);
            Console.WriteLine("Efficiency : " + enginetoprint.efficiency);
            Console.WriteLine("Weight : "+cartoprint.weight);
            Console.WriteLine("Color : " + cartoprint.color);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Engines: ");
            int n = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[n];
            for (int i = 0; i < n; i++)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                engines[i] = EngineCreate(array1);
            }
            Console.WriteLine("Number of Cars: ");
            int n1 = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n1];
            for (int i = 0; i < n1; i++)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                cars[i] = CarCreate(array1);
            }
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = 0; j < engines.Length; j++)
                {
                    if (cars[i].engine == engines[j].model)
                    {
                        Print(cars[i], engines[j]);
                    }
                }
            }
        }
    }
}
