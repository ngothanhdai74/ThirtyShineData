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
            var billServiceHis = new List<BillServiceHis>();
            string notebillServiceHis = "bill de test daint";
            for (int i = 0; i < 5; i++)
            {
                billServiceHis.Add(new BillServiceHis()
                {
                    SalonId = firstSalon,
                    CompleteBillTime = DateTime.Now.AddHours(-(++i)),
                    Note = notebillServiceHis
                });
            }
            db.BillServiceHis.AddRange(billServiceHis);
            var res = db.SaveChanges();
            if (res <= 0)
            {
                throw new Exception();
            }
            var billServiceHisSearch = db.BillServiceHis.Where(m => m.Note.Equals(notebillServiceHis) && m.SalonId == firstSalon);

        }
    }
}
