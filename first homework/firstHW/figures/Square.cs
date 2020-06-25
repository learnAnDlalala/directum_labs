﻿namespace Figures
{
    using System;
    using System.Collections.Generic;
    using System.Text;  // Лучше убирать неиспользуемые пространства имён (Ctrl R+G). И не только тут.

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
