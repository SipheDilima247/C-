namespace task25Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome to the system " + name + ", enjoy your stay!");

            /*2 Create overloaded methods named GetStats:
             * GetStats(int a, int b) - returns the average of two number(as a double)
             * GetStats(int a, int b, in c) - returns the average of three number(as a double)
             * GetStats(params int[] number) - returns the average pf any number of intergers(using params + foreach). Round the result to 1 decimal place)
             */

            string label = "Value: ";
            double value = GetStats(1, 2);
            DisplayResult(label, value);

            value = GetStats(1, 2, 3);
            DisplayResult(label, value);

            value = GetStats(1, 2, 3, 4, 5, 6, 7);
            DisplayResult(label, value);

            string statsCode = name.Substring(0, 3);
            statsCode = statsCode.ToUpper() + "STA";
            Console.WriteLine(statsCode);
            Console.WriteLine(statsCode.Length);

            

        }

        static double GetStats(int a, int b)
        {
            double value = 0;
            value = (double)(a + b) / 2;
            return value = Math.Round(value, 1);
        }

        static double GetStats(int a, int b, int c)
        {
            double value = 0;
            value = (double)(a + b + c) / 3;
            return value = Math.Round(value, 1);
        }

        static double GetStats(params int[] numbers)
        {
            double value = 0;
            foreach (int number in numbers)
            {
                value += number;
            }

            value = (double)value / numbers.Length;
            return value = Math.Round(value, 1);
        }

        static void DisplayResult(string label, double value)
        {
            Console.WriteLine(label + value);
        }
    }
}
