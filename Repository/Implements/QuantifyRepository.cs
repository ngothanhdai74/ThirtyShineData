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
            var products = db.Product.Take(5).ToList();
            var services = db.Service.Take(2).ToList();
            //--------------------------------------------------------
            var firstSalon = db.TblSalon.FirstOrDefault().Id;
            // create data BillServiceHis and FlowService
            string notebillServiceHis = "bill de test daint";
            //======================================================
            var billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == firstSalon).ToList();
            //--
            db.BillServiceHis.RemoveRange(billServiceHisSearch);
            db.SaveChanges();
            //--
            var max = db.BillServiceHis.Max(max => max.Id);
            for (int i = 0; i < 5; i++)
            {
                db.BillServiceHis.Add(new BillServiceHis()
                {
                    Id = 10000000 + i,
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
            billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == firstSalon).ToList();
            //----------------------------------------------------------------------------------------------------------------------------------------------
            foreach (var item in billServiceHisSearch)
            {
                db.FlowService.Add(new FlowService()
                {
                    BillId = item.Id,
                    ServiceId = services[0].Id,
                });
                db.FlowService.Add(new FlowService()
                {
                    BillId = item.Id,
                    ServiceId = services[1].Id,
                });
                var res = db.SaveChanges();
                if (res <= 0)
                {
                    throw new Exception();
                }
            }
            //----------------------------------------
            var today = DateTime.Now;
            var yesterday = today.AddDays(-(1));
            var billservices = from s in db.BillServiceHis
                           join f in db.FlowService on s.Id equals f.BillId
                           where s.IsDelete == 0 && f.IsDelete == 0 && s.SalonId == firstSalon
                           && s.CompleteBillTime.GetValueOrDefault() > yesterday && s.CompleteBillTime.GetValueOrDefault() <= today
                           select f;

        }
    }
}
