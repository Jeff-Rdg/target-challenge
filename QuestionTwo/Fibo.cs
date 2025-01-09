namespace target_challenge.QuestionTwo
{
    public static class Fibo
    {

        public static void Exec()
        {
            try
            {
                Console.WriteLine("Informe um número para verificar se ele pertence à sequência de Fibonacci:");
                var number = int.Parse(Console.ReadLine());

                if (IsFibonacci(number))
                {
                    Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"O número {number} NÃO pertence à sequência de Fibonacci.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Houve um erro: " + e.Message);
                throw;
            }
        }
        
        static bool IsFibonacci(int num)
        {
            if (num < 0) return false;

            int a = 0, b = 1;

            while (a <= num)
            {
                if (a == num) return true;

                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}