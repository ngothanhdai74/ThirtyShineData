using System;
using System.Collections.Generic;
using System.Text;

namespace Uitility.Common
{
    class Box
    {
        public static bool operator ==(Box worker1, Box worker2)
        {
            return true;
        }
        public static bool operator !=(Box worker1, Box worker2)
        {
            return true;
        }
    }
    class Test
    {
        public Test()
        {
            var a = new Box();
            var b = new Box();
            var aa = a == b;
        }
    }
}
