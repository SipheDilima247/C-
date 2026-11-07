namespace task27Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            Console.WriteLine("How many number do you want to enter(3-8): ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[input];

            try
            {
                int chances = 0;
                foreach(int number in numbers)
                {
                    Console.WriteLine($"Enter number: ");
                    numbers[chances] = Convert.ToInt32(Console.ReadLine());
                    chances++;
                }
                
            }

            catch (FormatException e)
            {
                Console.WriteLine("Enter numbers moron");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }

            finally
            {
                Console.WriteLine($"Awesome {name}!");
            }

            double average = GetAverage(numbers);
            Console.WriteLine($"Average: {average}");
            string message;
            message = ((average >= 50) ? "Good average" : "Low average");
            Console.WriteLine($"Here are you results {name}\nAverage: {average}\n{message}");

            string safeCode = name.Substring(0, 3);
            safeCode = safeCode.ToUpper() + "SAFE";
            Console.WriteLine(safeCode + "\n" + safeCode.Length);

        }

        static double GetAverage(int[] numbers)
        {
            int count = 0;
            double average = 0;
            foreach(int number in numbers)
            {
                average = average + (double)numbers[count];
                count++;
            }

            average = (double)average/ numbers.Length;
            return average = Math.Round(average, 1);
        }
    }
}
