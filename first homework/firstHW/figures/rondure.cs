using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace figures
{
    using System;

    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Radius of circle
        /// </summary>
        private double radius;  // Студия делает это свойство серым и предлагает воспользоваться автосвойством. Лучше так и поступить.

        /// <summary>
        /// Get or Set value of radius
        /// </summary>
        public double Radius
        {
            get => this.radius;
            set => this.radius = value; // Можно убрать set. Объекты лучше делать неизменяемыми.
        }

        /// <summary>
        /// Area of Circle = 0
        /// </summary>
        /// <returns> message about Area </returns>
        public new string Area()  // Возвращать string - плохой вариант. Лучше всё же вернуть 0.
        {
            return "Площадь отсутствует";
        }

        /// <summary>
        /// Length of Circle
        /// </summary>
        /// <returns> Length double </returns>
        public double Length()
        {
            return 2 * Math.PI * this.Radius;
        }

        public Circle(double _x, double _y, double _radius)
            : base(_x, _y)
        {
            this.radius = _radius;
        }
    }

    /// <summary>
    /// Class Round = Circle with Area
    /// </summary>
    public class Round : Circle
    {
        /// <summary>
        /// Area of Round
        /// </summary>
        /// <returns>Area double</returns>
        public new double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public Round(double _x, double _y, double _radius)
            : base(_x, _y, _radius)
        {
        }
    }

    /// <summary>
    /// Class Ring = Round with empty middle
    /// </summary>
    public class Ring : Round
    {
        /// <summary>
        /// Thickness of Circle
        /// </summary>
        private double thickness;

        /// <summary>
        /// Get or Set value of Thickness
        /// </summary>
        public double Thickness
        {
            get => this.thickness;
            set => this.thickness = value;
        }

        /// <summary>
        /// Area of Ring
        /// </summary>
        /// <returns>Area double</returns>
        public new double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2) - Math.PI * Math.Pow(this.Radius - this.thickness, 2);
        }

        public Ring(double _x, double _y, double _radius, double _thickness)
            : base(_x, _y, _radius)
        {
            this.thickness = _thickness;
        }
    }
}