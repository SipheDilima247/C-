namespace task6Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---- Movie Night Planner Program -------//
            //1. Ask the user for their full name
            Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            //2. Ask the user for the ticket price
            Console.WriteLine("Please enter ticket price: ");
            double ticketPrice = Convert.ToDouble(Console.ReadLine());

            //3. Ask the user for number of friends coming
            Console.WriteLine("How many friends are coming: ");
            int friends = Convert.ToInt32(Console.ReadLine());

            //4. Generate 2 random values; Snack cost random integer between 8 and 25, rating random double between 6.5 to 9.8
            Random random = new Random();

            int snackCost = random.Next(8, 26);
            double rating = random.NextDouble() * (9.8-6.5) + 6.5;//?

            //5. Using Math class + Arithmetic, calculatr & display total ticket cost, total estimated cost, square root of total ticket cost, ticket raised to the power of 2
            double totalTicketCost = ticketPrice * (friends + 1);
            Console.WriteLine("Total Cost of Tickets: " + totalTicketCost);

            double totalEstimatedCost = totalTicketCost + snackCost;
            Console.WriteLine("Total Estimated Cost: " + totalEstimatedCost);

            double sqrt = Math.Sqrt(totalTicketCost);
            Console.WriteLine("Square root of total ticket cost: " + sqrt);

            double raised = Math.Pow(ticketPrice, 2);
            Console.WriteLine("Ticket price raised: " + raised);

            //6. create "movie code" using methods first 3 letters of  name in uppercase, followed by snackcost, followed by "MOV"
            String MovieCode = name.ToUpper();
            MovieCode = MovieCode.Substring(0, 3) + snackCost + "MOV";
            Console.WriteLine(MovieCode);
            Console.WriteLine(MovieCode.Length);


        }
    }
}
