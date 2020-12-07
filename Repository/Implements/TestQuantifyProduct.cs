using Repository.Database.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class TestQuantifyProduct
    {
        public async static Task Test(int inventoryId = 3)
        {
            using (var db = new Solution30ShineContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        await Handler(db, inventoryId);
                        await transaction.CommitAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                    }
                }
            }
        }
        private async static Task Handler(Solution30ShineContext db, int inventoryId)
        {
            var inventory = db.IvInventory.Find(inventoryId);
            var serviceQuantifies = db.IvServiceQuantifyV2.ToList();
            var groupQuantifies = db.IvGroupQuantifyV2.ToList();
            var groupProductQuantifies = db.IvGroupQuantifyProductV2.ToList();
            var productQuanifies = db.IvProductQuantifyV2.ToList();

            #region Delete 
            string notebillServiceHis = "bill de test daint";
            int idBillServiceHisRange = 10000000;
            //======================================================
            var billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == inventory.SalonId && m.Id >= idBillServiceHisRange).ToList();
            db.BillServiceHis.RemoveRange(billServiceHisSearch);
            db.SaveChanges();
            //----------------------
            var ivCu = db.IvInventoryCurrent.Where(m => m.InventoryId == inventory.Id).ToList();
            if (ivCu?.Any() == true)
            {
                db.IvInventoryCurrent.RemoveRange(ivCu);
                var res = db.SaveChanges();
                if (res <= 0)
                {
                    throw new Exception();
                }
            }
            //----------------------

            #endregion
        }
    }
}
