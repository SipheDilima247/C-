namespace task9Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------- TEMPERATURE & WEATHER ADVISOR --------------//

            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            //2. Ask the user for the current temperature in Celsius
            Console.WriteLine("What is the current temperature in Celcius: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            //3. Generate a random humidity percentage between 30-90
            Random random = new Random();

            int humidity = random.Next(30, 91);

            //4. determine & display weather advice:
            /*Below 0 = Freezing! wear a heavy jacket
             * 0 - 15 = Cold. Wear a sweater
             * 16 - 25 = Pleasant Weather
             * 26 - 35 = Hot. Stay hydrated
             * Above 35 = Extreme heat! Be careful*/

            if (temp > 0)
            {
                Console.WriteLine("Freezing! wear a heavy jacket");
            }

            else if (temp <= 15)
            {
                Console.WriteLine("Cold. Wear a sweater.");
            }

            else if (temp <= 25)
            {
                Console.WriteLine("Pleasant weather.");
            }

            else if (temp <= 35)
            {
                Console.WriteLine("Hot. Stay hydrated.");
            }

            else if (temp > 35)
            {
                Console.WriteLine("Extreme heat! Be careful.");
            }
        }
    }
}
