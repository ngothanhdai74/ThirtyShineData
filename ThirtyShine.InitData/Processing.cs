using DB201990809;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uitility.Common;
namespace ThirtyShine.InitData
{
    public class Processing : IProcessing
    {
        public async Task Handler()
        {
            using (var db = new _20190809Context())
            {
                var query = from bill in db.BillService.Where(m => m.CreatedDate >= DateTime.Now.AddDays(-40))
                            join cus in db.Customer on bill.CustomerId equals cus.Id

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
    public interface IProcessing
    {
        Task Handler();
    }
}
