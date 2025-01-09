
using Newtonsoft.Json;

namespace target_challenge.QuestionThree
{
    public static class Invoicing
    {
        private static List<Invoice> ReadJsonInvoices()
        {
            try
            {
                string json = File.ReadAllText(@"D:\Projects\c#\target-challenge\dados.json");
                return JsonConvert.DeserializeObject<List<Invoice>>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Houve um erro: " + e);
                throw;
            }
            
        }
        public static void Exec()
        {
            var invoices = ReadJsonInvoices();

            var invoicesAvailable = invoices.Where(i => i.valor > 0).ToList();
        
            double lower = invoicesAvailable.Min(f => f.valor);
            double higher = invoicesAvailable.Max(f => f.valor);
        
            double averageMonthly = invoicesAvailable.Average(f => f.valor);
        
            int daysAboveAverage = invoicesAvailable.Count(f => f.valor > averageMonthly);
        
            Console.WriteLine($"Menor faturamento: {lower:F2}");
            Console.WriteLine($"Maior faturamento: {higher:F2}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {daysAboveAverage}");
            
        }
    }
}