using System.Numerics;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x; //declaration
            //x = 123; //initialization

            //int y = 321; //declaration & initialization

            //int z = x + y;

            //int age = 21; //Whole interger
            //double height = 300.5; //decimal number
            //bool alive = false; //true or false
            //char symbol = '@'; //single character
            //String name = "Bro"; //String of characters

            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("Your age is " + age);
            //Console.WriteLine("Your height in " + height + "cm");
            //Console.WriteLine("Are you alive: " + alive);
            //Console.WriteLine("Your symbol: " + symbol);

            //String userName = symbol + name;

            //Console.WriteLine("Your username is: " + userName);

            //----------- TYPECASTING EXERCISE --------------------------

            //double a = 3.14; //Declaration & initialization
            //int b = Convert.ToInt32(a); //Converting a data type to store in b

            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType()); //Display datatype as well

            //int c = 123;
            //double d = Convert.ToDouble(c);

            //Console.WriteLine(d);
            //Console.WriteLine(d.GetType());

            //int e = 321;
            //String f = Convert.ToString(e);

            //Console.WriteLine(f);
            //Console.WriteLine(f.GetType());

            //String g = "$";
            //char h = Convert.ToChar(g);

            //Console.WriteLine(h);
            //Console.WriteLine(h.GetType());

            //String i = "true";
            //bool j = Convert.ToBoolean(i);

            //Console.WriteLine(j);
            //Console.WriteLine(j.GetType());

            //---- ACCEPTING USER INPUT --------------------------

            //Console.WriteLine("What is your name?"); //Issue Prompt
            //String name = Console.ReadLine(); //Read user input and store it into variable

            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine()); //Read user input, convert it to int and store it  into variable

            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("You are " + age + " years old"); 

            //-------- Basic Arithmetic -------------------

            //int x = 10;

            //x = x + 1; //Manual increment
            //x++; //increment by 1 (usually used in loops)
            //x += 1; //Shortcut

            //x = x - 1; //Manual decrement
            //x--; //decrement by 1 (usually used in loops)
            //x -= 1; //Shortcut

            //x = x * 2; //Manual multiplication
            //x *= 2; //Shortcut

            //x = x / 2; //manual division
            //x /= 2; //Shortcut

            //x = x % 3; //find the remainder
            //x %= 3; //shortcut


            //Console.WriteLine(x);


            //---- MATH CLASS ----------

            //double x = 3.14;
            //int y = 50;
            //POW
            //double a = Math.Pow(x, 2); 

            //SQRT
            //double a = Math.Sqrt(x);

            //ABS
            //double a = Math.Abs(x);

            //Round
            //double a = Math.Round(x);

            //Round-up
            //double a = Math.Ceiling(x);

            //Round-down
            //double a = Math.Floor(x);

            //Max
            //double a = Math.Max(x, y);

            //Min
            //double a = Math.Min(x, y);
            //Console.WriteLine(a);

            //-----RANDOM NUMBERS ------------

            //Random random = new Random();

            //int num1 = random.Next(1, 7);
            //int num2 = random.Next(1, 7);
            //int num3 = random.Next(1, 7);
            //double num = random.NextDouble();

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);

            //------- STRING METHODS -------------------

            //String name = "Han Solo";
            //String number = "072-762-7976";
            //Upper
            //name = name.ToUpper();

            //Lower
            //name = name.ToLower();

            //Replace
            //number = number.Replace("-", " ");

            //Insert
            //String username = name.Insert(0, "@");

            //SubString
            //String firstName = name.Substring(0, 3);
            //String lastName = name.Substring(4, 4);
            //Console.WriteLine(firstName);
            //Console.WriteLine(lastName);

            //---------------IF STATEMENTS -------------------
            //Console.WriteLine("Please enter you age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            /*if (age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }

            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }

            else if (age < 0)
            {
                Console.WriteLine("You havent been born yet");
            }

            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }
            */

            //if statements example 2
            //Console.WriteLine("Please enter your name: ");
            //String name = Console.ReadLine();

            /*if (name == "")
            {
                Console.WriteLine("Please enter your name!!!");
            }

            else
            {
                Console.WriteLine("Hello " + name);
            }
            */

            //OR

            /*if (name != "")
            {
                Console.WriteLine("Hello " + name);
            }

            else
            {
                Console.WriteLine("You did not enter your name!!");
            }
            */

            //------------------ SWITCHES -------------------------//
            /*Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday" or "monday":
                    Console.WriteLine("Its Monday!");
                    break;

                case "Tuesday" or "tuesday":
                    Console.WriteLine("Its Tuesday");
                    break;

                case "Wednesday" or "wednesday":
                    Console.WriteLine("Its Wednesday!");
                    break;

                case "Thursday" or "thursday":
                    Console.WriteLine("Its Thursday");
                    break;

                case "Friday" or "friday":
                    Console.WriteLine("Its Friday");
                    break;

                default:
                    Console.WriteLine(day + " is not a day idiot!!");
                    break;
            }*/

            //--------LOGICAL OPERATORS -----------------------------------------//

            /*Console.WriteLine("What is the temperature(C): ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp>= 10 && temp<=25)
            {
                Console.WriteLine("It is warm outside");
            }

            else
            {
                Console.WriteLine("idk fam");
            }*/

            //------------------- WHILE LOOP ----------------------------------------//

            /*Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);*/

            //--------------------- FOR LOOP --------------------------------------------//
            /*for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);
            }*/

            //---- NESTED LOOPS ------------------------//
            /*Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }*/

            //---------------------- SWITCH -----------------------------//
            // C# utilizes two primary branching mechanisms for multi-way evaluation: the switch statement and the switch expression.

            /* int age = 0;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32((string)Console.ReadLine());
            switch (age)
            {
                case 1:
                    Console.WriteLine("Too young");
                    break;

                case 2:
                    Console.WriteLine("Still too young");
                    break;
            }
            */


            //---------------------- ARRAYS ----------------------//
            // array - a variable that can store multiple values. fixed size

            /*string[] cars = new string[3]; //declare your array and set its fixed size
            cars[0] = "Tesla"; //set the value of each placeholder
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i<cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            */

            //------------------ FOREACH LOOP ----------------------//
            // A simpler way to iterate over an array

            /* String[] cars = { "BMW", "Mustang", "Corvette" };

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            */

            //------------- METHODS -----------------------------//
            //Performs a section of code, whenever it is called
            //Lets us reuse code w/o writing it multiple times

            //String name = "Bro";
            //int age = 21;

            //SingHappyBirthday(name, age);



            //------------------------ RETURN ------------------------------------//
            //Returns data back to the place where a method is called

            /* double x;
            double y;
            double result;

            Console.WriteLine("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine(result);

            */

            //=========== METHOD OVERLOADING =================================//
            //Methods share same name but different parameteres
            //name + parameteres= unique signature
            //must have a unique signature

            /*double total;

            total = Multiply(2, 3);
            total = Multiply(2, 3, 4);
            */

            //============== PARAMS KEYWORD =====================================//
            //A method parameter that takes a variable number of arguments
            //The parameter type must be a single-dimensional array(a linear data structure that stores a collection of elements of the same data type in a single sequential line, with each item accessed by a single index number.)

            //double total = CheckOut(3.99, 5.75, 15, 1, 10.25);
            //Console.WriteLine(total);


        }

        static double Multiply(double x, double y)
        {
            return  x *  y;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c; 
        }

        static void SingHappyBirthday(String name, int age)
        {
            Console.WriteLine("Happy Birthday " + name + "You are " + age + "Years old!");
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
