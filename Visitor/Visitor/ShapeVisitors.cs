using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <summary>
    /// Интерфейс посетителя форм.
    /// </summary>
    public interface IShapeVisitor
    {
        /// <summary>
        /// Обрабатывает форму типа куб.
        /// </summary>
        /// <param name="cube">Объект с параметрами куба.</param>
        /// <returns>Результат посещения куба.</returns>
        double Visit(Cube cube);

        /// <summary>
        /// Обрабатывает форму типа сфера.
        /// </summary>
        /// <param name="sphere">Объект с параметрами сферы.</param>
        /// <returns>Результат посещения сферы.</returns>
        double Visit(Sphere sphere);

        /// <summary>
        /// Обрабатывает форму типа параллелепипед.
        /// </summary>
        /// <param name="par">Объект с параметрами параллелепипеда.</param>
        /// <returns>Результат посещения параллелепипеда.</returns>
        double Visit(Parallelepiped par);

    }

    /// <summary>
    /// Посетитель форм для нахождения объема.
    /// </summary>
    public class VolumeVisitor : IShapeVisitor
    {
        /// <summary>
        /// Находит объем куба.
        /// </summary>
        /// <param name="cube">Объект с параметрами куба.</param>
        /// <returns>Объем куба cube</returns>
        public double Visit(Cube cube) => Math.Pow(cube.Side, 3);

        /// <summary>
        /// Находит объем Сферы.
        /// </summary>
        /// <param name="sphere">Объект с параметрами сферы.</param>
        /// <returns>Объем сферы sphere</returns>
        public double Visit(Sphere sphere) => 4 / 3 * Math.PI * Math.Pow(sphere.Radius, 3);

        /// <summary>
        /// Находит объем параллелепипеда.
        /// </summary>
        /// <param name="par">Объект с параметрами параллелепипеда.</param>
        /// <returns>Объем параллелепипеда par</returns>
        public double Visit(Parallelepiped par) => par.A * par.B * par.C;
    }

    /// <summary>
    /// Посетитель форм для нахождения площади поверхности.
    /// </summary>
    public class AreaVisitor : IShapeVisitor
    {
        /// <summary>
        /// Находит площадь поверхности куба.
        /// </summary>
        /// <param name="cube">Объект с параметрами куба.</param>
        /// <returns>Площадь поверхности куба cube</returns>
        public double Visit(Cube cube) => 6 * Math.Pow(cube.Side, 2);

        /// <summary>
        /// Находит площадь поверхности сферы.
        /// </summary>
        /// <param name="sphere">Объект с параметрами сферы.</param>
        /// <returns>Площадь поверхности сферы sphere</returns>
        public double Visit(Sphere sphere) => 4 * Math.PI * Math.Pow(sphere.Radius, 2);

        /// <summary>
        /// Находит площадь поверхности параллелепипеда.
        /// </summary>
        /// <param name="par">Объект с параметрами параллелепипеда.</param>
        /// <returns>Площадь поверхности параллелепипеда par</returns>
        public double Visit(Parallelepiped par) => 2 * (par.A * par.B + par.A * par.C + par.B * par.C);
    }
}
