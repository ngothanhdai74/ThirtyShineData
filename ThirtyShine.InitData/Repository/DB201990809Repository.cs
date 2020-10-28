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
            await QuerySalonAudit(123);
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
    }
}
