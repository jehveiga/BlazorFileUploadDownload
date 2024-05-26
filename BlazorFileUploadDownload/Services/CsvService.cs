using BlazorFileUploadDownload.Domain.Entities;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Components.Forms;
using System.Globalization;
using System.Text;

namespace BlazorFileUploadDownload.Services
{
    public static class CsvService
    {
        public static async Task<List<Game>> LerCsvAsync(IBrowserFile file)
        {
            // Se o arquivo de upload não tiver na primeira linha do Header cabecalho (HasHeaderRecord = false)
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8,
                HasHeaderRecord = true
            };


            using var streamReader = new StreamReader(file.OpenReadStream(maxAllowedSize: 2097152));
            using (var csv = new CsvReader(streamReader, config))
            {
                var records = new List<Game>();
                await csv.ReadAsync();
                csv.ReadHeader();
                while (await csv.ReadAsync())
                {
                    var record = new Game
                    {
                        Nome = csv.GetField<string>(0),
                        Preco = csv.GetField<decimal>(1)
                    };
                    records.Add(record);
                }

                return records;
            }
        }
    }
}