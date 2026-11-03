namespace task16Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask  the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //2. Ask how many items they want 2-5
            Console.WriteLine("How many items you want(2-5): ");
            int items = Convert.ToInt32(Console.ReadLine());

            if (items >= 2 && items <= 5)
            {
                //3.create 2 arrays of that size:
                // - one of them names
                // - one of them prices

                string[] names = new string[items];
                double[] prices = new double[items];

                //4.use a for loop to:
                // - ask for the name of each item
                // - ask for the price of each item
                // - store both in the arrays

                double highest = 0;
                double total = 0;
                string highestName = "";

                for (int i = 0; i < items; i++)
                {
                    Console.WriteLine("What is the name of the item: ");
                    names[i] = Console.ReadLine();

                    Console.WriteLine("What is the price of the item: ");
                    prices[i] = Convert.ToDouble(Console.ReadLine());


                    //5. AFTER collecting that data diplay:
                    // - all items names with their cost
                    // - total cost of all items
                    // - most expensive item(name & price
                    

                    total = total + prices[i];

                    if (prices[i] > highest)
                    {
                        highest = prices[i];
                        highestName = names[i];
                    }

                    else
                    {

                    }



                }

                Random random = new Random();

                double discount = random.Next(5, 21);
                double totalPrice = total - discount;

                for (int j = 0; j < items; j++)
                {
                    Console.WriteLine(names[j] + " " + prices[j]);
                }

                Console.WriteLine("Total cost: " + total);
                Console.WriteLine("Most expensive item: " + highestName +" " + highest);
                Console.WriteLine("Price after discount: " + totalPrice);

                string cartCode = name.ToUpper();
                cartCode = cartCode.Substring(0, 3) + totalPrice + "CART";
                Console.WriteLine(cartCode);
                Console.WriteLine(cartCode.Length);


            }

            else
            {
                Console.WriteLine("Enter a valid number between 2 and 5, goodbye.");
            }
        }
    }
}
