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
                
                return;
            }
        }
    }
    public interface IProcessing
    {
        Task Handler();
    }
}
