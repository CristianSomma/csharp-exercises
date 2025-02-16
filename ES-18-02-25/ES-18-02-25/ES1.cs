using static System.Console;

namespace ES_18_02_25
{
    internal class ES1
    {
        public static void ArmstrongNum()
        {
            int userCode;
            Clear();
            WriteLine("WELCOME\nEnter your transaction code:");
            Write("> ");

            while(!int.TryParse(ReadLine(), out userCode) || userCode < 0)
            {
                WriteLine("ERROR: Enter a valid code...");
                Write("> ");
            }

            int codeLength = userCode.ToString().Length;
            int sum = 0;
            foreach(char digit in userCode.ToString())
            {
                sum += (int)Math.Pow(digit - 48, codeLength);
            }
            
            if(sum != userCode)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Your code isn't valid.");
            }
            else
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Your code is valid, the transaction was succesful.");
            }

            ResetColor();
            return;
        }
    }
}
