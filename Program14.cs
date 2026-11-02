namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //2. Ask how many subjects they want to enter (3-6)
            Console.WriteLine("How many subjects do you want to enter(3-6)");
            int subjects = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            double average = 0;
            int highest = 0;
            int lowest = 100;

            if (subjects >= 3 && subjects <= 6)
            {
                int[] marks = new int[subjects];

                for (int i = 0; i < subjects; i++)
                {
                    Console.WriteLine("Enter Subject marks: ");
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                    total = total + marks[i];
                    average = (double)total / (double)subjects;

                    if (marks[i] > highest)
                    {
                        highest = marks[i];
                    }

                    else
                    {

                    }

                    if (marks[i] < lowest)
                    {
                        lowest = marks[i];
                    }

                    else
                    {

                    }

                }

                if (average >= 80)
                {
                    Console.WriteLine("Excellent Performance!");
                }

                else if (average >= 60 && average < 80)
                {
                    Console.WriteLine("Good Performance!");
                }

                else if (average < 60)
                {
                    Console.WriteLine("Needs improvement");
                }

                average = Math.Round(average);
                string resultCode = name.ToUpper();
                resultCode = resultCode.Substring(0, 3) + average + "RES";
                Console.WriteLine("Result Code: " + resultCode);
                Console.WriteLine(resultCode.Length);
            }

            else
            {
                Console.WriteLine("Enter a number between 3 & 6, bye!");
            }
        }
    }
}
