using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности r=");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра окружности (х0;у0)");
            Console.Write("Введите координаты центра окружности x0= ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты центра окружности y0= ");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки (х;у)");
            Console.Write("Введите x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y= ");
            double y = Convert.ToDouble(Console.ReadLine());

            double length = Circle.Getlength(r);
            double Square = Circle.GetSquare(r);
            Boolean Prinad = Circle.GetPrinad(x, y, x0, y0, r);

            Console.WriteLine($"Длина окружности = {length} \nПлощадь круга = {Square} \nПринаддежность точки кругу - {Prinad}");
            Console.ReadKey();
        }
    }
}
