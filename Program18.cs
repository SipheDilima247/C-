namespace task18Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //2. Ask how many products they want to manage(3-6)
            Console.WriteLine("How many products do you want to manage(3-6)? ");
            int products = Convert.ToInt32(Console.ReadLine());

            if (products >= 3 && products <= 6)
            {
                string[] productName = new string[products];
                double[] quantities = new double[products];
                double[] prices = new double[products];
                double inventoryValue = 0;
                double highestValue = 0;
                double highestQuantity = 0;

                for (int i = 0; i < products; i++)
                {
                    Console.WriteLine("Product name: ");
                    productName[i] = Console.ReadLine();

                    Console.WriteLine("Units in stock: ");
                    quantities[i] = Convert.ToDouble(Console.ReadLine());

                    if (quantities[i] > highestQuantity)
                    {
                        highestQuantity = quantities[i];
                    }

                    else
                    {

                    }

                    Console.WriteLine("Price/item: ");
                    prices[i] = Convert.ToDouble(Console.ReadLine());

                    if (prices[i] >  highestValue)
                    {
                        highestValue = prices[i];
                    }

                    else
                    {

                    }

                    inventoryValue = inventoryValue + (quantities[i] * prices[i]);
                }

                for (int j = 0; j < products; j++)
                {
                    Console.WriteLine("Product: " + productName[j] + "\nQuantity in Stock: " + quantities[j] + "\nPrice/item: " + prices[j]);

                }

                Console.WriteLine("Total Value of Inventory: " + inventoryValue + "\nProduct with highest price: " + highestValue + "\nProduct with highest quantity: " + highestQuantity);

                Random random = new Random();

                int restock = random.Next(10, 51);

                for (int k = 0; k < products; k++)
                {
                    if (quantities[k] < restock)
                    {
                        Console.WriteLine(productName[k] + " stock is " + quantities[k] + " please restock ASAP!");
                    }

                    else
                    {

                    }
                }

                string inventoryCode = name.ToUpper();
                inventoryCode = inventoryCode.Substring(0, 3) + products + "INV";
                Console.WriteLine(inventoryCode);
                Console.WriteLine(inventoryCode.Length);

            }

            else
            {
                Console.WriteLine("Please enter a correct number between 3 and 6, bye!");
            }

        }
    }
}
