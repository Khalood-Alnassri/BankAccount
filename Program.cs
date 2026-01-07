namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system storage
            string[] owners = new string[100]; //account owners
            string[] accounts = new string[100]; // 100 accounts
            double[] balance = new double[100]; //account balance
            int LastAccountIndex = -1;

            while (true)
            {
                Console.WriteLine("Welcome to Bank system.");
                Console.WriteLine("Select the process you need: ");
                Console.WriteLine(" 1. Create new account.");
                Console.WriteLine(" 2. Deposit Money to account.");
                Console.WriteLine(" 3. Withdraw Money.");
                Console.WriteLine(" 4. Check Balance.");
                Console.WriteLine(" 5. Transfer Money.");
                Console.WriteLine(" 6. Exit.");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        //Phase2: input &  //Phase3: processing
                        Console.Write("Enter your name: ");
                        owners[LastAccountIndex + 1] = Console.ReadLine();
                        Console.Write("Enter initial deposit amount: ");
                        balance[LastAccountIndex + 1] = double.Parse(Console.ReadLine());
                        accounts[LastAccountIndex + 1] = "ACC" + (LastAccountIndex + 1); //processing order

                        //Phase4: output
                        Console.WriteLine("Account created successfully!");
                        Console.WriteLine("Account Number: " + accounts[LastAccountIndex + 1]);

                        LastAccountIndex++;

                    break;

                    case 2:
                        //Deposit Money to account
                        Console.WriteLine("Enter account number: ");
                        string accountNumber = Console.ReadLine();

                        if (accountNumber == accounts)
                        {
                            Console.WriteLine("Enter money amount: ");
                            double amount_deposit = double.Parse(Console.ReadLine());

                            balance += amount_deposit;

                            Console.WriteLine("your balance is =" + balance);
                            Console.WriteLine("reciept balance in your account.");
                          
                        }
                        else
                        {

                            Console.WriteLine("Account number not found.");

                        }

                        break;
                      

                    case 3:

                        // withdraw money from ATM machine

                        Console.WriteLine("Enter account number :");
                        string accountNumber1 = Console.ReadLine();

                        Console.WriteLine("Enter the amount to withdraw :");
                        double amount = double.Parse(Console.ReadLine());

                        if (accountNumber1 == accounts)
                        {
                            if (amount <= balance)
                            {
                                balance -= amount;
                                Console.WriteLine("The remaining balance =" + balance);
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

                    case 4:
                        //Check Balance of account
                        Console.WriteLine("Enter account number: ");
                        string account_number = Console.ReadLine();

                        if (account_number == accounts)
                        {
                            Console.WriteLine("your balance is = " + balance);
                        }

                        else
                        {
                            Console.WriteLine("Invalid account number");

                        }

                    break;

                    case 5:


                        // send money to other account
                        Console.WriteLine("Enter sender account number: ");
                        string SenderaccountNumber = Console.ReadLine();
                        Console.WriteLine("Enter reciever account number: ");
                        string RecieveraccountNumber = Console.ReadLine();


                        if (SenderaccountNumber == accounts && RecieveraccountNumber == accounts)
                        {
                            Console.WriteLine("Enter the amount to withdraw :");
                            double amount_send = double.Parse(Console.ReadLine());

                            if (amount_send <= balance)
                            {
                                balance -= amount_send;
                                balance += amount_send;
                                Console.WriteLine("The remaining balance =" + balance);
                                Console.WriteLine("The balance =" + balance);
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


                    case 6:


                    break;
                        


                    default:

                    break;

                }
            }
        }
    }
}
