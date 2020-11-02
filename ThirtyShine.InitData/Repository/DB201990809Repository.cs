using DB201990809;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyShine.InitData
{
    public class DB201990809Repository
    {
        public static async Task Handler()
        {
            await MoveLinkFrom2019To2020();
        }
        public static async Task CloneDataFromSalonToSalonAudit()
        {
            using (var db = new _20190809Context())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var mainSalons = db.TblSalon.Where(m => m.IsSalonHoiQuan == false);
                        foreach (var salon in mainSalons)
                        {
                            var salonAudit = new SalonAudit()
                            {
                                Id = salon.Id,
                                CreatedDate = DateTime.UtcNow,
                                IsActive = true,
                                IsDelete = false,
                                ModifiedDate = DateTime.UtcNow,
                                Name = salon.ShortName,
                            };
                            db.SalonAudit.Add(salonAudit);
                        }
                        var changeDb = db.SaveChanges();
                        if (changeDb <= 0)
                        {
                            throw new Exception();
                        }
                        //================================================
                        var salonAuditOther = new SalonAudit()
                        {
                            Id = 13,
                            CreatedDate = DateTime.UtcNow,
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = DateTime.UtcNow,
                            Name = "Khác",
                        };
                        db.SalonAudit.Add(salonAuditOther);
                        changeDb = db.SaveChanges();
                        if (changeDb <= 0)
                        {
                            throw new Exception();
                        }
                        //================================================
                        var salonAuditS4M = new SalonAudit()
                        {
                            Id = 14,
                            CreatedDate = DateTime.UtcNow,
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = DateTime.UtcNow,
                            Name = "S4M",
                        };
                        db.SalonAudit.Add(salonAuditS4M);
                        changeDb = db.SaveChanges();
                        if (changeDb <= 0)
                        {
                            throw new Exception();
                        }
                        //================================================
                        var salonAuditHQAE = new SalonAudit()
                        {
                            Id = 15,
                            CreatedDate = DateTime.UtcNow,
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = DateTime.UtcNow,
                            Name = "HQAE",
                        };
                        db.SalonAudit.Add(salonAuditHQAE);
                        changeDb = db.SaveChanges();
                        if (changeDb <= 0)
                        {
                            throw new Exception();
                        }
                        //================================================
                        await transaction.CommitAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                    }
                }
            }
        }
        public static async Task QuerySalonAudit(int userId)
        {
            using (var db = new _20190809Context())
            {
                var data = from s in db.SalonAudit 
                           where s.Id == userId
                           select s;

                var raw = data.ToSql();
            }
        }
        public static async Task MoveLinkFrom2019To2020()
        {
            using (var db = new _20190809Context())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var kho2019 = db.PermissionMenu.First(m => m.Name.Equals("Kho 2019")
                        && m.IsActive == true
                        && m.IsDelete == false
                        && m.Domain.Equals("https://inventory.30shine.com")
                        && m.Pid == 0);
                        var tktd = db.PermissionMenu.First(m => m.Name.Equals("Thống kê tiến độ") 
                        && m.Pid == kho2019.Id
                        && m.IsActive == true
                        && m.IsDelete == false
                        && m.Link.Equals("/admin/bao-cao-tien-do.html")
                        && m.Domain.Equals("https://inventory.30shine.com")
                        );
                        var kho2020 = db.PermissionMenu.First(m => m.Name.Equals("Kho 2020")
                        && m.IsActive == true
                        && m.IsDelete == false
                        && m.Pid == 0
                        && m.Domain.Equals("https://inventory.30shine.com")
                        );

                        tktd.Pid = kho2020.Id;
                        db.PermissionMenu.Update(tktd);
                        if (db.SaveChanges() <= 0)
                        {
                            throw new Exception();
                        }
                        //================================================
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
