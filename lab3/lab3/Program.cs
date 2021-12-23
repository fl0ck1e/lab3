using System;
using MyCount;

namespace START
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь района обслуживания: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите площадь покрытия базовой станции");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффицент застройки:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите первый радиус: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй радиус: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третий радиус: ");
            double f = Convert.ToDouble(Console.ReadLine());
            if (c == 0)
            {
                Console.WriteLine("Ошибка! Коэффицент застройки должен быть больше 0");
            }
            Count start = new Count();
            int Result = start.values(a,b,c,d,e,f);
        }
    }
    
}
