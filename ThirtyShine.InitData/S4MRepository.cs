using Microsoft.EntityFrameworkCore.Storage;
using S4M.Database;
using S4M.Table;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyShine.InitData
{
    public class S4MRepository
    {
        public static async Task Handler()
        {
            AddMenuS4M();
        }
        public static async Task ChuanHoaCheckAttendance()
        {
            using (var db = new S4MContext())
            {
                var data = db.CheckAttendance.Where(m => m.ClassId == 35);
                var haha = new List<CheckAttendance>();
                foreach (var item in data)
                {
                    if (haha.Any(m => m.StudentId == item.StudentId))
                    {
                        db.CheckAttendance.Remove(item);
                    }
                    else
                    {
                        haha.Add(item);
                    }
                }
                var dataa = db.SaveChanges();
                return;
            }
        }
        public static async Task AddMenuS4M(string menuParentName = "Giảng viên",
            string menuChildenName = "Điểm danh",
            string pageId = "/admin/diem-danh.html")
        {
            using (var db = new S4MContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var permissionMenuParent = new PermissionMenu()
                        {
                            Pid = 0,
                            Name = menuParentName,
                            Link = "javascript:void(0)",
                            Path = "javascript:void(0)",
                            IsActive = true,
                            IsDelete = false,
                        };
                        var data = db.PermissionMenu.Add(permissionMenuParent);
                        var result = await db.SaveChangesAsync();
                        if (result <= 0)
                        {
                            throw new Exception();
                        }
                        //----------------------------------------------------------------------------
                        var res = db.PermissionMenu.Where(m => m.Name.Equals(menuParentName));
                        if (res.Any() == false)
                        {
                            throw new Exception();
                        }
                        var parent = res.FirstOrDefault();
                        var permissionMenuChilden = new PermissionMenu()
                        {
                            Pid = parent.Id,
                            Name = menuChildenName,
                            Link = pageId,
                            Path = pageId,
                            IsActive = true,
                            IsDelete = false,
                            PageId = pageId
                        };
                        data = db.PermissionMenu.Add(permissionMenuChilden);
                        result = await db.SaveChangesAsync();
                        if (result <= 0)
                        {
                            throw new Exception();
                        }
                        //----------------------------------------
                        res = db.PermissionMenu.Where(m => m.Name.Equals(menuParentName) || m.Name.Equals(menuChildenName));
                        if (res.Any() == false)
                        {
                            throw new Exception();
                        }
                        foreach (var item in res)
                        {
                            var permissionMenuAction = new PermissionMenuAction()
                            {
                                PageId = item.Id,
                                PermissionId = 7,
                                ActionId = 1,
                                IsActive = true,
                                IsDelete = false
                            };
                            db.PermissionMenuAction.Add(permissionMenuAction);
                        }
                        result = await db.SaveChangesAsync();
                        if (result <= 0)
                        {
                            throw new Exception();
                        }
                        //----------------------------------------
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
