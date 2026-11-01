namespace task7Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------Grade & Luck Calculator ----------//

            //1. Ask the user their name
            Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            //2. Ask the user for their exam score(between 0-100)
            Console.WriteLine("Please enter your exam score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            //3. Generate a random luck number between 1-10
            Random random = new Random();
            int luck = random.Next(1, 10);
            char grade = ' ';
            

            //4. Use if-else statements to determine & display the grade: 90-100 = A - Excellent, 80-89 = B - Good, 70-79 = C - Average, 60-69 = D - Pass, Below 60 = F - Fail
            if (score > 90)
            {
                Console.WriteLine("A - Excellent!");
                grade = 'A';
            }

            else if (score > 80)
            {
                Console.WriteLine("B - Good");
                grade = 'B';
            }

            else if (score > 70)
            {
                Console.WriteLine("C - Average");
                grade = 'C';
            }

            else if (score > 60)
            {
                Console.WriteLine("D - Pass");
                grade = 'D';
            }

            else if (score < 60)
            {
                Console.WriteLine("F");
                grade = 'F';
            }

            //5. Use a switch statement on the luck number to display a fun message: 1 or 2 = "Unlucky...but can improve", 3-5 = "Average luck", 6-8 = "Good luck today!", 9or10 = "Extremely lucky! Go buy a lottery ticket!"
            switch (luck)
            {
                case 1 or 2:
                    Console.WriteLine("Unlucky...but you can improve");
                    break;

                case 3 or 4 or 5:
                    Console.WriteLine("Average luck");
                    break;

                case 6 or 7 or 8:
                    Console.WriteLine("Good luck today!");
                    break;

                case 9 or 10:
                    Console.WriteLine("Extremely lucky! Go buy a lottery ticket!");
                    break;
            }

            //6. Create a "Student code" with first 3 letters of name uppercase, followed by the lucky number, followed by the grade letter(a/b/c/d/f)
            String studentCode = name.ToUpper();
            studentCode = studentCode.Substring(0, 3) + luck + grade;

            Console.WriteLine("Student Code: " + studentCode);
            Console.WriteLine("Length: " + studentCode.Length);

        }
    }
}
