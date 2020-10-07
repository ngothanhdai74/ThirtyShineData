using DB201990809;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyShine.InitData
{
    public class Processing : IProcessing
    {
        public async Task Handler()
        {
            using(var db = new _20190809Context())
            {
                var data = db.PermissionAction.ToList();
                var da = data.FirstOrDefault();
            }
        }
    }
    public interface IProcessing
    {
        Task Handler();
    }
}
