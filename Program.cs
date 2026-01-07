namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string storedAccountNumber = "Saving 12053446";
            int storedBalance = 5000;
            string storedAccountNumber2 = "Saving 43368923";
            int storedBalance2 = 8000;
            
            int option = int.Parse(Console.ReadLine());
            switch (option)
            { 
                case 1:
            // withdraw money from ATM machine
            Console.WriteLine("Enter the amount to withdraw :");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter account number :");
            string accountNumber = Console.ReadLine();

            if (accountNumber == storedAccountNumber)
            {
                if (amount >= storedBalance)
                {
                    storedBalance -= amount;
                    Console.WriteLine("The remaining balance =" + storedBalance);
                    Console.WriteLine("Please collect your cash");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }

            else
            {
                Console.WriteLine("Invalid account number.");
            }
                    break;

                    case 2:
            // send money to other account
            Console.WriteLine("Enter sender account number: ");
            string SenderaccountNumber = Console.ReadLine();
            Console.WriteLine("Enter reciever account number: ");
            string RecieveraccountNumber = Console.ReadLine();

            if (SenderaccountNumber == storedAccountNumber && RecieveraccountNumber == storedAccountNumber2)
            {
                Console.WriteLine("Enter the amount to withdraw :");
                int amount_send = int.Parse(Console.ReadLine());

                if (amount_send >= storedBalance)
                {
                            storedBalance -= amount_send;
                            storedBalance2 += amount_send;
                            Console.WriteLine("The remaining balance =" + storedBalance);
                            Console.WriteLine("The balance =" + storedBalance2);
                            Console.WriteLine("The amount has been transferred");

                }

                else
                {
                    Console.WriteLine("Sorry refused");
                }
            }
            else
            {
                Console.WriteLine("Account number not found.");
            }
            break;
        }
        }
    }
}
