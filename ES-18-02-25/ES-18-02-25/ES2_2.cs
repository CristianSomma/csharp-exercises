using static System.Console;

namespace ES_18_02_25
{
    internal class ES2_2
    {
        public static void RobotPath()
        {
            int path;
            string pathStr;
            Clear();
            WriteLine("WELCOME\nEnter the path:");
            Write("> ");
            while (!int.TryParse(ReadLine(), out path) || path < 0)
            {
                WriteLine("Enter a valid path (Are allowed only numbers)...");
                Write("> ");
            }

            pathStr = path.ToString();

            int pastNum = (int)pathStr[1];
            bool isSafe = true;
            bool isPastBigger = (int)pathStr[0] < pastNum ? false : true; 
            for (int i = 2; i < pathStr.Length; i++)
            {
                if((pastNum > (int)pathStr[i]) == !isPastBigger)
                {
                    pastNum = (int)pathStr[i];
                    isPastBigger = !isPastBigger;
                }
                else
                {
                    isSafe = false;
                    break;
                }
            }

            if (isSafe)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("The path is safe!");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("The path isn't safe!");
            }

            ResetColor();
        }
    }
}