namespace task11Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---- BASIC LOGIN & MENU SYSTEM ------//
            //1. Ask the user for their username
            Console.WriteLine("Enter Username: ");
            String username = Console.ReadLine();
            int count = 1;

            //2. Give the user 3 attempts to enter correct password(pass123)
            Console.WriteLine("Enter password: ");
            String password = Console.ReadLine();

            while (count <= 2 && password != "pass123")
            {
                Console.WriteLine("Invalid password Try Again:");
                password = Console.ReadLine();

                if (count == 2 && password != "pass123")
                {
                    Console.WriteLine("Access Denied");
                    Environment.Exit(0);
                }
                count++;
            }
            Console.WriteLine("Login Successfull!");
            //5. Create a usert token: firts 4 uppercase letters of username, followed by random 4-digit number
            String userToken = username.ToUpper();
            userToken = userToken.Substring(0, 4);

            Random random1 = new Random();
            int num3 = random1.Next(1111, 10000);
            userToken = userToken + num3;
            Console.WriteLine("User Token: " + userToken);
            Console.WriteLine(userToken.Length);

            //3. If login is successfull show a menu with 3 options using a loop
            Console.WriteLine("Menu\n1 - Generate Random Number\n2 - Calculate square root of a number\n3 - Exit");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input < 3)
            {
                //4. Use Switch to handle menu
                switch (input)
                {
                    case 1:
                        Random random = new Random();
                        int num = random.Next(0, 101);
                        Console.WriteLine("Random number: " + num);
                        break;

                    case 2:
                        Console.WriteLine("Enter number: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        double sqrt = Math.Sqrt(num2);
                        Console.WriteLine("Square root of " + num2 + " is: " + sqrt);
                        break;
                        
                }

                Console.WriteLine("Menu\n1 - Generate Random Number\n2 - Calculate square root of a number\n3 - Exit");
                input = Convert.ToInt32(Console.ReadLine());
            }
        }
}
}
