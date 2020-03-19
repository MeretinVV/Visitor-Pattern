using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // Шаблон проектирования для реализации в практической работе №5: посетитель.
    // Сделал без try-catch потому что не вижу где их в данном случае стоит использовать.
    
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape;
            IShapeVisitor visitor;
            do
            {
                chooseOperation:
                Console.WriteLine("Что вы хотите посчитать? 1 - площадь, 2 - объем.");
                switch(Console.ReadLine().Trim())
                {
                    case "1":
                        visitor = new AreaVisitor();
                        break;

                    case "2":
                        visitor = new VolumeVisitor();
                        break;

                    default:
                        Console.WriteLine("Неверный ввод, попробуйте еще раз.");
                        goto chooseOperation;
                }
                chooseShape:
                Console.WriteLine("Что вы хотите посчитать? 1 - куб, 2 - сфера, 3 - параллелепипед.");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        double side;
                        Console.Write("Введите сторону куба: ");
                        while (!double.TryParse(Console.ReadLine().Trim(), out side)) Console.WriteLine("Введите число!");
                        shape = new Cube(side);
                        break;

                    case "2":
                        double radius;
                        Console.Write("Введите радиус сферы: ");
                        while (!double.TryParse(Console.ReadLine().Trim(), out radius)) Console.WriteLine("Введите число!");
                        shape = new Sphere(radius);
                        break;

                    case "3":
                        double a, b, c;
                        Console.WriteLine("Введите поочередно три стороны: ");
                        while (!double.TryParse(Console.ReadLine().Trim(), out a)) Console.WriteLine("Введите число!");
                        while (!double.TryParse(Console.ReadLine().Trim(), out b)) Console.WriteLine("Введите число!");
                        while (!double.TryParse(Console.ReadLine().Trim(), out c)) Console.WriteLine("Введите число!");
                        shape = new Parallelepiped(a, b, c);
                        break;

                    default:
                        Console.WriteLine("Неверный ввод, попробуйте еще раз.");
                        goto chooseShape;
                }
                Console.WriteLine($"Ответ: {shape.Accept(visitor)}\n");

                Console.WriteLine("Введите 0 для выхода, иначе нажмите Enter");
                if (Console.ReadLine().Trim() == "0") break;
            } while (true);
        }
    }
}
