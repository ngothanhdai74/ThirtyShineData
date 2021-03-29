using System;
using System.Collections.Generic;
using System.Text;

namespace Uitility.Common
{
    public static class ConfigSettings
    {
        private static bool IsProduct = false;
        private static string ConfigSettingDev = "Data Source=10.0.2.76;Initial Catalog=20190809;Persist Security Info=True;User ID=ad_30s;Password=VDrs8XHyz3Rdc7PAiv5Q";
        private static string ConfigSettingProduction = "Data Source=10.0.6.111;Initial Catalog=Solution_30shine;Persist Security Info=True;User ID=bi;Password=654123a@A";
        public static string Connection
        {
            get
            {
                return IsProduct ? ConfigSettingProduction : ConfigSettingDev;
            }
        }
    }
}
