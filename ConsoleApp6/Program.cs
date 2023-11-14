using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть довжину першої сторони: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть довжину другої сторони: ");
            double side2 = double.Parse(Console.ReadLine());

            // Створення об'єкта класу Rectangle
            Rectangle myRectangle = new Rectangle(side1, side2);

            // Виведення периметру та площі на екран
            Console.WriteLine($"Периметр прямокутника: {myRectangle.Perimeter}");
            Console.WriteLine($"Площа прямокутника: {myRectangle.Area}");
        }
    }
}
