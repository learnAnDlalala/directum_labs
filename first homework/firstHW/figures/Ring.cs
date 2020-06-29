namespace Figures
{
    using System;

    /// <summary>
    /// Class Ring = Round with empty middle
    /// </summary>
    public class Ring : Round
    {        
        /// <summary>
        /// class Ring
        /// </summary>
        /// <param name="x">coordinate x int</param>
        /// <param name="y">coordinate y int</param>
        /// <param name="radius"> radius doubl</param>
        /// <param name="thickness">thickness double</param>
        public Ring(int x, int y, double radius, double thickness)
            : base(x, y, radius)
        {
            this.Thickness = thickness;
        }

        /// <summary>
        /// Get or Set value of Thickness
        /// </summary>
        public double Thickness
        {
            get;
        }

        /// <summary>
        /// Area of Ring
        /// </summary>
        /// <returns>Area double</returns>
        public override double GetArea()
        {
            return (Math.PI * Math.Pow(this.Radius, 2)) - (Math.PI * Math.Pow(this.Radius - this.Thickness, 2));
        }
    }
}
