namespace ES_18_02_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome\nEnter the number of the program you want to execute:");
            Console.WriteLine("[1]. Bank transaction number\n" +
                "[2]. Interconnected bank accounts\n" +
                "[3]. Collatz sequence\n" +
                "[4]. Something");
            Console.Write("> ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
            {
                Console.WriteLine("ERROR: Enter a valid number...");
                Console.Write("> ");
            }


            switch (choice)
            {
                case 1:
                    ES3_1.ArmstrongNum();
                    break;
                case 2:
                    ES3_2.AmicableNums();
                    break;
                case 3:
                    ES3_3.CollatzSequence();
                    break;
                case 4:
                    ES2_1.AgentCode();
                    break;
                case 5:
                    ES2_2.RobotPath();
                    break;
                case 6:
                    ES2_3.MagicWord();
                    break;
                case 7:
                    ES3_4.NumsPyramid();
                    break;
                case 8:
                    ES1_2.guessTheNumber();
                    break;
                case 9:
                    ES1_5.Craps(0);
                    break;
                default:
                    Console.WriteLine("OPS! Your number isn't attached to any program...");
                    break;
            }
        }
    }
}