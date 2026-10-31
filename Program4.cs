namespace Task4Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------Lucky Lottery Ticket Generator----------//

            //1. Aks the user for their full name
            Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();

            //2. Ask the user for their lucky base number
            Console.WriteLine("What is you lucky number? ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            //3. Generate three randoms number one between 10 & 30, one between 50 & 80, one between 1 & 10
            Random random = new Random();

            int lucky1 = random.Next(10, 31);
            int lucky2 = random.Next(50, 81);
            int bonus = random.Next(1, 11);

            //4. Using Math class and basic arithmetic, calculate & display the product of the base number and lucky1, the square root of lucky2 & the base number raised to the power of bonus
            int product = baseNum * lucky1;
            Console.WriteLine("Product: " + product);

            double square = Math.Sqrt(lucky2);
            Console.WriteLine("Square root: " + square);

            double raised = Math.Pow(baseNum, bonus);
            Console.WriteLine("Base Number raised to bonus: " + raised);

            //5. Create a "Lottery Ticket code" using methods: First 3 letters of name in uppercase, followed by lucky1, followed -, followed by lucky2 & the word "LUCK"
            String code = name.ToUpper();
            code = code.Substring(0, 3);
            code = code + lucky1 + "-" + lucky2 + "LUCK";

            Console.WriteLine("Lottery Ticket Code: " + code);
            Console.WriteLine("Lottery Ticket Code: " + code.Length);

        }
    }
}
