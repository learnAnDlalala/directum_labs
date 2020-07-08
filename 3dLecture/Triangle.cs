// Название файла с большой буквы и вынести классы в отдельные файлы.
namespace Figures
{
    using System;

    /// <summary>
    /// class Triangle
    /// </summary>
    public class Triangle : Shape // Треугольник наследуется от прямоугольника? Как это?
    {       
        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="x">coordinate x int</param>
        /// <param name="y">coordinate y int</param>
        /// <param name="a">1st side double</param>
        /// <param name="b">2nd side double</param>
        /// <param name="c">3d side double</param>
        public Triangle(int x, int y, double a, double b, double c)
            : base(x, y)
        {
            this.SideC = c;
            this.SideB = b;
            this.SideA = a;
        }

        /// <summary>
        /// Get or Set value 1d side
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Get or Set value 2d side
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Get or Set value 3d side
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Area calculated with half perimetr = p;
        /// </summary>
        /// <returns>Area double</returns>
        public override double GetArea()
        {
            var p = this.GetPerimetr();
            return Math.Sqrt(p * (p - this.SideA) * (p - this.SideB) * (p - this.SideC));
        }

        /// <summary>
        /// Sum of all sides;
        /// </summary>
        /// <returns>Perimetr double</returns>
        public double GetPerimetr()
        {
            return this.SideA + this.SideB + this.SideC;
        }
    }
}