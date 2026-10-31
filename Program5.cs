namespace Task5Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------TRAVEL BUDGET PLANNER---------//

            //1. Ask the user for their full name
            Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();

            //2. Ask the user for their total budget USD 
            Console.WriteLine("What is you total budget? ");
            double budget = Convert.ToDouble(Console.ReadLine());

            //3. Ask the user for the number of travel days 
            Console.WriteLine("Number of travel days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            //4. Generate 2 numbers randoms number dailyCost - random interger between 30 and 120, exchangeRate - random double between 0.8 and 1.4
            Random random = new Random();

            int dailyCost = random.Next(30, 120);
            Console.WriteLine("Daily Cost: " + dailyCost);

            double exchangeRate = random.NextDouble() * (1.4 - 0.8) + 0.8;
            Console.WriteLine("Exchange Rate: " + exchangeRate);

            //5. Using Math classs and arithmetic, calculate and display estimated total expenses = dailycost * number of days, remaining budget after expenses, square root of the total budget, Budget raised to power of of 0.5 (the same root)
            int totalExpenses = dailyCost * days;
            Console.WriteLine("Total Expenses: " + totalExpenses);

            double remaining = budget - totalExpenses;
            Console.WriteLine("Remaining Budget after Expenses: " + remaining);

            double square = Math.Sqrt(budget);
            Console.WriteLine("Square root of the total budget: " + square);

            double raised = Math.Pow(budget, 0.5);
            Console.WriteLine("Budget Squared: " + raised);

            //6. Create a "Travel Code" using string methods first 4 letters of name in uppercase, followed by the dailycost, followed by "TRIP"
            String travelCode = name.ToUpper();
            travelCode = travelCode.Substring(0, 4) + dailyCost + "TRIP";
            Console.WriteLine("Travel Code: " + travelCode);


        }
    }
}
