using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            do
            {
                Console.Write("x = ");
                float x = float.Parse(Console.ReadLine());
                Console.Write("y = ");
                float y = float.Parse(Console.ReadLine());
                Console.Write("Радиус первой окружности = ");
                float r1 = float.Parse(Console.ReadLine());
                Console.Write("Радиус второй окружности = ");
                float r2 = float.Parse(Console.ReadLine());
                if ((x * x) + (y * y) < (r1 * r1) && (x * x) + (y * y) < (r2 * r2))
                    Console.WriteLine("Внутри");
                else if ((x * x) + (y * y) > r1 * r1 || (x * x) + (y * y) > (r2 * r2))
                    Console.WriteLine("Вне");
                else Console.WriteLine("На границе");

                
                Console.WriteLine("\n\nВыберите желаемое действие:");
                Console.WriteLine("1. Произвести рассчёты");
                Console.WriteLine("2. Выход");
                flag = Convert.ToInt32(Console.ReadLine());
            } while (flag != 2);
        }
    }
}
