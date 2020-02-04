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

        /// <summary>
        /// Takes three integer-references and sorts them ascending
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        public static void OrderNumbers(ref int number1, ref int number2, ref int number3)
        {
            if (number1 > number3)
            {
                SwapNumbers(ref number1, ref number3);
            }
            if(number1 > number2)
            {
                SwapNumbers(ref number1, ref number2);
            }
            if(number2 > number3)
            {
                SwapNumbers(ref number2, ref number3);
            }
        }

        /// <summary>
        /// Takes an integer-Array and creates two out-integers one with the highest and one with the smallest Value
        /// </summary>
        /// <param name="arrayToLookUp"></param>
        /// <param name="highestValue"></param>
        /// <param name="smallestValue"></param>
        public static void CalcMinMax(int[] arrayToLookUp,out int highestValue, out int smallestValue)
        {
            highestValue = arrayToLookUp[0];
            smallestValue = arrayToLookUp[0];

            for (int i = 1; i < arrayToLookUp.Length; i++)
            {
                if (arrayToLookUp[i] > highestValue)
                {
                    highestValue = arrayToLookUp[i];
                }
                else if (arrayToLookUp[i] < smallestValue)
                {
                    smallestValue = arrayToLookUp[i];
                }
            }
        }

        /// <summary>
        /// Takes a string and builds a number out of it. If a char is not a digit, it will be replaced with zero
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns>Number from the given string</returns>
        public static long ReplaceLetters(string inputNumber)
        {
            long outputNumber = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (inputNumber[i] >= '0' && inputNumber[i] <= '9')
                {
                    outputNumber += Convert.ToInt32(inputNumber[i].ToString());
                }
                outputNumber *= 10;
            }

            outputNumber /= 10;

            return outputNumber;
        }


        public static int[] ArrayXOR(int[] numbers1, int[] numbers2)
        {
            int[] uniqueNumbers;
            //TODO
            return uniqueNumbers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="startingIndex"></param>
        /// <param name="substringLength"></param>
        /// <returns></returns>
        public static string Substring(string inputString, int startingIndex, int substringLength)
        {
            string substring="";
            if(startingIndex < 0 || startingIndex > inputString.Length-1)
            {
                //do nothing if indexOutOfRange or starts from behind
            }
            else
            {
                if(startingIndex+substringLength > inputString.Length)
                {
                    substringLength = inputString.Length - startingIndex;
                }

                for (int i = 0; i < substringLength; i++)
                {
                    substring += inputString[startingIndex + i];
                }
            }
            return substring;
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
                        Console.Write("Bitte 1. Nummer eingeben: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bitte 2. Nummer eingeben: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        SwapNumbers(ref num1,ref num2);
                        Console.WriteLine("Neuer Wert von Nummer 1: {0}", num1);
                        Console.WriteLine("Neuer Wert von Nummer 2: {0}", num2);
                        break;
                    case "2":
                        Console.Write("Bitte 1. Nummer eingeben: ");
                        int numb1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bitte 2. Nummer eingeben: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bitte 3. Nummer eingeben: ");
                        int numb3 = Convert.ToInt32(Console.ReadLine());
                        OrderNumbers(ref numb1, ref numb2, ref numb3);
                        Console.WriteLine("Die kleinste Zahl ist: {0}", numb1);
                        Console.WriteLine("Die mittlere Zahl ist: {0}", numb2);
                        Console.WriteLine("Die groesste Zahl ist: {0}", numb3);
                        break;
                    case "3":
                        Console.Write("Wie viele Zahlen?: ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        CalcMinMax(ReadIntArray(amount),out int highest,out int smallest);
                        Console.WriteLine("Die groesste Zahl ist: {0}", highest);
                        Console.WriteLine("Die kleinste Zahl ist: {0}", smallest);
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
