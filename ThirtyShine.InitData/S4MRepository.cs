using S4M.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyShine.InitData
{
    public class S4MRepository
    {
        public static async Task Handler()
        {
            using (var db = new S4MContext())
            {
                var data = db.ScriptData.Add(new S4M.Table.ScriptData()
                {
                    Name = @"[S4M] danh sach thong tin khach hang su dung dich vu lan cuoi cach day 40 ngay.sql",
                    File = @"C:\Deploy\erp-v4.30shine.com\PublishOutput\[S4M] danh sach thong tin khach hang su dung dich vu lan cuoi cach day 40 ngay.sql"
                });
                var sa = db.SaveChanges();
                //var query = from bill in db.BillService.Where(m => m.CreatedDate >= DateTime.Now.AddDays(-40))
                //            join cus in db.Customer on bill.CustomerId equals cus.Id
                //            join salon in db.TblSalon.Where(m => m.IsSalonHoiQuan == true) on bill.SalonId equals salon.Id
                //            select new
                //            {
                //                idKh = cus.Id,
                //                nameKh = cus.Fullname,
                //                sdt = cus.Phone,
                //                salonlastbill = salon.Id,
                //                datelastbill = bill.CompleteBillTime
                //            };
                // data = query.ToSql();
                return;
            }
        }
    }
}
