using System.Text;

namespace target_challenge.QuestionFive
{
    public static class InvertString
    {
        public static void Exec()
        {
            Console.Write("Digite uma string para inverter: ");
            string input = Console.ReadLine();
            
            string inverted = Do(input);
            
            Console.WriteLine($"String invertida: {inverted}");
        }
        
        private static string Do(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] invertedArray = new char[str.Length];
            int j = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                invertedArray[j] = str[i];
                j++;
            }

            return new string(invertedArray);
        }
    }
}