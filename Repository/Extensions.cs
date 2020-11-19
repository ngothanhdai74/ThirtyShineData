using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public static class Extensions
    {
        public static T Cast<T>(this object obj)
            where T : struct
        {
            if(obj != DBNull.Value)
            {
                return (T)obj;
            }
            return default;
        }
        public static T? CastNullable<T>(this object obj)
            where T : struct 
        {
            if (obj != DBNull.Value)
            {
                return (T?)obj;
            }
            return default;
        }
    }
}
