using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mockup
{
    public class InventoryCurrentMock
    {
        public int Begin { get; set; }
        public int Import { get; set; }
        public int Export { get; set; }
        public int SellOrUse { get; set; }
        public static List<InventoryCurrentMock> GetData()
        {
            List<InventoryCurrentMock> res = new List<InventoryCurrentMock>();

            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });
            res.Add(new InventoryCurrentMock()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
            });

            return res;
        }
    }
}
