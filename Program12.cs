namespace task12Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //2. Ask how many days they want to track(1-7)
            Console.WriteLine("How many days do you want to track: ");
            int track = Convert.ToInt32(Console.ReadLine());

            //3.Use a for loop to collect the number of steps for each day
            int steps = 0;

            for (int i = 0; i<track; i++)
            {
                Console.WriteLine("How many steps taken today:");
                steps = steps + Convert.ToInt32(Console.ReadLine());
            }

            //4. After collecting the steps:
            // - calculate the total steps
            // - calculate the average steps

            double average = steps / track;

            //5. Generate a random daily goal between 5000-12000
            Random random = new Random();
            int dailyGoal = random.Next(5000,12001);

            //6. Use if-else + logical operators to give feedback:
            // - if total steps >= daily goal * number of days: "Excellent! You crushed your goal!"
            // - if average steps >= 7000: "Good effort!"
            // - else: "You need to walk more."

            if (steps >= dailyGoal * track)
            {
                Console.WriteLine("Excellent! You crushed your goal!");
            }

            else if (average >= 7000)
            {
                Console.WriteLine("Good effort!");
            }

            else
            {
                Console.WriteLine("You need to walk more.");
            }

            //7. Create a "Fitness Code"
            // - first 3 uppercase letters of name
            // - total steps
            // - "FIT"

            String fitnessCode = name.Substring(0, 3);
            fitnessCode = fitnessCode.ToUpper() + steps + "FIT";


            //8. Display the Fitness code and its length
            Console.WriteLine("Fitness Code: " + fitnessCode);
            Console.WriteLine(fitnessCode.Length);
        }
    }
}
