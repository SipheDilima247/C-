namespace task19Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            int score = 0;
            int highest = 0;
            string highestName = "";
            int lowest = 100;
            string lowestName = "";
            double average = 0;
            int pass = 0;
            int fail = 0;
            double passRate = 0;

            //2. Ask how many students wrote the exam(4-8)
            Console.WriteLine("How many students wrote the exam(4-8): ");
            int students = Convert.ToInt32(Console.ReadLine());

            if (students >= 4 && students <= 8)
            {
                string[] studentName = new string[students];
                int[] scores = new int[students];

                for (int i = 0; i < students; i++)
                {
                    Console.WriteLine("Enter student name: ");
                    studentName[i] = Console.ReadLine();

                    Console.WriteLine("Enter " + studentName[i] + "'s score(0-100): ");
                    score = Convert.ToInt32(Console.ReadLine());

                    if (score >= 0 && score <= 100)
                    {
                        scores[i] = score;

                        if (scores[i] > highest )
                        {
                            highest = scores[i];
                            highestName = studentName[i];

                        }

                        else if (scores[i] < lowest)
                        {
                            lowest = scores[i];
                            lowestName = studentName[i];
                        }

                        average = average + scores[i] / students;

                        if (scores[i] >= 50)
                        {
                            pass++;
                        }

                        else
                        {
                            fail++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Please enter a number between 0-100");
                    }
                }

                for (int j = 0; j < students; j++)
                {
                    Console.WriteLine("Student name: " + studentName[j] + "\nScore: " + scores[j]);

                }

                passRate = pass / students * 100;

                Console.WriteLine("Student with Highest score: " + highestName + "\nScore: " + highest);
                Console.WriteLine("Students with the Lowest score: " + lowestName + "\nScore: " + lowest);
                Console.WriteLine("Average score: " + average);

                if (passRate >= 70)
                {
                    Console.WriteLine("Strong class performance!");
                }

                else if (passRate >= 40 && passRate < 70)
                {
                    Console.WriteLine("Average class performance!");
                }

                else if (passRate < 40)
                {
                    Console.WriteLine("Weak class performance!");
                }

                string resultCode = name.ToUpper();
                resultCode = resultCode.Substring(0, 3) + pass + "RES";

                Console.WriteLine(resultCode);
                Console.WriteLine(resultCode.Length);
            }

            else
            {
                Console.WriteLine("Please enter the correct number between 4 & 8");
            }
        }
    }
}
