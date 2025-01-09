namespace target_challenge.QuestionOne
{
    public static class SumIndex
    {
        public static void Sum(int index)
        {
            int SOMA = 0, K = 0;
            while (K < index)
            {
                K = K + 1;
                SOMA = SOMA + K;
    
            }
    
            Console.WriteLine(SOMA);
        }
    }
}