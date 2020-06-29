namespace Figures
{
    using System;

    /// <summary>
    /// Class Round = Circle with Area
    /// </summary>
    public class Round : Circle
    {     
        /// <summary>
        /// Construcotr Round
        /// </summary>
        /// <param name="x">coordinate x int</param>
        /// <param name="y">coordinate y int</param>
        /// <param name="radius">radius double</param>
        public Round(int x, int y, double radius)
            : base(x, y, radius)
        {
        }

        /// <summary>
        /// Area of Round
        /// </summary>
        /// <returns>Area double</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
