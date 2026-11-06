namespace task24Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + ", enjoy your stay!");

            /*2. Create overloaded methds named Calculate:
             * Calculate(int a, int b) - returns the sum of two intergers
             * Calcilate(int a, int b, int c) - returns the sum of three intergers
             * Calculate(params int[] number) - returns the sum of any number of inters (using params + foreach)
             */


            int total = Calculate(1, 2);
            Console.WriteLine(total);
            int total2 = Calculate(1, 2, 3);
            Console.WriteLine(total2);
            int total3 = Calculate(1, 2, 3, 4, 5);
            Console.WriteLine(total3);

            string message = "Here is your information " + name + " :\nResult: ";
            int result = total3;

            DisplayResult(message, result);

            string calcCode = name.Substring(0, 3);
            calcCode = calcCode.ToUpper() + "CALC";
            Console.WriteLine(calcCode);
            Console.WriteLine(calcCode.Length);
        }

        static int Calculate(int a, int b)
        {
            return a + b;
        }

        static int Calculate(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Calculate(params int[] number)
        {
            int total = 0;
             foreach (int numbe in number)
            {
                total += numbe;
            }

             return total;
        }

        static void DisplayResult(string message, int result)
        {
            Console.WriteLine(message + result);
        }
    }
}
