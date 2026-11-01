namespace task10Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------ NUMBER GUESSSING GAME -------------//
            //1. Ask the user their name
            Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            //2. Generate a secret number between 1 & 50
            Random random = new Random();
            int num = random.Next(1, 51);

            //3.Give the user up to 6 attempts to guess the number

            int i = 1;
            int guess = 0;
            bool outcome = false;
            for (i = 1; i <= 6; i++)
            {
                Console.WriteLine("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());

                //4. For each guess; take user input, give hints; Too high, too low
                if (guess == num)
                {
                    Console.WriteLine("Congatulations " + name + "! You guessed it!");
                    outcome = true;
                    break;
                }

                else if (guess > num)
                {
                    Console.WriteLine("Too high!");
                    outcome = false;
                }

                else if (guess < num)
                {
                    Console.WriteLine("Too Low!");
                    outcome = false;
                }

                //5.IF they run out of attempts, reveal the secret number
                if (i == 6 && guess != num)
                {
                    Console.WriteLine("Secret number: " + num);
                }

                else
                {

                }
            }

            

            //6. At the end, create a "Game code" using string methods
            String gameCode = name.ToUpper();
            gameCode = gameCode.Substring(0, 3) + num;

            if (outcome == true)
            {
                gameCode = gameCode + "WIN";
            }

            else
            {
                gameCode = gameCode + "LOSE";
            }

            Console.WriteLine("Game Code: " + gameCode);
            Console.WriteLine(gameCode.Length);

        }
    }
}
