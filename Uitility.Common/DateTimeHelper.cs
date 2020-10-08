using System;
using System.Collections.Generic;
using System.Text;

namespace Uitility.Common
{
    public static class DateTimeHelper
    {
        public static DateTime ToVietNameDateTime(this DateTime dateTime)
        {
            try
            {
                //var tzis = TimeZoneInfo.GetSystemTimeZones();
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
                return TimeZoneInfo.ConvertTimeFromUtc(dateTime, cstZone);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
