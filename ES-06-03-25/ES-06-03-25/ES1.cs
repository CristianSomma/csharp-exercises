using static System.Console;

namespace ES_06_03_25
{
    internal class ES1
    {
        public static void es1()
        {
            Random random = new Random(Environment.TickCount);
            int arrayLenght;

            WriteLine("Benvenuto\nInserisci la quantità di numeri da generare:");
            Write("> ");

            while (!int.TryParse(ReadLine(), out arrayLenght))
            {
                WriteLine("ERRORE: Inserire un valore valido");
                Write("> ");
            }

            int[] randomNums = new int[arrayLenght];
            int[] occurancesCounter = new int[21];
            Array.Fill(occurancesCounter, 0);

            Write("Numeri Generati: ");
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = random.Next(0, 21);
                occurancesCounter[randomNums[i]]++;
                Write($" {randomNums[i]} |");
            }

            WriteLine($"\n{Array.IndexOf(occurancesCounter, occurancesCounter.Max())} è apparso {occurancesCounter.Max()} volte");

        }
    }
}
