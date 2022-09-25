using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{

    internal class Program
    {
        class Car
        {
            public string model;
            public int enginespeed;
            public int enginepower;
            public int cargoweight;
            public string cargotype;
        }
        class Tires
        {
            public double tire1, tire2, tire3, tire4, tire5, tire6, tire7, tire8;
        }
        static Car CarCreate(string[] array1)
        {
            Car carcreate = new Car();
            carcreate.model = array1[0];
            carcreate.enginespeed = Convert.ToInt32(array1[1]);
            carcreate.enginepower = Convert.ToInt32(array1[2]);
            carcreate.cargoweight = Convert.ToInt32(array1[3]);
            carcreate.cargotype = array1[4];
            return (carcreate);
        }
        static Tires TiresCreate(string[] array1)
        {
            Tires tirescreate = new Tires();
            tirescreate.tire1 = Convert.ToDouble(array1[5]);
            tirescreate.tire2 = Convert.ToDouble(array1[6]);
            tirescreate.tire3 = Convert.ToDouble(array1[7]);
            tirescreate.tire4 = Convert.ToDouble(array1[8]);
            tirescreate.tire5 = Convert.ToDouble(array1[9]);
            tirescreate.tire6 = Convert.ToDouble(array1[10]);
            tirescreate.tire7 = Convert.ToDouble(array1[11]);
            tirescreate.tire8 = Convert.ToDouble(array1[12]);
            return (tirescreate);
        }
        static void Print(Car cartoprint)
        {
            Console.WriteLine(cartoprint.model);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Cars: ");
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            Tires[] tires= new Tires[n];
            for (int i = 0; i < n; i++)
            {
                string strarray = Console.ReadLine();
                string[] array1 = strarray.Split(' ');
                tires[i] = TiresCreate(array1);
                cars[i] = CarCreate(array1);
            }
            string str=Console.ReadLine();
            if (str == "fragile")
            {
                for (int i = 0; i < n; i++)
                {
                    double[]doublearray=new double[8] { tires[i].tire1, tires[i].tire2, tires[i].tire3, tires[i].tire4, tires[i].tire5, tires[i].tire6, tires[i].tire7, tires[i].tire8 };
                    Array.Sort(doublearray);
                    if (doublearray[0] < 1 && cars[i].cargotype=="fragile")
                    {
                        Print(cars[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (cars[i].enginepower >= 250 && cars[i].cargotype=="flamable")
                    {
                        Print(cars[i]);
                    }
                }
            }
        }
    }
}