﻿using Microsoft.EntityFrameworkCore;
using Repository.Database.Default;
using Repository.Database.Default.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class TestQuantifyProduct
    {
        public async static Task Test(int inventoryId = 3,int billCount = 100)
        {
            using (var db = new Solution30ShineContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        await Handler(db, inventoryId, billCount);
                        await transaction.CommitAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                    }
                }
            }
        }
        private async static Task Handler(Solution30ShineContext db, int inventoryId, int billCount)
        {
            var inventory = db.IvInventory.Find(inventoryId);
            var serviceQuantifies = db.IvServiceQuantifyV2.ToList();
            var groupQuantifies = db.IvGroupQuantifyV2.ToList();
            var groupProductQuantifies = db.IvGroupQuantifyProductV2.ToList();
            var productQuanifies = db.IvProductQuantifyV2.ToList();
            var distinctProducts = productQuanifies.GetProductId().ToList();
            var distinctServiceIds = serviceQuantifies.GetServiceID().ToList();
            #region Delete 
            string notebillServiceHis = "bill de test daint";
            int idBillServiceHisRange = 10000000;
            //======================================================
            var billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.Id >= idBillServiceHisRange && m.IsDelete == 0).ToList();
            db.BillServiceHis.RemoveRange(billServiceHisSearch);
            db.SaveChanges();
            var flows = db.FlowService.Where(m => m.BillId >= 10000000).ToArray();
            db.FlowService.RemoveRange(flows);
            db.SaveChanges();
            //----------------------
            //var ivCu = db.IvInventoryCurrent.Where(m => m.InventoryId == inventory.Id && m.IsDelete == false).ToList();
            //db.IvInventoryCurrent.RemoveRange(ivCu);
            //db.SaveChanges();
            ////----------------------
            //var ivMaxProductInventoryNorms = db.IvMaxServiceInventoryNorms.Where(m => m.IsDelete == false && m.InventoryId == inventoryId).ToList();
            //// mock MaxProductInventoryNorms
            //db.IvMaxServiceInventoryNorms.RemoveRange(ivMaxProductInventoryNorms);
            //db.SaveChanges();
            #endregion
            #region Add
            #region billservicehis
            for (int i = 0; i < billCount; i++)
            {
                db.BillServiceHis.Add(new BillServiceHis()
                {
                    Id = 10000000 + i,
                    SalonId = inventory.SalonId,
                    CompleteBillTime = DateTime.Now.AddHours(-(2)),
                    ImageChecked1 = notebillServiceHis,
                    IsDelete = 0
                });
            }
            var res = db.SaveChanges();
            if (res <= 0)
            {
                throw new Exception();
            }

            #endregion
            #region flow service
            billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == inventory.SalonId && m.Id >= idBillServiceHisRange && m.IsDelete == 0).ToList();
            foreach (var item in billServiceHisSearch)
            {
                db.FlowService.Add(new FlowService()
                {
                    BillId = item.Id,
                    ServiceId = 53,
                    IsDelete = 0
                });
            }
            res = db.SaveChanges();
            if (res <= 0)
            {
                throw new Exception();
            }
            #endregion
            //#region inventoryCurrent
            //foreach (var item in distinctProducts)
            //{
            //    db.IvInventoryCurrent.Add(new IvInventoryCurrent()
            //    {
            //        InventoryId = inventory.Id,
            //        ProductId = (int)item,
            //        AccountingDate = DateTime.Now.Date,
            //        Begin = 3,
            //        Import = 1,
            //        Export = 2,
            //        SellOrUse = 0,
            //        IsDelete = false,
            //        VolumeRemain = 0
            //    });
            //}
            //db.SaveChanges();
            //#endregion
            //#region inventoryNorm
            //foreach (var item in distinctProducts)
            //{
            //    db.IvMaxServiceInventoryNorms.Add(new IvMaxServiceInventoryNorms()
            //    {
            //        InventoryId = inventory.Id,
            //        ProductId = (int)item,
            //        Date = DateTime.Now.Date,
            //        MaxInventorySugges = 10,
            //        SafeInventorySugges = 3,
            //        IsDelete = false
            //    });
            //}
            //db.SaveChanges();
            //#endregion
            #endregion
        }
    }
    public static class ExtentionDb
    {
        public static IEnumerable<int?> GetProductId(this List<IvProductQuantifyV2> products)
        {
            var data = products.ToLookup(m => m.ProductId);
            foreach (var item in data)
            {
                yield return item.Key;
            }
        }
        public static IEnumerable<int?> GetServiceID(this List<IvServiceQuantifyV2> products)
        {
            var data = products.ToLookup(m => m.ServiceId);
            foreach (var item in data)
            {
                yield return item.Key;
            }
        }
    }
}
