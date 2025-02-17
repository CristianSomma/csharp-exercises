using System;

namespace ES_18_02_25
{
    internal class ES1_5
    {
        public static void Craps(double inputBalance)
        {
            char command;
            double balance = inputBalance == 0 ? 1000 : inputBalance;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\tWELCOME IN CRAPS\n");
            Console.WriteLine("Enter:\t[B].\tBalance\n\t[P].\tPlay");
            Console.Write("> ");
            while (!char.TryParse(Console.ReadLine(), out command) || (Char.ToLower(command) != 'b' && Char.ToLower(command) != 'p'))
            {
                Console.WriteLine("ERROR:\nEnter either [B] or [P].");
                Console.Write("> ");
            }

            command = Char.ToLower(command);
            if (command == 'b')
            {
                showBalance(balance);
            }
            else if (command == 'p')
            {
                playCraps(balance);
            }

            static void playCraps(double balance)
            {
                double actualBet;

                Console.WriteLine("Enter the bet to play:");
                Console.Write("> ");
                while (!double.TryParse(Console.ReadLine(), out actualBet) || actualBet < 10 || actualBet > balance)
                {
                    Console.WriteLine($"WARNING:\nYou MUST enter a number which is at least 10$ and maximum {balance}$.");
                    Console.Write("> ");
                }
                throwDices(actualBet, balance);
            }
        }

        static void showBalance(double balance)
        {
            Console.WriteLine($"Your actual balance is:\n\t{balance}$\n");
            Console.WriteLine("Press anything to go back:");
            Console.WriteLine("> ");
            Console.ReadKey();
            Craps(balance);
        }

        static void throwDices(double bet, double balance)
        {
            int dicesResult;
            Random random = new Random();
            Console.WriteLine("Press any key to throw the dices...");
            Console.Write("> ");
            Console.ReadKey();
            Console.WriteLine("...");
            dicesResult = random.Next(1, 7) + random.Next(1, 7);
            Console.WriteLine($"Result: {dicesResult}.");
            switch (dicesResult)
            {
                case 7:
                case 11:
                    userWin(bet, balance);
                    break;
                case 2:
                case 3:
                case 12:
                    gameWin(bet, balance);
                    break;
                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                case 10:
                    points(bet, balance);
                    break;
            }

            static void userWin(double bet, double balance)
            {
                Console.WriteLine("You won!");
                balance += bet;
                showBalance(balance);
            }

            static void gameWin(double bet, double balance)
            {
                Console.WriteLine("You lost!");
                balance -= bet;
                showBalance(balance);
            }

            static void points(double bet, double balance)
            {
                throwDices(bet, balance);
            };

        }
    }
}
