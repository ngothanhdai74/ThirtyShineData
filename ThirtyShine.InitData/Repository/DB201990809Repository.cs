using DB201990809;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyShine.InitData
{
    public class DB201990809Repository
    {
        public static async Task Handler()
        {
            await CloneDataFromSalonToSalonAudit();
        }
        public static async Task CloneDataFromSalonToSalonAudit()
        {
            using (var db = new _20190809Context())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {

                        await transaction.CommitAsync();
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
