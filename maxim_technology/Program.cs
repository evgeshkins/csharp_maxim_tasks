namespace maxim_technology
{
    internal class Program
    {
        public static string StringReverse(string inputStr)
        {
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
            return reverseResult;

        }
        static void Main(string[] args)
        {
            string stringReverseInput = String.Empty;
            stringReverseInput += Console.ReadLine();
            string stringReverseOut = StringReverse(stringReverseInput);
            Console.WriteLine(stringReverseOut);
            Console.ReadKey();
        }
    }
}