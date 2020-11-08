using System;
using System.Collections.Generic;
using System.Text;

namespace Uitility.Common
{
    public class Paging
    {
        public Paging(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex >= 0 ? pageIndex : 0;
            PageSize = pageSize > 0 ? pageSize : 10;
        }
        public Paging(int pageIndex) : this(pageIndex, 10) { }
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int Offset => this.PageSize * this.PageIndex;
        public int TotalRow { get; set; }
    }
}
