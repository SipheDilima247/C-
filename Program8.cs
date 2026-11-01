using System.Security.Principal;

namespace task8Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- SIMPLE BANK ACCOUNT SIMULATOR ----------//

            //1. Ask the user for the name
            Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            //2. Ask the user for their current balance
            Console.WriteLine("Please write your current balance: ");
            double currentBalance = Convert.ToDouble(Console.ReadLine());

            //3. Ask the user to choose a transaction type: 1 = deposit, 2 = withdraw, 3 = Checkbalance
            Console.WriteLine("Choose a transaction: \n1. Deposit\n2.Withdraw\n3.Check Balance");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //4. Ask how much they want to deposit
                    Console.WriteLine("How much do ou want to deposit: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    currentBalance = currentBalance + depositAmount;
                    break;

                case 2:
                    //4 Ask how much they want to withdraw
                    Console.WriteLine("How much do you want to Withdraw: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                    if (withdrawAmount > currentBalance)
                    {
                        Console.WriteLine("Cannot withdraw more than you have in account!");
                    }

                    else
                    {
                        currentBalance = currentBalance - withdrawAmount;
                    }
                    break;

                case 3:
                    Console.WriteLine("Balance: " + currentBalance);
                    break;

            }

            //6. Generate a random transaction ID between 1000-9999
            Random random = new Random();
            int transactionId = random.Next(1000, 10000);
            String digits = Convert.ToString(transactionId);
            digits = digits.Substring(2, 2);

            //8. Create a Account code using string methods
            String accountCode = name.ToUpper();
            accountCode = accountCode.Substring(0, 4);
            accountCode = accountCode + digits;

            Console.WriteLine("Transaction: " + transactionId);
            Console.WriteLine("Balance: " + currentBalance);
            Console.WriteLine("Account Code: " + accountCode);
        }
    }
}
