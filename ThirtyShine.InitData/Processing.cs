﻿using DB201990809;
using System;
using System.Collections.Generic;
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
            var data = DateTime.UtcNow;
            var da = data.ToVietNameDateTime();

            //using(var db = new _20190809Context())
            //{
            //    db.PermissionMenuAction.Add(new PermissionMenuAction()
            //    {
            //        PermissionId = 7,
            //        ActionId = 1,
            //        PageId = 20245,
            //        CreatedTime = DateTime.UtcNow,
            //        IsActive = true,
            //        IsDelete = false,
            //    });
            //    //var data = db.PermissionMenu.FirstOrDefault(m => m.Name.Contains("Điểm danh"));
            //    //if (data != null)
            //    //{
            //    //    data.Pid = 20245;
            //        var res = db.SaveChanges();
            //    //}
            //}
            Console.ReadKey();
        }
    }
    public interface IProcessing
    {
        Task Handler();
    }
}
