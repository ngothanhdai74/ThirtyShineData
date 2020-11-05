using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Uitility;
using Uitility.Common;

namespace ThirtyShine.InitData
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                await DB201990809Repository.ConfigMenuKho2020Inventory("/admin/danh-sach-vat-tu-theo-nhom.html", "(Cung ứng)Danh sách vật tư theo nhóm");
                await DB201990809Repository.ConfigMenuKho2020Inventory("/admin/cau-hinh-dinh-luong-goi-dich-vu.html", "(Cung ứng)Cấu hình định lượng gói dịch vụ");

            }
            catch (Exception  wx)
            {

                throw;
            }

        }
    }
}
