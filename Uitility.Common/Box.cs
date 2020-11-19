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
}
