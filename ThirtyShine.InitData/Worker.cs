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
            await DB201990809Repository.MoveLinkFrom2019To2020();
            //await Cognito.GetToken();
        }
    }
}
