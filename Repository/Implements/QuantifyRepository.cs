using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Repository.Database.Default;
using Repository.Database.Default.Tables;
using Repository.Mockup;
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
            bool step1 = false, step2 = true;
            var products = db.Product.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(10).ToList();
            var services = db.Service.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(2).ToList();
            var salonIdcho = db.IvInventory.FirstOrDefault(n => n.Type == 2).SalonId;
            var salonId = db.TblSalon.FirstOrDefault(m => salonIdcho == m.Id).Id;
            var inventoryId = db.IvInventory.FirstOrDefault(m => m.SalonId == salonId)?.Id;
            if (step1)
            {
                #region Step 1
                // create data BillServiceHis and FlowService
                string notebillServiceHis = "bill de test daint";
                //======================================================
                var billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == salonId).ToList();
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
                        SalonId = salonId,
                        CompleteBillTime = DateTime.Now.AddHours(-(i)),
                        ImageChecked1 = notebillServiceHis,
                        IsDelete = 0
                    });
                    var res = db.SaveChanges();
                    if (res <= 0)
                    {
                        throw new Exception();
                    }
                }
                billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.IsDelete == 0 && m.SalonId == salonId).ToList();
                //----------------------------------------------------------------------------------------------------------------------------------------------
                foreach (var item in billServiceHisSearch)
                {
                    db.FlowService.Add(new FlowService()
                    {
                        BillId = item.Id,
                        ServiceId = services[0].Id,
                        IsDelete = 0
                    });
                    db.FlowService.Add(new FlowService()
                    {
                        BillId = item.Id,
                        ServiceId = services[1].Id,
                        IsDelete = 0
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
                                   where s.IsDelete == 0 && f.IsDelete == 0 && s.SalonId == salonId
                                   && s.CompleteBillTime > yesterday && s.CompleteBillTime <= today
                                   select f;
                var servicesGroup = from s in billservices
                                    group s by s.ServiceId;
                var models = servicesGroup.Select(m => new ServiceModel(m.Key.GetValueOrDefault(), m.Count())).ToList();
                if (ServiceModel.Compare(models) == false)
                {
                    throw new Exception("part 1 fail");
                }
                // -------------------------------------------------------------------------------------------------------------------

                #endregion
            }
            if (step2)
            {
                #region Step 2
                string groupQuantifyTest = "group daint test ";
                var servicesInput = ServiceModel.ModelMock;
                // mock group quantify
                for (int i = 1; i <= 5; i++)
                {
                    db.IvGroupQuantifyV2.Add(new IvGroupQuantifyV2()
                    {
                        IsDelete = 0,
                        GroupName = groupQuantifyTest + i,
                    });
                    var res = db.SaveChanges();
                    if (res <= 0)
                    {
                        throw new Exception();
                    }
                }
                // mock service quantify
                var groupQuantifies = db.IvGroupQuantifyV2.Where(m => m.IsDelete == 0 && m.GroupName.Contains(groupQuantifyTest)).ToList();
                foreach (var item in services)
                {
                    foreach (var subitem in groupQuantifies)
                    {
                        db.IvServiceQuantifyV2.Add(new IvServiceQuantifyV2()
                        {
                            GroupQuantifyId = subitem.Id,
                            IsDelete = 0,
                            ServiceId = item.Id
                        });
                        var res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                    }
                }
                var serviceQuantifies = db.IvServiceQuantifyV2.Where(m => m.IsDelete == 0 & services.Select(m => m.Id).ToList().Contains((int)m.ServiceId)).ToList();
                // mock product quantify
                foreach (var product in products)
                {
                    db.IvProductQuantifyV2.Add(new IvProductQuantifyV2()
                    {
                        ProductId = product.Id,
                        Volume = 3,
                        Quantify = 1,
                        IsBase = 0,
                        IsDelete = 0,
                        CreatedDate = DateTime.UtcNow.Date
                    });
                    var res = db.SaveChanges();
                    if (res <= 0)
                    {
                        throw new Exception();
                    }
                }
                var productQuantifies = db.IvProductQuantifyV2.Where(m => products.Select(m => m.Id).ToList().Contains((int)m.ProductId) && m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0).ToList();
                // mock group quantify product 
                int ii = 0;
                foreach (var groupQuantify in groupQuantifies)
                {
                    if (products.Count >= ii + 2)
                    {
                        db.IvGroupQuantifyProductV2.Add(new IvGroupQuantifyProductV2()
                        {
                            IsDelete = 0,
                            GroupQuantifyId = groupQuantify.Id,
                            CreatedDate = DateTime.UtcNow.Date,
                            ProductQuantifyId = products[ii++].Id
                        });
                        db.IvGroupQuantifyProductV2.Add(new IvGroupQuantifyProductV2()
                        {
                            IsDelete = 0,
                            GroupQuantifyId = groupQuantify.Id,
                            CreatedDate = DateTime.UtcNow.Date,
                            ProductQuantifyId = products[ii++].Id
                        });
                        var res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                    }
                }
                var productQuantifyGroup = db.IvGroupQuantifyProductV2.Where(m => products.Select(m => m.Id).ToList().Contains((int)m.ProductQuantifyId) && m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0).ToList();
                // mock inventory current
                var ivCu = db.IvInventoryCurrent.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId) && m.IsDelete == false).ToList();
                if (ivCu?.Any() == true)
                {
                    db.IvInventoryCurrent.RemoveRange(ivCu);
                    var res = db.SaveChanges();
                    if (res <= 0)
                    {
                        throw new Exception();
                    }
                }
                ii = 0;
                var modelMock = InventoryCurrentMock.GetData();
                if (modelMock.Count == products.Count)
                {
                    foreach (var product in products)
                    {
                        db.IvInventoryCurrent.Add(new IvInventoryCurrent()
                        {
                            InventoryId = inventoryId,
                            ProductId = product.Id,
                            Begin = modelMock[ii].Begin,
                            SellOrUse = modelMock[ii].SellOrUse,
                            Import = modelMock[ii].Import,
                            Export = modelMock[ii].Export,
                            CreatedDate = DateTime.UtcNow.Date,
                            IsDelete = false
                        });
                        ii++;
                        var res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                    }
                }
                ivCu = db.IvInventoryCurrent.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId) && m.InventoryId == inventoryId && m.IsDelete == false && m.CreatedDate == DateTime.UtcNow.Date).ToList();


                #endregion
            }
        }
    }
}
