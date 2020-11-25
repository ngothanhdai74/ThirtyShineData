using Repository.Database;
using Repository.Database.Default.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class ThailanRepository
    {
        public static async Task Process()
        {
            using(var db = new Database.Thailan.Solution30ShineContext())
            {
                var data = await get();
                foreach (var item in data)
                {
                    db.PermissionMenu.Add(new Database.Thailan.Tables.PermissionMenu()
                    {
                        Pid = item.Pid,
                        Name = item.Name,
                        Link = item.Link,
                        PageId = item.PageId,
                        ClassTag = item.ClassTag,
                        CreatedTime = item.CreatedTime,
                        Description = item.Description,
                        IconImage = item.IconImage,
                         IsActive = item.IsActive,
                         IsDelete = item.IsDelete,
                         MigrateStatus = item.MigrateStatus,
                         ModifiedTime = item.ModifiedTime,
                         Path = item.Path,
                         Title = item.Title,
                    });
                }
                var res = db.SaveChanges();

            }
        }
        public static async Task<List<PermissionMenu>> get()
        {
            using (var db = new Database.Default.Solution30ShineContext())
            {
                return db.PermissionMenu.ToList();
            }
        }
    }
}
