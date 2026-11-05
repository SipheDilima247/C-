namespace task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Ask the user for their name
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            int total = 0;
            int count = 0;

            //2.Create an array of 5 product ratings(int[]) with values 1 and 5

            int[] productRatings = {1, 2, 3, 4, 5};

            foreach (int rating in productRatings)
            {
                Console.WriteLine(rating);
                total = total + rating;
            }

            //4. Calculate the average rating
            double averageRating = total / 5;

            //5. use another foreach loop to count how many ratings are 5 star
            foreach(int fiveStar in productRatings)
            {
                if (fiveStar >= 5)
                {
                    count++;
                }
            }

            //6. use if-else to give a final comment based on average
            // - average >= 4.5 -"Excellent product!"
            // - average >= 3.5 && <4.5 - "Good product"
            // - average < 3.5 - "Needs improvement"

            if (averageRating >= 4.5)
            {
                Console.WriteLine("Excellent product!");
            }

            else if (averageRating >= 3.5 && averageRating < 4.5)
            {
                Console.WriteLine("Good product");
            }

            else if (averageRating < 3.5)
            {
                Console.WriteLine("Needs improvement");
            }

            string reviewCode = name.ToUpper();
            reviewCode = reviewCode.Substring(0, 3) + count + "REV";
            Console.WriteLine(reviewCode);
            Console.WriteLine(reviewCode.Length);
        }
    }
}
