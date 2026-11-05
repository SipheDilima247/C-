namespace task22Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //2. create the following methods:
            // - DisplayWelcome(string name) - prints a welcome message using the name
            // - Add(double a, double b) - returns the sum of two numbers
            // - Multiply(double a, double b) - returns the product of two numbers
            // - GetAverage(double[] numbers) - returns the average of any array of numbers

            DisplayWelcome(name);

            Console.WriteLine("Enter number 1: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result1;
            double result2;
            double result3;


            result1 = Add(a, b);
            Console.WriteLine(result1);

            result2 = Multiply(a, b);
            Console.WriteLine(result2);

            double[] numbers = new double[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            result3 = GetAverage(numbers);
            Console.WriteLine(result3);

            double result4 = GetAverage(numbers);
            Console.WriteLine(result4);

            string calcCode = name.ToUpper();
            calcCode = calcCode.Substring(0, 3) + "CALC";
            Console.WriteLine(calcCode);
            Console.WriteLine(calcCode.Length);
        }

        static void DisplayWelcome(string name)
        {
            Console.WriteLine("Welcome to  the Simple calculator program " + name);
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double GetAverage(double[] numbers)
        {
            double total = 0;

            foreach (double number in numbers)
            {
                total += number;
            }

            double average = total / numbers.Length;

            return average;
        }
    }
}
