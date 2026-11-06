namespace task26Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + ", enjoy your stay!");

            /*Create overloaded methods named Analyze:
             * Analyze(int a, int b) - returns the highest of the two numbers
             * Analyze(int a, int b, int c) - returns the highest of three numbers.
             * Analyze(params int[] numbers) - returns the highest number in the array(using params + foreach)
             */

            string label = "Value: ";
            int highest = Analyze(1, 2);
            DisplayResult(label, highest);
            highest = Analyze(1, 2, 3);
            DisplayResult(label, highest);
            highest = Analyze(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            DisplayResult(label, highest);

            string AnalyzeCode = name.Substring(0, 3);
            AnalyzeCode = AnalyzeCode.ToUpper() + "ANL";
            Console.WriteLine(AnalyzeCode + "\n" + AnalyzeCode.Length);


        }

        static int Analyze(int a, int b)
        {
            int highest = 0;
            if (a > b && a != b)
            {
                return highest = a;
            }

            else
            {
                return highest = b;
            }

        }

        static int Analyze(int a, int b, int c)
        {
            int highest = 0;

            if (a > b && a != b && a > c && a != c)
            {
                highest = a;
            }

            else if (b > a && b != a && b > c && b != c)
            {
                highest = b;
            }

            else if (c > a && c != a && c > b && c != b)
            {
                highest = c;
            }

            return highest;
        }

        static int Analyze(params int[] numbers)
        {
            int highest = 0;

            foreach (int number in numbers)
            {
                if (number > highest && number != highest)
                {
                    highest = number;
                }
            }

            return highest;
        }

        static void DisplayResult(string label, int value)
        {
            Console.WriteLine(label + value);
        }
    }
}
