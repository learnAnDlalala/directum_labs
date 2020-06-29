using System;

namespace Figures
{
    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Get value of radius
        /// </summary>
        public double Radius
        {
            get;
        }

        /// <summary>
        /// Area of Circle = 0
        /// </summary>
        /// <returns> message about Area </returns>
        public override double GetArea()  // Возвращать string - плохой вариант. Лучше всё же вернуть 0.
        {
            return 0;
        }

        /// <summary>
        /// Length of Circle
        /// </summary>
        /// <returns> Length double </returns>
        public double GetLength()
        {
            return 2 * Math.PI * this.Radius;
        }
        /// <summary>
        /// Circle class
        /// </summary>
        /// <param name="x">cooridenate x int</param>
        /// <param name="y">coordinate y int</param>
        /// <param name="radius"> radius double</param>
        public Circle(int x, int y, double radius)
            : base(x, y)
        {
            this.Radius = radius;
        }
    }
}
