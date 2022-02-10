using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConversorTXT_PDF
{
    public class Worker : BackgroundService
    {
        public static ILogger<Worker> _logger;
        public static FileSystemWatcher _watcher;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _watcher = FileWatcher.Iniciar();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                _logger.LogInformation("Número de Threads: {threads}", Process.GetCurrentProcess().Threads.Count);

                await Task.Delay(5000, stoppingToken);
            }
        }


    }
}
