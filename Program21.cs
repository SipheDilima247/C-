namespace task21Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            int countPassed = 0;
            int countDistinction = 0;

            //2.Create an array of 6 students scores(int[]) between 0-100.
            int[] studentScore = new int[6];
            int totalScore = 0;

            for (int i = 0; i<6; i++)
            {
                Console.WriteLine("Enter the score for student " + (i + 1) + "(Between 0-100): ");
                studentScore[i] = Convert.ToInt32(Console.ReadLine());
                totalScore = totalScore + studentScore[i];
            }

            //3.Use a foreach loop to:
            // - display each score
            // - calculate the total of all scores
            foreach (int score in studentScore)
            {
                Console.WriteLine(score);
            }

            //4.Calculate the average score and display it
            double averageScore = totalScore / 6;
            Console.WriteLine(averageScore);

            //5.Use another foreach loop to count how many studens:
            // - passed(score>=50)
            // - got a distinction(>=75)

            foreach (int score in studentScore)
            {
                Console.WriteLine(score);
                if (score >= 75)
                {
                    countDistinction = countDistinction + 1;
                }

                else if (score >= 50 && score <75)
                {
                    countPassed = countPassed + 1;
                }
            }

            //6.Use if-else to give a class comment based on the average:
            // - average >= 75 - "Outstanding class!"
            // - average >= 50 && average < 75 - "Satisfactory class"
            // - average < 50 - "Class needs support"

            if (averageScore >= 75)
            {
                Console.WriteLine("Outstanding class!");
            }

            else if (averageScore >= 50 && averageScore < 75)
            {
                Console.WriteLine("Satisfactory class");
            }

            else if (averageScore < 50)
            {
                Console.WriteLine("Class needs support");
            }

            String classCode = name.ToUpper();
            classCode = classCode.Substring(0, 3) + countDistinction + "CLS";
            Console.WriteLine(classCode);
            Console.WriteLine(classCode.Length);

        }
    }
}
