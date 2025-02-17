using System;

namespace ES_18_02_25
{
    internal class ES1_2
    {
        public static void guessTheNumber()
        {
            int chosenDifficulty, times;
            Console.WriteLine("BENVENUTO!");
            Console.WriteLine("Inserire il numero corrispondente alla difficoltà scelta:");
            Console.WriteLine("1).\tFacile\n2).\tMedia\n3).\tDifficile");
            Console.Write("> ");
            while (!int.TryParse(Console.ReadLine(), out chosenDifficulty) || chosenDifficulty <= 0 || chosenDifficulty > 3)
            {
                Console.WriteLine("ERRORE: Inserire un numero tra 1 e 3...");
                Console.Write("> ");
            };

            Console.WriteLine("Inserire il numero di tentativi per partita:");
            Console.Write("> ");

            while (!int.TryParse(Console.ReadLine(), out times) || times <= 0)
            {
                Console.WriteLine("ERRORE: Inserire un numero maggiore di zero...");
                Console.Write("> ");
            };

            int maxRandomNum = 5;
            switch (chosenDifficulty)
            {
                case 1:
                    maxRandomNum = 5;
                    break;
                case 2:
                    maxRandomNum = 10;
                    break;
                case 3:
                    maxRandomNum = 20;
                    break;
            }

            int randomNumber = new Random().Next(1, maxRandomNum + 1);
            int userNumber;
            bool isNumGuessed = false;

            Console.WriteLine("Prova a indovinare il numero!");
            Console.WriteLine($"[Valore compreso tra 1 e {maxRandomNum}].");

            do
            {
                times--;
                Console.Write("> ");
                while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 0 || userNumber > maxRandomNum)
                {
                    Console.WriteLine($"ERRORE: Inserire un numero compreso tra 1 e {maxRandomNum}...");
                    Console.Write("> ");
                };
                if (userNumber != randomNumber)
                {
                    if (userNumber < randomNumber)
                    {
                        Console.WriteLine($"Il numero inserito è maggiore, hai ancora {times} tentativi"); ;

                    }
                    else
                    {
                        Console.WriteLine($"Il numero inserito è minore, hai ancora {times} tentativi"); ;

                    }

                }
                else
                {
                    isNumGuessed = true;
                }
            } while (!isNumGuessed && times > 0);

            if (times < 0)
            {
                Console.WriteLine("Hai terminato i tentativi, GAME OVER! :(");
            }

            Console.WriteLine($"Hai indovinato il numero! I tentativi rimanenti erano {times}!");
        }
    }
}