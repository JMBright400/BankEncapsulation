namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine(@"########     ###    ##    ## ##    ##       ###    ########  ########  ");
            Console.WriteLine(@"##     ##   ## ##   ###   ## ##   ##       ## ##   ##     ## ##     ## ");
;           Console.WriteLine(@"##     ##  ##   ##  ####  ## ##  ##       ##   ##  ##     ## ##     ## ");
            Console.WriteLine(@"########  ##     ## ## ## ## #####       ##     ## ########  ########  ");
            Console.WriteLine(@"##     ## ######### ##  #### ##  ##      ######### ##        ##        ");
            Console.WriteLine(@"##     ## ##     ## ##   ### ##   ##     ##     ## ##        ##        ");
            Console.WriteLine(@"########  ##     ## ##    ## ##    ##    ##     ## ##        ##        ");

            while(true) 
            {
                Console.WriteLine("\n\nPlease make a selection:");
                Console.WriteLine("1. Make a deposit.");
                Console.WriteLine("2. Check account balance.");
                Console.WriteLine("3. Exit.");

                int choice;
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid entry. Please select a valid entry.");
                    continue;
                }

                switch(choice) 
                {
                    case 1:
                        Console.WriteLine("Please enter the amount you would like to deposit:");
                        double amount;
                        if(!double.TryParse(Console.ReadLine(),out amount))
                        {
                            Console.WriteLine("Invalid input. Enter a valid amount.");
                            continue;
                        }

                        account.Deposit(amount);
                        Console.WriteLine("Transaction complete.");
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: {account.GetBalance()}");
                        break;
                    case 3:
                        Console.WriteLine("Thank you, and have a super wonderful day!");
                        return;
                    default:
                        Console.WriteLine("Invalid entry. Please select a valid entry.");
                        break;
                }
            }

        }
    }
}
