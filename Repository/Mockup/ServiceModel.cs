using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mockup
{
    public class ServiceModel
    {
        public ServiceModel(int serviceId, int quantity)
        {
            ServiceId = serviceId;
            Quantity = quantity;
        }
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
    }
}
