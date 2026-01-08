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
             //seed data
            owners[0] = "Sami";
            accounts[0] = "ACC0";
            balance[0] = 5000;
            LastAccountIndex++;

            owners[1] = "Sara";
            accounts[1] = "ACC1";
            balance[1] = 6000;
            LastAccountIndex++;

            bool exit = false;  
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

                        //input
                        Console.WriteLine("Enter account number: ");
                        string accountNumber = Console.ReadLine();
                        Console.WriteLine("Enter money amount: ");
                        double amount_deposit = double.Parse(Console.ReadLine());

                        //process
                        bool accountFound = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (accountNumber == accounts[i])
                            { 

                                balance[i] += amount_deposit;
                                accountFound = true;
                                break;

                            }
                        }

                        if (accountFound == false) 
                        {

                            Console.WriteLine("Account number not found.");

                        }
                        else
                        {
                            Console.WriteLine("Deposit money sussfully");
                           //send sms  

                        }

                        break;


                    case 3:

                        // withdraw money from ATM machine

                        Console.WriteLine("Enter account number :");
                        string accountNumber1 = Console.ReadLine();



                        bool AccountFound = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (accountNumber1 == accounts[i])
                            {
                                AccountFound = true;

                                Console.WriteLine("Enter the amount to withdraw :");
                                double amount = double.Parse(Console.ReadLine());


                                if (amount <= balance[i])
                                {
                                    balance[i] -= amount;
                                    Console.WriteLine("The remaining balance =" + balance[i]);

                                 
                                }

                                else 
                                {
                                    Console.WriteLine("amount insuffient");
                                }

                                break;
                            }

                        }

                        if (AccountFound == false)
                        {
                            Console.WriteLine("Sorry account number not found.");
                        }


                        else
                        {
                            Console.WriteLine("Please collect your cash");

                        }



                        break;

                    case 4:
                        //Check Balance of account
                        Console.WriteLine("Enter account number: ");
                        string account_number = Console.ReadLine();

                        bool IsAccountFound = false;
                        double AccBalance = 0;
                        for (int i = 0; i < 100; i++)
                        {
                            if (account_number == accounts[i])
                            {
                                IsAccountFound = true;
                                AccBalance = balance[i];
                                break;
                            }

                        }

                        if (IsAccountFound == false)
                        {

                            Console.WriteLine("Invalid account number");

                        }

                        else
                        {
                            Console.WriteLine("Account balance" + AccBalance);
                        }

                        break;

                    case 5:

                        // send money to other account
                        Console.WriteLine("Enter sender account number: ");
                        string SenderaccountNumber = Console.ReadLine();
                        Console.WriteLine("Enter reciever account number: ");
                        string RecieveraccountNumber = Console.ReadLine();


                  






                     break;


                    case 6:

                        exit = true;

                        break;


                    default:

                        Console.WriteLine("Invalid option.");

                        break;

                }


                if (exit == true)
                {
                    break;
                }


                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
