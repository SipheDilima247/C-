namespace Task3Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------PERSONAL FITNESS CALCULATOR----------//

            //1. Ask the user for their full name
            Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();

            //2. Ask the user for their weight in kg
            Console.WriteLine("What is your weight(kg)? ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //3. Ask the user fot their height in meters
            Console.WriteLine("What is your height(m)? ");
            double height = Convert.ToDouble(Console.ReadLine());

            //4. Generate a random "motivation number" between 5 & 15
            Random random = new Random();
            int motivationNumber = random.Next(5, 16);

            //5. Using math class, calculate & display BMI(W/(H*H), SQUARE ROOT OF HEIGHT, height raised to the power of 3
            double bmi = weight / (height * height);
            Console.WriteLine("BMI: " + bmi);

            double squareRoot = Math.Sqrt(weight);
            Console.WriteLine("Square root: " + squareRoot);

            double raised = Math.Pow(height, 3);
            Console.WriteLine("Height raised to the power of 3: " + raised);

            //6. Create a Fitness ID string
            String fitnessID = name.ToUpper();
            fitnessID = fitnessID.Substring(0, 4);
            fitnessID = fitnessID + motivationNumber.ToString() + "FIT";

            //7. Display the Fitness ID and its length
            Console.WriteLine("Fitnes ID: " + fitnessID);
            Console.WriteLine("Fitness ID Length: " + fitnessID.Length);
        }
    }
}
