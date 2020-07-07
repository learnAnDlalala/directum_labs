using System;
using System.Collections.Generic;
using System.Text;

namespace _9hLEcture
{
    public class MyTestClass
    {
        private int value1;
        private readonly int value2 = 555;

        public string Name { get; set; }
        public MyTestClass (int a)
        {
            this.value1 = a;
        }
        public int Sum ()
        {
            return this.value1 + this.value2;
        }
    }
}
