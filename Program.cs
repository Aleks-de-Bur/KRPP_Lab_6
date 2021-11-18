using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            Console.Write("Радиус первой окружности =");
            float r1 = float.Parse(Console.ReadLine());
            Console.Write("Радиус второй окружности =");
            float r2 = float.Parse(Console.ReadLine());
            if (x * x + y * y < 9 && y > 0)
                Console.WriteLine("внутри");
            else if (x * x + y * y > 9 || y < 0)
                Console.WriteLine("вне");
            else Console.WriteLine("на границе");
        }
    }
}
