using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <summary>
    /// Интерфейс посещаемой формы. 
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Принимает посетителя с интерфейсом IShapeVisitor.
        /// </summary>
        /// <param name="visitor">Конкретный посетитель с интерфейсом IShapeVisitor</param>
        /// <returns>Результат работы посетителя.</returns>
        double Accept(IShapeVisitor visitor);
    }

    /// <summary>
    /// Посещаемый класс, описывающий куб.
    /// </summary>
    public class Cube : IShape
    {
        /// <summary>
        /// Сторона кубы.
        /// </summary>
        public double Side { get; }

        /// <summary>
        /// Конструктор куба.
        /// </summary>
        /// <param name="side">Сторона куба.</param>
        public Cube(double side)
        {
            Side = side;
        }

        ///<inheritdoc/>
        public double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    /// <summary>
    /// Посещаемый класс, описывающий сферу.
    /// </summary>
    public class Sphere : IShape
    {
        /// <summary>
        /// Радиус сферы.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор сферы.
        /// </summary>
        /// <param name="radius">Радиус сферы.</param>
        public Sphere(double radius)
        {
            Radius = radius;
        }

        ///<inheritdoc/>
        public double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    /// <summary>
    /// Посещаемый класс, описывающий параллелепипед.
    /// </summary>
    public class Parallelepiped : IShape
    {
        /// <summary>
        /// Первая сторона параллелепипеда.
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Вторая сторона параллелепипеда.
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Третья сторона параллелепипеда.
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Конструктор параллелепипеда.
        /// </summary>
        /// <param name="a">Первая сторона параллелепипеда.</param>
        /// <param name="b">Вторая сторона параллелепипеда.</param>
        /// <param name="c">Третья сторона параллелепипеда.</param>
        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        ///<inheritdoc/>
        public double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
