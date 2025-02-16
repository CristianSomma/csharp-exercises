using static System.Console;

namespace ES_18_02_25
{
    internal class ES2
    {
        public static void AmicableNums()
        {
            Clear();
            WriteLine("WELCOME\nEnter the first bank account money amount:");
            int account1 = InputChecker();
            WriteLine("Enter the second (interconnected) bank account money amount:");
            int account2 = InputChecker();
            if(getDividersSum(account1) == account2 && getDividersSum(account2) == account1)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("The two bank accounts are financially safe.");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("The two bank accounts aren't financially safe!");
            }
            
            ResetColor();
            return;
        }

        static int InputChecker()
        {
            int input;
            Write("> ");
            while(!int.TryParse(ReadLine(), out input) || input < 0)
            {
                WriteLine("ERROR: Enter a valid amount...");
                Write("> ");
            }
            return input;
        }

        static int getDividersSum(int maxValue)
        {
            int sum = 1;
            for(int i = 2; i<maxValue; i++)
            {
                sum += maxValue % i == 0 ? i : 0;
            }
            return sum;
        }
    }
}
