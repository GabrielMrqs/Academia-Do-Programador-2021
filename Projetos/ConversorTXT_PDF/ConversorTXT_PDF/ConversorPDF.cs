using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace ConversorTXT_PDF
{
    public static class ConversorPDF
    {
        public static void ConverterTXT_PDF(string pathTXT)
        {
            string nomeArquivo = pathTXT.Split('\\').Last();

            string pathNovoPDF = GerarPathPDF(nomeArquivo);
            try
            {
                using (StreamReader a = new(pathTXT))
                {
                    Worker._logger.LogInformation($"criando o pdf{pathNovoPDF}");

                    using (PdfWriter wPdf = new(pathNovoPDF, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
                    {
                        PdfDocument pdfDocument = new(wPdf);
                        Document document = new(pdfDocument, PageSize.A4);
                        document.Add(new Paragraph(a.ReadToEnd()));
                        document.Close();
                        pdfDocument.Close();
                    }

                    Worker._logger.LogInformation($"criou o pdf{pathNovoPDF}");
                }

                Worker._logger.LogInformation($"movendo sucesso {pathTXT}");

                File.Move(pathTXT, Json.AppSettings["SucessoTXT"].ToString() + nomeArquivo);

                Worker._logger.LogInformation($"moveu sucesso {pathTXT}");
            }
            catch (Exception ex)
            {
                Worker._logger.LogInformation($"erro: {ex}\n");

                Worker._logger.LogInformation($"movendo falha {pathTXT}");

                File.Move(pathTXT, Json.AppSettings["FalhaTXT"].ToString() + nomeArquivo);

                Worker._logger.LogInformation($"moveu falha {pathTXT}");
            }
        }

        private static string GerarPathPDF(string nomeArquivo)
        {
            return Json.AppSettings["SucessoPDF"].ToString() + nomeArquivo.Replace(".txt", ".pdf");
        }
    }
}