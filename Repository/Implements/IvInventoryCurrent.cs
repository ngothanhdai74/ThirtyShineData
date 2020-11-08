using DB201990809;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implements
{
    public class IvInventoryCurrentRepo : BaseRepository<_20190809Context, IvInventoryCurrent>, IIvInventoryCurrent
    {
        public IvInventoryCurrentRepo(_20190809Context context) : base(context){}

    }
}
