namespace task15Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            int day = 1;
            int high = 0;
            int low = 10000;
            double average = 0;
            int total = 0;

            //2. Create an array of size 7 to store temperature for each day of the week
            double[] temp = new double[7];

            //3. use a for loop to ask the user for the temperature of each day(monday to sunday)
            
            for(int i = 0; i<=6; i++)
            {
                Console.WriteLine("Enter temperature for day " + day + " :");
                temp[i] = Convert.ToDouble(Console.ReadLine());
                day++;

                if (temp[i] > high)
                {
                    high = (int)temp[i];
                }

                else
                {

                }

                if (temp[i] < low)
                {
                    low = (int)temp[i];
                }

                else
                {

                }
                
                total = total + (int)temp[i];
                average = (double)total / 7;

            }

            for(int j = 0; j < 7; j++)
            {
                Console.WriteLine(temp[j]);
            }

            Console.WriteLine("Highest: " + high);
            Console.WriteLine("Lowest: " + low);
            Console.WriteLine("Average: " + average);
            average = Math.Round(average);

            Random random = new Random();

            int weatherMood = random.Next(1, 6);

            switch (weatherMood)
            {
                case 1:
                    Console.WriteLine("Cold & Windy");
                    break;

                case 2:
                    Console.WriteLine("Cloudy");
                    break;

                case 3:
                    Console.WriteLine("Mild");
                    break;

                case 4:
                    Console.WriteLine("Sunny");
                    break;

                case 5:
                    Console.WriteLine("Hot & clear");
                    break;
            }

            string weatherCode = name.ToUpper();
            weatherCode = weatherCode.Substring(0, 3) + average + "WX";
            Console.WriteLine("Weather code: " + weatherCode);
            Console.WriteLine(weatherCode.Length);

        }
    }
}
