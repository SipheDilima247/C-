namespace task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //2.Ask how many students are in the class(3-8)
            Console.WriteLine("How many student are in class(between 3 & 8)?: ");
            int students = Convert.ToInt32(Console.ReadLine());
            string answer = "";
            int present = 0;
            int absent = 0;
            double percentagePresent = 0;
            double percentageAbsent = 0;

            if (students >= 3 && students <= 8)
            {
                //3. create 2 arrays of that size:
                // - one for student names
                // - one for attendance

                string[] names = new string[students];
                bool[] attendance = new bool[students];

                //4. use a for loop to:
                // - Ask for each students name
                // - ask if they are present [y/n]
                // - store the name and set the attendance to true or false

                for (int i = 0; i<students; i++)
                {
                    Console.WriteLine("Enter student name: ");
                    names[i] = Console.ReadLine();

                    Console.WriteLine("Are they present?[y/n]: ");
                    answer = Console.ReadLine();
                    
                    if (answer == "y" || answer == "Y")
                    {
                        attendance[i] = true;
                        present = present + 1;
                        percentagePresent = ((double)present / (double)students) * 100;
                    }

                    else
                    {
                        attendance[i] = false;
                        absent = absent + 1;
                        percentageAbsent = ((double)absent / (double)students) * 100;
                    }
                }

                for (int j = 0; j < students; j++)
                {
                    Console.WriteLine("Name: " + names[j] + "\nAttendance: " + attendance[j]);

                }

                Console.WriteLine("Total Present: " + present + "\nTotal Absent: " + absent);
                
                
                Console.WriteLine("Percentage Absent: " + percentageAbsent + "\nPercentage Present: " + percentagePresent);

                if (percentagePresent >= 80)
                {
                    Console.WriteLine("Good Attendance!");
                }

                else if (percentagePresent >= 50 && percentagePresent < 80)
                {
                    Console.WriteLine("Average Attendance!");
                }

                else if (percentagePresent < 50)
                {
                    Console.WriteLine("Poor Attendance!");
                }

                String attendanceCode = name.ToUpper();
                attendanceCode = attendanceCode.Substring(0, 3) + present + "ATT";
                Console.WriteLine(attendanceCode);
                Console.WriteLine(attendanceCode.Length);

            }

            else
            {
                Console.WriteLine("Enter a value between 3 and 8, bye!");
            }
        }
    }
}
