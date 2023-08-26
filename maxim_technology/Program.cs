
namespace maxim_technology
{
    internal class Program
    {

       public static string StringChecker(string checkStr) // метод проверки строки: только строчные буквы английского алфавита
        {
            HashSet<char> misSymbolsSet = new HashSet<char>(); // множество для хранения неподходящих символов без повторения
            for (int i = 0; i < checkStr.Length; i++)
            {
                if ((int)checkStr[i] < 97 || (int)checkStr[i] > 122)
                {
                    misSymbolsSet.Add(checkStr[i]);
                }
            }
            char[] misSymbols = misSymbolsSet.ToArray();
            string checkMisResult = String.Empty; // строка с результатом проверки: пустая, если нет неподходящих символов
            if (misSymbolsSet.Count > 0)
            {
                checkMisResult = "Введены неподходящие символы: ";
                for (int i = 0;i < misSymbolsSet.Count;i++)
                {
                    if (i != 0) checkMisResult += ", ";
                    checkMisResult += misSymbols[i];
                }
            }
            return checkMisResult;
        } 
        public static string StringReverse(string inputStr) // метод задания 1
        {
            string checkStringResult = StringChecker(inputStr); // проверка строки: только строчные буквы английского алфавита
            char[] inputChar = inputStr.ToCharArray();
            string reverseResult = "";
            if (inputChar.Length % 2 == 0)
            {
                for (int i = inputChar.Length / 2 - 1; i >= 0; i--)
                {
                    reverseResult += inputChar[i];
                }
                for (int i = inputChar.Length - 1; i >= inputChar.Length/2; i--)
                {
                    reverseResult += inputChar[i];
                }
            }
            else
            {
                for (int i = inputChar.Length - 1; i >= 0; i--)
                {
                    reverseResult += inputChar[i];
                }
                reverseResult += new string(inputChar);
            }
            if (checkStringResult.Length > 0) return checkStringResult;
            else return reverseResult;

        }
        static void Main(string[] args)
        {
            string stringReverseInput = String.Empty;
            Console.WriteLine("Введите строку: ");
            stringReverseInput += Console.ReadLine();
            string stringReverseOut = StringReverse(stringReverseInput);
            Console.WriteLine($"Результат:\n{stringReverseOut}");
            Console.ReadKey();
        }
    }
}