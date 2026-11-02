namespace task13Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //2. Create 3 simple math questions
            String question1 = "1+1= ";
            int answer1 = 2;
            String question2 = "10+10= ";
            int answer2 = 20;
            String question3 = "100+100= ";
            int answer3 = 200;
            int score = 0;

            //3. Use a for loop to ask all 3 questions
            for (int i = 0; i<=3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(question1);
                    int response1 = Convert.ToInt32(Console.ReadLine());

                    if (response1 == answer1)
                    {
                        score++;
                        Console.WriteLine("Correct!");
                    }

                    else
                    {
                        score = score;
                        Console.WriteLine("Wrong! Correct Answer: " + answer1);
                    }
                }

                else if (i == 2 )
                {
                    Console.WriteLine(question2);
                    int response2 = Convert.ToInt32(Console.ReadLine());

                    if (response2 == answer2)
                    {
                        score++;
                        Console.WriteLine("Correct!");
                    }

                    else
                    {
                        score = score;
                        Console.WriteLine("Wrong! Correct Answer: " + answer2);
                    }

                }

                else if (i == 3)
                {
                    Console.WriteLine(question3);
                    int response3 = Convert.ToInt32(Console.ReadLine());

                    if ( response3 == answer3)
                    {
                        score++;
                        Console.WriteLine("Correct!");
                    }

                    else
                    {
                        score = score;
                        Console.WriteLine("Wrong! Correct Answer: " + answer3);
                    }
                }
            }
            Console.WriteLine("Final Score: " + score);

            if (score ==3)
            {
                Console.WriteLine("Perfect score, " + name);
            }

            else if (score == 2)
            {
                Console.WriteLine("Good job, " + name);
            }

            else if (score <=1)
            {
                Console.WriteLine("Keep Practising, " + name);
            }

            String quizCode = name.ToUpper();
            quizCode = quizCode.Substring(0, 3) + score + "QUIZ";

            Console.WriteLine("Quiz code: " + quizCode);
            Console.WriteLine(quizCode.Length);
        }
    }
}
