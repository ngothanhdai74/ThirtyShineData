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
        public static bool Compare(List<ServiceModel> model1, List<ServiceModel> model2 = null)
        {
            if (model2 == null)
            {
                model2 = ModelMock;
            }
            if (model1.Count != model2.Count) return false;
            for (int i = 0; i < model1.Count; i++)
            {
                if (Compare(model1[i], model2[i]) == false) return false;
            }
            return true;
        }
        private static bool Compare(ServiceModel model1, ServiceModel model2)
        {
            if (model1 == null || model2 == null) return false;
            if (model2.Quantity == model1.Quantity && model1.ServiceId == model2.ServiceId) return true;
            return false;
        }
        private static List<ServiceModel> ModelMock
        {
            get
            {
                List<ServiceModel> model = new List<ServiceModel>();
                model.Add(new ServiceModel(14, 5));
                model.Add(new ServiceModel(16, 5));
                return model;
            }
        }
    }
}
