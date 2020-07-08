namespace Figures
{
    /// <summary>
    /// Class Square 
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Square constructor
        /// </summary>
        /// <param name="x">coordinate x int</param>
        /// <param name="y">coordinate y int</param>
        /// <param name="a">side double</param>
        public Square(int x, int y, double a)
            : base(x, y, a, a)
        { 
        }
    }
}
