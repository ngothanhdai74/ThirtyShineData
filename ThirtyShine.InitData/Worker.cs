using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Repository;
using Repository.Database.Default.Tables;
using Repository.Implements;
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
                RawRepository.GetData();
            }
            catch (Exception ex)
            {

                throw;
            }

        }


    }
}
