using DB201990809;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uitility.Common;

namespace Repository.Implements
{
    public class IvInventoryCurrentRepo : BaseRepository<_20190809Context, IvInventoryCurrent>, IIvInventoryCurrent
    {
        public IvInventoryCurrentRepo(_20190809Context context) : base(context) { }

        public async Task Process()
        {
            var pageIndex = 0;
            var pageSize = 100;
            var paging = new Paging(pageIndex, pageSize);
            var data = await QueryAsync(paging);

            if (data?.Any() == true)
            {
                var totalPage = paging.TotalRow / pageSize + (paging.TotalRow % pageSize == 0 ? 0 : 1);
                while (pageIndex < totalPage)
                {
                    // handler data

                    //
                    pageIndex++;
                    paging = new Paging(pageIndex, pageSize);
                    data = await QueryAsync(paging);
                }
            }
        }

    }
}
