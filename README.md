# C# Task Instructions:



### Task1



Mixed Practice (Covers All Requested Topics)

Objective: Create a "User Profile \& Lucky Number" console program.

Requirements:



Ask the user for their full name (string input).

Ask the user for their age (integer input).

Ask the user for a favorite number (integer input).

Generate a random number between 10 and 99 (inclusive) using the Random class.

Calculate and display:

The user’s age in months (age \* 12)

The square root of their favorite number using Math.Sqrt()

Their favorite number raised to the power of 2 using Math.Pow()



Create a "Lucky Code" by combining:

First 3 letters of their name (uppercase)

Their random number

Last digit of their age

Example: JOH45 3



Display the Lucky Code and its length using string methods.



Additional Rules:



Use Console.WriteLine() and Console.ReadLine() for all input/output.

Handle basic invalid input gracefully (e.g., if they enter text for age, show a nice error and ask again — optional but good for bonus).

Keep the program clean and well-organized.



### Task 2

New Task 2 (Simplified - No Loops)

Objective: Create a "Math Explorer" program.

Requirements:



Ask the user for their name (string).

Ask the user for two integers (number A and number B).

Generate one random integer between 1 and 20 (call it bonus).

Using the Math class, calculate and display:

The sum of A and B

The product of A and B

The square root of A (Math.Sqrt)

A raised to the power of B (Math.Pow)

A + B + bonus (the random number)



Create a "Math Tag" string:

Take the first 3 letters of the name (uppercase)

Add the bonus number

Add the word "Math" at the end

Example: JOH7Math



Display the Math Tag and its length.



Keep it simple — single run, no loops.



### Task 3

✅ Task 3

Objective: Create a "Personal Fitness Calculator" program.

Requirements:



Ask the user for their full name.

Ask the user for their weight in kg (double).

Ask the user for their height in meters (double).

Generate a random "motivation number" between 5 and 15 (inclusive).

Using the Math class, calculate and display:

BMI = weight / (height × height) → use Math.Pow() or simple multiplication

Square root of the weight

Height raised to the power of 3 (Math.Pow(height, 3))



Create a "Fitness ID" string:

First 4 uppercase letters of their name

Followed by the motivation number

Followed by the word "FIT"

Example: JOHN12FIT



Display the Fitness ID and its length using string methods.

Display all calculations with clear labels.



Keep it simple — single run, no loops, focus on clean input + calculations + strings.



### Task 4

✅ Task 4

Objective: Create a "Lucky Lottery Ticket Generator" program.

Requirements:



Ask the user for their full name (string).

Ask the user for their lucky base number (integer).

Generate three random numbers:

One between 10 and 30 (call it lucky1)

One between 50 and 80 (call it lucky2)

One between 1 and 10 (call it bonus)



Using Math class and basic arithmetic, calculate and display:

The product of the base number and lucky1

The square root of lucky2

The base number raised to the power of bonus (Math.Pow)



Create a "Lottery Ticket Code" using string methods:

First 3 letters of name in uppercase

Followed by lucky1

Followed by -

Followed by lucky2

Followed by the word "LUCK"

Example: JOH25-67LUCK



Display the full Lottery Ticket Code and its length.



Keep it single run (no loops). Focus on clean input, calculations, and string handling.



### Task 5

✅ Task 5

Objective: Create a "Travel Budget Planner" program.

Requirements:



Ask the user for their full name.

Ask the user for their total budget in USD (double).

Ask the user for the number of travel days (integer).

Generate two random numbers:

dailyCost → random integer between 30 and 120

exchangeRate → random double between 0.8 and 1.4 (use NextDouble())



Using Math class and arithmetic, calculate and display:

Estimated total expenses = dailyCost × number of days

Remaining budget after expenses

Square root of the total budget (Math.Sqrt)

Budget raised to the power of 0.5 (same as square root, but use Math.Pow)



Create a "Travel Code" using string methods:

First 4 letters of name in uppercase

Followed by the dailyCost

Followed by "TRIP"

Example: JOHN85TRIP



Display the Travel Code and its length.



Rules:



Single run (no loops)

Show all results with clear labels

Use proper data types



### Task 6

✅ Task 6

Objective: Create a "Movie Night Planner" program.

Requirements:



Ask the user for their full name.

Ask the user for the ticket price (double).

Ask the user for number of friends coming (integer).

Generate two random values:

snackCost → random integer between 8 and 25

rating → random double between 6.5 and 9.8 (use NextDouble())



Using Math class + arithmetic, calculate and display:

Total ticket cost (ticket price × (friends + 1))

Total estimated cost (tickets + snacks)

Square root of total ticket cost

Ticket price raised to the power of 2 (Math.Pow)



Create a "Movie Code" using string methods:

First 3 letters of name in uppercase

Followed by snackCost

Followed by "MOV"

Example: JOH15MOV



Display the Movie Code and its length.



Keep it single run (no loops). Show all results with clear labels.



### Task 7



Task 7 (Now with Conditionals)

Objective: Create a "Grade \& Luck Calculator" program.

Requirements:



Ask the user for their full name.

Ask the user for their exam score (integer between 0 and 100).

Generate a random luck number between 1 and 10.

Use if-else statements to determine and display the grade:

90–100 → "A - Excellent!"

80–89 → "B - Good!"

70–79 → "C - Average"

60–69 → "D - Pass"

Below 60 → "F - Fail"



Use a switch statement on the luck number to display a fun message:

1 or 2 → "Unlucky day... but you can improve!"

3 to 5 → "Average luck"

6 to 8 → "Good luck today!"

9 or 10 → "Extremely lucky! Go buy a lottery ticket!"



Create a "Student Code":

First 3 letters of name (uppercase)

Followed by the luck number

Followed by the letter grade (A/B/C/D/F)



Display the Student Code and its length.





Rules:



Use if-else for grading.

Use switch for the luck message.

Handle basic invalid score (if score < 0 or > 100, show error message).



### Task 8

✅ Task 8

Objective: Create a "Simple Bank Account Simulator" program.

Requirements:



Ask the user for their full name.

Ask the user for their current balance (double).

Ask the user to choose a transaction type:

1 → Deposit

2 → Withdraw

3 → Check Balance



Ask for the amount (double) if they choose Deposit or Withdraw.

Use if-else and switch where appropriate:

Use switch for the transaction type.

Use if-else to check if withdrawal is possible (not more than current balance).



Generate a random transaction ID (integer between 1000 and 9999).

Calculate and display the new balance after transaction.

Create a "Account Code" using string methods:

First 4 uppercase letters of name

Followed by last 2 digits of the transaction ID

Example: JOHN45



Display the Account Code and its length.



Bonus for extra points:



Show appropriate messages (e.g. "Insufficient funds!" for bad withdrawal).





Rules: Single run, no loops. Use if, else, and switch.



### Task 9

✅ Task 9

Objective: Create a "Temperature \& Weather Advisor" program.

Requirements:



Ask the user for their name.

Ask the user for the current temperature in Celsius (double).

Generate a random humidity percentage between 30 and 90.

Use if-else if to determine and display weather advice:

Below 0°C → "Freezing! Wear heavy jacket."

0°C to 15°C → "Cold. Wear a sweater."

16°C to 25°C → "Pleasant weather."

26°C to 35°C → "Hot. Stay hydrated."

Above 35°C → "Extreme heat! Be careful."



Use a switch expression or statement based on temperature range (rounded to nearest 10) to suggest an activity.

Calculate:

Temperature in Fahrenheit (C \* 9/5 + 32)

Use Math.Round() on the Fahrenheit value.



Create a "Weather Code":

First 3 uppercase letters of name

Followed by humidity percentage

Followed by "WX"



Display everything clearly, including the Weather Code and its length.



### Task 10



Task 10 (New Topics Included)

Objective: Create a "Number Guessing Game" with limited attempts.

Requirements:



Ask the user for their name.

Generate a secret number between 1 and 50 (using Random).

Give the user up to 6 attempts to guess the number (use a while or for loop).

For each guess:

Take user input.

Use if-else + logical operators to give hints:

Too high → "Too High!"

Too low → "Too Low!"

Correct → "Congratulations \[Name]! You guessed it!"





If they run out of attempts, reveal the secret number.

At the end, create a "Game Code" using string methods:

First 3 letters of name (uppercase)

Followed by the secret number

Followed by "WIN" or "LOSE" depending on whether they guessed correctly.



Display the Game Code and its length.



Bonus for higher score:



Use logical operators to check if the guess is valid (between 1 and 50).

Keep track of how many attempts they used.



### Task 11

✅ Task 11

Objective: Create a "Basic Login \& Menu System" program.

Requirements:



Ask the user for their username (string).

Give the user 3 attempts to enter the correct password ("pass123") using a while loop + logical operators.

If password is correct → Show success message.

If all attempts fail → Show "Access Denied" and end program.



If login is successful, show a menu with 3 options using a for loop or while loop:

1 → Generate Random Number (1-100)

2 → Calculate Square Root of a number (ask for input)

3 → Exit



Use switch to handle menu choices.

Create a "User Token" after successful login:

First 4 uppercase letters of username

Followed by a random 4-digit number



Display the User Token and its length.



Bonus for higher marks:



Use logical operators to validate menu input.

Show "Invalid option" message if user picks wrong menu choice.



### Task 12

✅ Task 12

Objective: Create a "Simple Fitness Tracker" program.

Requirements:



Ask the user for their name.

Ask how many days they want to track (integer between 1 and 7).

Use a for loop to collect the number of steps for each day.

After collecting the steps:

Calculate the total steps.

Calculate the average steps (use Math.Round if needed).



Generate a random daily goal between 5000 and 12000.

Use if-else + logical operators to give feedback:

If total steps ≥ daily goal × number of days → "Excellent! You crushed your goal!"

Else if average steps ≥ 7000 → "Good effort!"

Else → "You need to walk more."



Create a "Fitness Code":

First 3 uppercase letters of name

Followed by the total steps

Followed by "FIT"



Display the Fitness Code and its length.



Bonus:



Validate that the number of days is between 1 and 7.

Show steps for each day as they are entered.



### Task 13

✅ Task 13

Objective: Create a "Simple Quiz Game" program.

Requirements:



Ask the user for their name.

Create 3 simple math questions (you can hardcode the questions and answers).

Use a for loop to ask all 3 questions.

Keep a score counter (start at 0).

For each question:

Ask the question.

Get the user’s answer.

Use if statements to check if the answer is correct.

If correct → add 1 to the score and show “Correct!”

If wrong → show “Wrong!” and the correct answer.



After all questions, display the final score.

Use if-else + logical operators to give a final message:

Score == 3 → "Perfect score, \[Name]!"

Score == 2 → "Good job, \[Name]!"

Score ≤ 1 → "Keep practicing, \[Name]!"



Create a "Quiz Code":

First 3 uppercase letters of name

Followed by the score

Followed by "QUIZ"



Display the Quiz Code and its length.



Bonus:



Generate one of the questions using random numbers.



### Task 14

✅ Task 14

Objective: Create a "Student Marks Analyzer" program.

Requirements:



Ask the user for their name.

Ask how many subjects they want to enter (between 3 and 6).

Create an array of that size to store the marks.

Use a for loop to get the marks for each subject (store them in the array).

After collecting the marks:

Calculate the total marks.

Calculate the average (use Math.Round if you want).



Find the highest and lowest mark in the array (use a loop).

Use if-else + logical operators to give a comment based on the average:

Average ≥ 80 → "Excellent performance!"

Average ≥ 60 and < 80 → "Good performance"

Average < 60 → "Needs improvement"



Create a "Result Code":

First 3 uppercase letters of name

Followed by the average (rounded to whole number)

Followed by "RES"



Display the Result Code and its length.



Bonus:



Display all the marks that were entered.

Validate that marks are between 0 and 100.



### Task 15

✅ Task 15

Objective: Create a "Weekly Temperature Logger" program.

Requirements:



Ask the user for their name.

Create an array of size 7 to store temperatures for each day of the week.

Use a for loop to ask the user for the temperature of each day (Monday to Sunday) and store them in the array.

After collecting all temperatures, display:

All 7 temperatures

The highest temperature

The lowest temperature

The average temperature (rounded to 1 decimal place)



Generate a random "Weather Mood" number between 1 and 5.

Use a switch statement on the Weather Mood to print a message:

1 → "Cold and rainy"

2 → "Cloudy"

3 → "Mild"

4 → "Sunny"

5 → "Hot and clear"



Create a "Weather Code":

First 3 uppercase letters of the name

Followed by the average temperature (as a whole number)

Followed by "WX"



Display the Weather Code and its length.



Bonus:



Validate that each temperature is between -20 and 50.





