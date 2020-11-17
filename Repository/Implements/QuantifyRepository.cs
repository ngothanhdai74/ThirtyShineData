using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Repository.Database.Default;
using Repository.Database.Default.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class QuantifyRepository
    {
        public async static Task TestQuantitySupplies()
        {
            using (var db = new Solution30ShineContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        await HandlerTest(db);
                        await transaction.CommitAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                    }
                }
            }
        }
        public async static Task HandlerTest(Solution30ShineContext db)
        {
            var firstSalon = db.TblSalon.FirstOrDefault().Id;
            // create data BillServiceHis and FlowService
            string notebillServiceHis = "bill de test daint";
            var max = db.BillServiceHis.Max(max => max.Id);
            for (int i = 0; i < 5; i++)
            {
                db.BillServiceHis.Add(new BillServiceHis()
                {
                    Id = max + i + 1,
                    SalonId = firstSalon,
                    CompleteBillTime = DateTime.Now.AddHours(-(i)),
                    ImageChecked1 = notebillServiceHis
                });
                var res = db.SaveChanges();
                if (res <= 0)
                {
                    throw new Exception();
                }
            }
            var billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == firstSalon).ToList();

        }
    }
}
