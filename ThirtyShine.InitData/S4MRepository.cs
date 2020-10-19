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
                var query = from bill in db.BillService.Where(m => m.CreatedDate >= DateTime.Now.AddDays(-40))
                            join cus in db.Customer on bill.CustomerId equals cus.Id
                            join salon in db.TblSalon.Where(m => m.IsSalonHoiQuan == true) on bill.SalonId equals salon.Id
                            select new
                            {
                                IdKh = cus.Id,
                                NameKh = cus.Fullname,
                                Sdt = cus.Phone,
                            };

                var data = query.ToSql();
                return;
            }
        }
    }
}
