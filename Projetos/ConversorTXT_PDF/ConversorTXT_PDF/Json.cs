using Newtonsoft.Json.Linq;
using System.IO;

namespace ConversorTXT_PDF
{
    public class Json
    {
        private static string pathAppConfig = @$"{Directory.GetCurrentDirectory()}\appsettings.json";
        public static JObject AppSettings => JObject.Parse(File.ReadAllText(pathAppConfig));
    }
}
