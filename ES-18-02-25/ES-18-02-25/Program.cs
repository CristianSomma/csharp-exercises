namespace ES_18_02_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome\nEnter the number of the program you want to execute:");
            Console.WriteLine("[1]. Bank transaction number\n[2]. Interconnected bank accounts\n[3]. Collatz sequence");
            Console.Write("> ");
            while(!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
            {
                Console.WriteLine("ERROR: Enter a valid number...");
                Console.Write("> ");
            }

            switch (choice)
            {
                case 1:
                    ES1.ArmstrongNum();
                    break;
                case 2:
                    ES2.AmicableNums();
                    break;
                case 3:
                    ES3.CollatzSequence();
                    break;
                default:
                    Console.WriteLine("OPS! Your number isn't attached to any program...");
                    break;
            }
        }
    }
}
