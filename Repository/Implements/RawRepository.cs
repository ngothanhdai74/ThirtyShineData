using Repository.Database.Default;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class RawRepository
    {
        public static async Task Test()
        {
            using(var db = new Solution30ShineContext())
            {
                string sql = @"select top 100 * from IvOrder where Note = 'Auto Quantify Supplies'";

            }
        } 
    }
}
