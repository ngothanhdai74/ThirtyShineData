using Repository.Database.Default.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mockup
{
    public class QuantityCustomerMockup
    {
        public List<BillServiceHis> BillServiceHis(int salonId = 12)
        {
            var data = new List<BillServiceHis>();
            for (int i = 0; i < 5; i++)
            {
                data.Add(new BillServiceHis()
                {
                    SalonId = salonId,
                    CompleteBillTime = DateTime.Now.AddHours(-(++i))
                });
            }
            return data;
        }
        public List<FlowService> FlowServices()
        {
            var res = new List<FlowService>();
            for (int i = 0; i < 6; i++)
            {
                res.Add(new FlowService()
                {
                });
            }
            return res;
        }
    }
}
