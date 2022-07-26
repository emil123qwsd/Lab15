using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            Console.WriteLine("Введите первый член арифметической прогресии");
            int a1 = Convert.ToInt32(Console.ReadLine());
            arith.SetStart(a1);
            Console.WriteLine("Введите шаг арифметической прогресии");
            int an = Convert.ToInt32(Console.ReadLine());
            arith.setStep(an);
            int counter = 1;
            Console.WriteLine("Введите число членов арифметической прогресии");
            int N = Convert.ToInt32(Console.ReadLine());
            while (counter <= N) 
            {
                Console.WriteLine(arith.GetNext());
                counter++;
            }
            //Console.WriteLine(arith.GetNext());
            //Console.WriteLine(arith.GetNext());
            //Console.WriteLine(arith.GetNext());
            arith.reset();
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());

            GeoProgression geo = new GeoProgression();
            Console.WriteLine("Введите первый член геометрической прогресии");
            int g1 = Convert.ToInt32(Console.ReadLine());
            geo.SetStart(g1);
            Console.WriteLine("Введите шаг геометрической прогресии");
            int gn = Convert.ToInt32(Console.ReadLine());
            geo.setStep(gn);
            int counter2 = 1;
            Console.WriteLine("Введите число членов арифметической прогресии");
            int N2 = Convert.ToInt32(Console.ReadLine());
            while (counter2 <= N2)
            {
                Console.WriteLine(geo.GetNext());
                counter2++;
            }
            //Console.WriteLine(geo.GetNext());
            //Console.WriteLine(geo.GetNext());
            //Console.WriteLine(geo.GetNext());
            geo.reset();
            Console.WriteLine(geo.GetNext());
            Console.WriteLine(geo.GetNext());
            Console.ReadKey();
        }
    }
}
