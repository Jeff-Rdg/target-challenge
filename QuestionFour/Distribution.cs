namespace target_challenge.QuestionFour
{
    public static class Distribution
    {
        private static Dictionary<string, double> invoices = new Dictionary<string, double>()
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        public static void CalcInvoice()
        {
            double total = invoices.Values.Sum();

            Console.WriteLine("Percentual por Estado:\n");
            
            foreach (var state in invoices)
            {
                double percentual = (state.Value / total) * 100;
                Console.WriteLine($"{state.Key}: {percentual:F2}%");
            }
        }
    }
}