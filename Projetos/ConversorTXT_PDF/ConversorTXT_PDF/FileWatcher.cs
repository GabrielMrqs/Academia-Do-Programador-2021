using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace ConversorTXT_PDF
{
    public class FileWatcher
    {
        private static TimeSpan tempoDecorrido = new();
        public static FileSystemWatcher Iniciar()
        {
            var watcher = new FileSystemWatcher();

            watcher.Path = Json.AppSettings["EntradaTXT"].ToString();

            watcher.Filter = "*.txt";

            watcher.Created += new FileSystemEventHandler(OnCreated);

            watcher.IncludeSubdirectories = true;

            watcher.EnableRaisingEvents = true;

            return watcher;
        }
        private static async void OnCreated(object sender, FileSystemEventArgs e)
        {
            Worker._logger.LogInformation($"escuitou o arquivo {e.Name}");

            Stopwatch sw = Stopwatch.StartNew();

            await Task.Run(() => ConversorPDF.ConverterTXT_PDF(e.FullPath));

            if (sw.Elapsed > tempoDecorrido)
                tempoDecorrido = sw.Elapsed;

            Worker._logger.LogInformation("Maior tempo decorrido: {tempo}", tempoDecorrido.ToString());
        }
    }
}
