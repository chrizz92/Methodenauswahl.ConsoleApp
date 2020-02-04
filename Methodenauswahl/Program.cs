using System;

namespace Methodenauswahl
{
    class Program
    {
        /// <summary>
        /// Takes an integer value, builds a integer-Array with the length of the given value and asks for the array values
        /// </summary>
        /// <param name="count"></param>
        /// <returns>integer-Array with read values</returns>
        public static int[] ReadIntArray(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Bitte {0}. Nummer eingeben: ",i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }

        /// <summary>
        /// Takes two integer-references and swaps their values
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        public static void SwapNumbers(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        public static void OrderNumbers(ref int number1, ref int number2, ref int number3)
        {

        }


        static void Main(string[] args)
        {
            string methodSelector;

            do
            {
                Console.WriteLine("Methodenauswahl");
                Console.WriteLine("===============");
                Console.WriteLine("(1) SwapNumbers");
                Console.WriteLine("(2) OrderNumbers");
                Console.WriteLine("(3) CalcMinMax");
                Console.WriteLine("(4) ReplaceLetters");
                Console.WriteLine("(5) ArrayXOR");
                Console.WriteLine("(6) Substring");
                Console.Write("Bitte Methode (1-6) auswählen <0 zum Beenden>: ");
                methodSelector = Console.ReadLine();

                switch (methodSelector)
                {
                    case "0":
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        break;
                }

            } while (methodSelector != "0");
            
        }
    }
}
