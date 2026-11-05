namespace task23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //1.Ask the user for their
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            /*2. Create the following methods:
             * DisplayWelcome(string name) - prints welcome message
             * GetAverage(int[] marks) - returns the average of the marks(as a double, rounded to 1 decimal)
             * CountDistinctions(int[] marks) returns how many marks are >=75
             * GetHighest(int[] marks) - returns the highest mark in the array
             */

            DisplayWelcome(name);
            Console.WriteLine("How many students: ");
            int students = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[students];
            
            /*foreach (int mark in marks)
            {
                Console.WriteLine("Enter mark for student(0-100): ");
                marks[mark] = Convert.ToInt32(Console.ReadLine());
            }*/

            for (int i = 0; i <= students-1; i++)
            {
                Console.WriteLine("Enter mark for student(0-100): ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int mark in marks)
            {
                Console.WriteLine("Mark: " + mark);
            }

            double average = GetAverage(marks);
            int distinct = CountDistinctions(marks);
            int highest = GetHighest(marks);

            if (average <= 50)
            {
                Console.WriteLine("Needs improvement");
            }

            else
            {
                Console.WriteLine("Awesome!!");
            }

            string marksCode = name.Substring(0, 3);
            marksCode = marksCode.ToUpper() + distinct + "MRK";

            Console.WriteLine(marksCode);
            Console.WriteLine(marksCode.Length);

        }

        static void DisplayWelcome(string name)
        {
            Console.WriteLine("Welcome " + name + " enjoy your stay!!");
        }

        static double GetAverage(int[] marks)
        {
            int total = 0;
            int average = 0;

            foreach (int mark in marks)
            {
                total = total + mark;
            }
            average = total / marks.Length;
            Console.WriteLine("Average: " + average);
            return average;
        }

        static int CountDistinctions(int[] marks)
        {
            int distinct = 0;
            foreach (int mark in marks)
            {
                if (mark >= 75)
                {
                    distinct++;
                }
            }

            Console.WriteLine("Distinction: " + distinct);
            return distinct;

        }

        static int GetHighest(int[] marks)
        {
            int highest = 0;

            foreach(int mark in marks)
            {
                if (mark > highest)
                {
                    highest = mark;
                }
            }

            Console.WriteLine("Highest mark: " + highest);
            return highest;
        }
    }
}
