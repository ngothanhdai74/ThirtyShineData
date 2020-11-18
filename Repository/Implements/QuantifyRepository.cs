using APIWarehouseManagement.Models;
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
        public async static Task<bool> TestQuantitySupplies()
        {
            using (var db = new Solution30ShineContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        await HandlerTest(db);
                        await transaction.RollbackAsync();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        return false;
                    }
                }
            }
        }
        private async static Task HandlerTest(Solution30ShineContext db)
        {
            bool step1 = true, step2 = true, step3 = true;
            var products = db.Product.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(10).ToList();
            var services = db.Service.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(2).ToList();
            var salonIdcho = db.IvInventory.FirstOrDefault(n => n.Type == 2).SalonId;
            var salonId = db.TblSalon.FirstOrDefault(m => salonIdcho == m.Id).Id;
            var productModels = ProductModel.GetMock();
            var inventory = db.IvInventory.FirstOrDefault(m => m.SalonId == salonId);
            var inventoryId = inventory.Id;
            var inventoryPartnerId = inventory.ParentId;
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
                db.IvGroupQuantifyV2.RemoveRange(db.IvGroupQuantifyV2.ToList()); db.SaveChanges();
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
                //
                db.IvServiceQuantifyV2.RemoveRange(db.IvServiceQuantifyV2.ToList()); db.SaveChanges();
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
                db.IvProductQuantifyV2.RemoveRange(db.IvProductQuantifyV2.ToList()); db.SaveChanges();
                List<IvProductQuantifyV2> mo = new List<IvProductQuantifyV2>();
                foreach (var product in products)
                {
                    mo.Add(new IvProductQuantifyV2()
                    {
                        ProductId = product.Id,
                        Volume = 3,
                        Quantify = 1,
                        IsBase = 0,
                        IsDelete = 0,
                        CreatedDate = DateTime.UtcNow.Date
                    });
                }
                for (int i = 0; i < products.Count; i = i + 2)
                {
                    mo[i].IsBase = 1;
                }
                db.IvProductQuantifyV2.AddRange(mo); db.SaveChanges();
                //
                var productQuantifies = db.IvProductQuantifyV2.Where(m => products.Select(m => m.Id).ToList().Contains((int)m.ProductId) && m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0).ToList();
                // mock group quantify product 
                int ii = 0;
                db.IvGroupQuantifyProductV2.RemoveRange(db.IvGroupQuantifyProductV2.ToList());
                db.SaveChanges();
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
                // mock QuantifyChosen

                //foreach (var product in products)
                //{
                //    db.IvQuantifyChosen.Add(new IvQuantifyChosen()
                //    {
                //        ProductId = product.Id
                //    });
                //    var res = db.SaveChanges();
                //    if (res <= 0)
                //    {
                //        throw new Exception();
                //    }
                //}
                var productChosen = db.IvQuantifyChosen.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId)).ToList();
                //-----------------------------------------------------------------------------------------------------------------------------
                var productModelsmock = new List<ProductModel>();
                foreach (var item in servicesInput)
                {
                    var productsOfService = from sq in db.IvServiceQuantifyV2
                                            join gqp in db.IvGroupQuantifyProductV2 on sq.GroupQuantifyId equals gqp.GroupQuantifyId
                                            join pq in db.IvProductQuantifyV2 on gqp.ProductQuantifyId equals pq.ProductId
                                            join ivc in db.IvInventoryCurrent on pq.ProductId equals ivc.ProductId
                                            join qc in db.IvQuantifyChosen on pq.ProductId equals qc.ProductId into gj
                                            from qc in gj.DefaultIfEmpty()
                                            where sq.ServiceId == item.ServiceId && sq.IsDelete == 0 && gqp.IsDelete == 0 && pq.IsDelete == 0 && ivc.IsDelete == false && ivc.InventoryId == inventoryId
                                            select new ProductModel
                                            {
                                                SellOrUse = ivc.SellOrUse,
                                                Begin = ivc.Begin,
                                                Export = ivc.Export,
                                                Import = ivc.Import,
                                                ProductId = ivc.ProductId,
                                                Quantify = pq.Quantify,
                                                Volume = pq.Volume,
                                                ServiceUsedCount = item.Quantity,
                                                ProductIdChosen = qc == null ? default(int?) : qc.ProductId,
                                                IsBase = pq.IsBase == 1,
                                                GroupQuantityId = sq.GroupQuantifyId,
                                            };
                    productModelsmock.AddRange(productsOfService.ToArray());
                }

                #endregion
                productModels = productModelsmock;
            }
            if (step3)
            {
                #region step 3
                var ivMaxProductInventoryNorms = db.IvMaxServiceInventoryNorms.Where(m => m.IsDelete == false && m.InventoryId == inventoryId).ToList();
                // mock MaxProductInventoryNorms
                db.IvMaxServiceInventoryNorms.RemoveRange(ivMaxProductInventoryNorms);
                db.SaveChanges();

                foreach (var product in products)
                {
                    db.IvMaxServiceInventoryNorms.Add(new IvMaxServiceInventoryNorms()
                    {
                        InventoryId = inventoryId,
                        ProductId = product.Id,
                        MaxInventorySugges = 50,
                        CreatedDate = DateTime.UtcNow.Date,
                        SafeInventorySugges = 3
                    });
                    db.SaveChanges();
                }
                ivMaxProductInventoryNorms = db.IvMaxServiceInventoryNorms.Where(m => m.IsDelete == false && m.InventoryId == inventoryId).ToList();

                //

                var order = new OrderModel()
                {
                    Code = Common.GenBillCode(inventory.ParentId, "OD", DateTime.Now),
                    CosmeticType = EnumDefine.CosmeticType.Supply,
                    InventoryOrderId = inventory.ParentId,
                    isAuto = 1,//đơn hàng xuất tự động
                    InventoryPartnerId = inventoryPartnerId,
                    OrderType = EnumDefine.OrderType.Export,
                    Status = EnumDefine.OrderStatusType.Ordered,
                };
                for (int i = 0; i < productModels.Count; i++)
                {
                    var productModel = productModels[i];
                    if (productModel.ProductIdChosen.HasValue)
                    {
                        productModel = productModels.FirstOrDefault(m => m.ProductId == productModel.ProductIdChosen && productModel.GroupQuantityId == m.GroupQuantityId);
                    }
                    else
                    {
                        productModel = productModels.FirstOrDefault(m => m.IsBase && productModel.GroupQuantityId == m.GroupQuantityId);
                        if (productModel == null)
                        {
                            productModel = productModels[i];
                        }
                    }
                    if (productModel != null)
                    {
                        var ivMaxProductInventoryNorm = ivMaxProductInventoryNorms.FirstOrDefault(m => m.ProductId == productModel.ProductId);
                        if (ivMaxProductInventoryNorm != null && ivMaxProductInventoryNorm.MaxInventorySugges > 0 && ivMaxProductInventoryNorm.SafeInventorySugges.GetValueOrDefault() > 0)
                        {
                            // nếu tồn tự động tính < tồn an toàn
                            if (productModel.InventoryRemainComputed < ivMaxProductInventoryNorm.SafeInventorySugges)
                            {
                                var supply = new OrderDetailModel()
                                {
                                    ProductId = (int)productModel.ProductId,
                                    QuantitySuggest = (int?)(ivMaxProductInventoryNorm.MaxInventorySugges - productModel.InventoryRemainComputed.Value),
                                    QuantityOrder = (int)(ivMaxProductInventoryNorm.MaxInventorySugges - productModel.InventoryRemainComputed.Value),
                                };
                                order.AddSupply(supply);
                            }
                        }
                    }
                }
                #endregion
            }
        }
        public async static Task InitData()
        {
            using (var db = new Solution30ShineContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var products = db.Product.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(10).ToList();
                        var services = db.Service.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(2).ToList();
                        var salonIdcho = db.IvInventory.FirstOrDefault(n => n.Type == 2).SalonId;
                        var salonId = db.TblSalon.FirstOrDefault(m => salonIdcho == m.Id).Id;
                        var productModels = ProductModel.GetMock();
                        var inventory = db.IvInventory.FirstOrDefault(m => m.SalonId == salonId);
                        var inventoryId = inventory.Id;
                        var inventoryPartnerId = inventory.ParentId;
                        #region Step 1
                        // create data BillServiceHis and FlowService
                        string notebillServiceHis = "bill de test daint";
                        //======================================================
                        var billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == salonId && m.IsDelete == 0).ToList();
                        //--
                        if (billServiceHisSearch.Any())
                        {
                            db.BillServiceHis.RemoveRange(billServiceHisSearch);
                            db.SaveChanges();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            db.BillServiceHis.Add(new BillServiceHis()
                            {
                                Id = 10000000 + i,
                                SalonId = salonId,
                                CompleteBillTime = DateTime.Now.AddHours(-(i)),
                                ImageChecked1 = notebillServiceHis,
                                IsDelete = 0,
                                CreatedDate = DateTime.UtcNow.Date
                            });
                        }
                        var res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.IsDelete == 0 && m.SalonId == salonId && m.CreatedDate == DateTime.UtcNow.Date).ToList();
                        //----------------------------------------------------------------------------------------------------------------------------------------------
                        foreach (var item in billServiceHisSearch)
                        {
                            db.FlowService.Add(new FlowService()
                            {
                                BillId = item.Id,
                                ServiceId = services[0].Id,
                                IsDelete = 0,
                                CreatedDate = DateTime.UtcNow.Date
                            });
                            db.FlowService.Add(new FlowService()
                            {
                                BillId = item.Id,
                                ServiceId = services[1].Id,
                                IsDelete = 0,
                                CreatedDate = DateTime.UtcNow.Date
                            });
                        }
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        #endregion

                        #region Step 2
                        string groupQuantifyTest = "group quantify daint test ";
                        // mock group quantify
                        db.IvGroupQuantifyV2.RemoveRange(db.IvGroupQuantifyV2.ToList()); db.SaveChanges();
                        for (int i = 1; i <= 5; i++)
                        {
                            db.IvGroupQuantifyV2.Add(new IvGroupQuantifyV2()
                            {
                                IsDelete = 0,
                                GroupName = groupQuantifyTest + i,
                                CreatedDate = DateTime.UtcNow.Date
                            });
                        }
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        // mock service quantify
                        var groupQuantifies = db.IvGroupQuantifyV2.Where(m => m.IsDelete == 0 && m.GroupName.Contains(groupQuantifyTest) && m.CreatedDate == DateTime.UtcNow.Date).ToList();
                        //
                        db.IvServiceQuantifyV2.RemoveRange(db.IvServiceQuantifyV2.ToList()); db.SaveChanges();
                        foreach (var item in services)
                        {
                            foreach (var subitem in groupQuantifies)
                            {
                                db.IvServiceQuantifyV2.Add(new IvServiceQuantifyV2()
                                {
                                    GroupQuantifyId = subitem.Id,
                                    IsDelete = 0,
                                    ServiceId = item.Id,
                                    CreatedDate = DateTime.UtcNow.Date
                                });
                            }
                        }
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        var serviceQuantifies = db.IvServiceQuantifyV2.Where(m => m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0 & services.Select(m => m.Id).ToList().Contains((int)m.ServiceId)).ToList();
                        // mock product quantify
                        db.IvProductQuantifyV2.RemoveRange(db.IvProductQuantifyV2.ToList()); db.SaveChanges();
                        List<IvProductQuantifyV2> mo = new List<IvProductQuantifyV2>();
                        foreach (var product in products)
                        {
                            mo.Add(new IvProductQuantifyV2()
                            {
                                ProductId = product.Id,
                                Volume = 3,
                                Quantify = 1,
                                IsBase = 0,
                                IsDelete = 0,
                                CreatedDate = DateTime.UtcNow.Date
                            });
                        }
                        for (int i = 0; i < products.Count; i = i + 2)
                        {
                            mo[i].IsBase = 1;
                        }
                        db.IvProductQuantifyV2.AddRange(mo); db.SaveChanges();
                        //
                        var productQuantifies = db.IvProductQuantifyV2.Where(m => products.Select(m => m.Id).ToList().Contains((int)m.ProductId) && m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0).ToList();
                        // mock group quantify product 
                        int ii = 0;
                        db.IvGroupQuantifyProductV2.RemoveRange(db.IvGroupQuantifyProductV2.ToList());
                        db.SaveChanges();
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
                            }
                        }
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        var productQuantifyGroup = db.IvGroupQuantifyProductV2.Where(m => products.Select(m => m.Id).ToList().Contains((int)m.ProductQuantifyId) && m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0).ToList();
                        // mock inventory current
                        var ivCu = db.IvInventoryCurrent.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId) && m.IsDelete == false && m.InventoryId == inventoryId).ToList();
                        if (ivCu?.Any() == true)
                        {
                            db.IvInventoryCurrent.RemoveRange(ivCu);
                            res = db.SaveChanges();
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
                                res = db.SaveChanges();
                                if (res <= 0)
                                {
                                    throw new Exception();
                                }
                            }
                        }
                        ivCu = db.IvInventoryCurrent.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId) && m.InventoryId == inventoryId && m.IsDelete == false && m.CreatedDate == DateTime.UtcNow.Date).ToList();
                        // mock QuantifyChosen
                        foreach (var product in products)
                        {
                            db.IvQuantifyChosen.Add(new IvQuantifyChosen()
                            {
                                ProductId = product.Id
                            });
                        }
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        var productChosen = db.IvQuantifyChosen.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId)).ToList();
                        //-----------------------------------------------------------------------------------------------------------------------------
                        #endregion
                        await transaction.CommitAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                    }
                }
            }
        }
        public async static Task DeleteData()
        {
            using (var db = new Solution30ShineContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var products = db.Product.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(10).ToList();
                        var services = db.Service.Where(m => m.IsDelete == 0).OrderBy(m => m.Id).Take(2).ToList();
                        var salonIdcho = db.IvInventory.FirstOrDefault(n => n.Type == 2).SalonId;
                        var salonId = db.TblSalon.FirstOrDefault(m => salonIdcho == m.Id).Id;
                        var productModels = ProductModel.GetMock();
                        var inventory = db.IvInventory.FirstOrDefault(m => m.SalonId == salonId);
                        var inventoryId = inventory.Id;
                        var inventoryPartnerId = inventory.ParentId;
                        //
                        var productChosen = db.IvQuantifyChosen.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId)).ToList();
                        db.IvQuantifyChosen.RemoveRange(productChosen);
                        var res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        var ivCu = db.IvInventoryCurrent.Where(m => products.Select(m => m.Id).ToList().Contains(m.ProductId) && m.InventoryId == inventoryId && m.IsDelete == false && m.CreatedDate == DateTime.UtcNow.Date).ToList();
                        // mock QuantifyChosen
                        db.IvInventoryCurrent.RemoveRange(ivCu);
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        var productQuantifyGroup = db.IvGroupQuantifyProductV2.Where(m => products.Select(m => m.Id).ToList().Contains((int)m.ProductQuantifyId) && m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0).ToList();
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        var productQuantifies = db.IvProductQuantifyV2.Where(m => products.Select(m => m.Id).ToList().Contains((int)m.ProductId) && m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0).ToList();
                        db.IvProductQuantifyV2.RemoveRange(productQuantifies);
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        var serviceQuantifies = db.IvServiceQuantifyV2.Where(m => m.CreatedDate == DateTime.UtcNow.Date && m.IsDelete == 0 & services.Select(m => m.Id).ToList().Contains((int)m.ServiceId)).ToList();
                        db.IvServiceQuantifyV2.RemoveRange(serviceQuantifies);
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        string groupQuantifyTest = "group quantify daint test ";
                        var groupQuantifies = db.IvGroupQuantifyV2.Where(m => m.IsDelete == 0 && m.GroupName.Contains(groupQuantifyTest) && m.CreatedDate == DateTime.UtcNow.Date).ToList();
                        db.IvGroupQuantifyV2.RemoveRange(groupQuantifies);
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            throw new Exception();
                        }
                        string notebillServiceHis = "bill de test daint";
                        //======================================================
                        var billServiceHisSearch = db.BillServiceHis.Where(m => m.ImageChecked1.Equals(notebillServiceHis) && m.SalonId == salonId && m.IsDelete == 0).ToList();

                        var flowServicesSearch = db.FlowService.Where(m => billServiceHisSearch.Select(m => m.Id).ToList().Contains((int)m.BillId)).ToList();


                        //--
                        if (billServiceHisSearch.Any())
                        {
                            db.FlowService.RemoveRange(flowServicesSearch);
                            db.BillServiceHis.RemoveRange(billServiceHisSearch);
                            db.SaveChanges();
                        }
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
