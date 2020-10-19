using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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
            await S4MRepository.Handler();
        }
    }
}
