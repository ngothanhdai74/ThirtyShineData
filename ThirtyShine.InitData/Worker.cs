using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Uitility.Common;

namespace ThirtyShine.InitData
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IProcessing _processing;
        public Worker(ILogger<Worker> logger, IProcessing processing)
        {
            _logger = logger;
            _processing = processing;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //var now = DateTime.UtcNow;
            //var das = now.ToVietNameDateTime();
            await S4MRepository.Handler();
        }
    }
}
