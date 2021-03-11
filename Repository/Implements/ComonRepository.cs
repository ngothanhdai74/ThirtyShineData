using Repository.Database.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implements
{
    public class ComonRepository
    {
        public async static System.Threading.Tasks.Task GetAsync()
        {
            using (var db = new Solution30ShineContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var init = "delete from Tbl_Config where [Key] = 'order_device_category'\n";

                        var data = db.TblConfig.Where(m => m.Key.Equals("order_device_category")).ToList().Select(m=>
                        {
                            return $"insert into Tbl_Config([Label],[Description],[Key],[Value],[IsDelete],[Status]) values (N'{m.Label}','{m.Description}','{m.Key}','{m.Value}',0,1)\n";
                        });
                        foreach (var item in data)
                        {
                            init += item;
                        }

                        await transaction.RollbackAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                    }
                }
            }
        }
    }
}
