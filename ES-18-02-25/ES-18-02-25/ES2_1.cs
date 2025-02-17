using static System.Console;

namespace ES_18_02_25
{
    internal class ES2_1
    {
        public static void AgentCode()
        {
            int userCode;
            WriteLine("WELCOME\nEnter your code:");
            Write("> ");
            while (!int.TryParse(ReadLine(), out userCode) || userCode < 0)
            {
                WriteLine("ERROR: Enter a valid code...");
                Write("> ");
            }

            int sum = 0, product = 1;
            foreach (char character in userCode.ToString())
            {
                int numChar = int.Parse(character.ToString());
                sum += numChar;
                product *= numChar;
            }

            if (sum % 3 == 0 && product % 2 == 0)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Your code is valid, welcome in, Agent.");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("YOUR CODE ISN'T VALID.");
            }
            ResetColor();
        }
    }
}