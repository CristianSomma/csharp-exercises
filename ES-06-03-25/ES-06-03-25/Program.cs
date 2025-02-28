using static System.Console;

namespace ES_06_03_25
{
    internal class Program
    {
        static void Main(string[] args)
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

            for(int i = 0;  i < arrayLenght; i++)
            {
                randomNums[i] = random.Next(101);
            }

            int[] firstHalf = Sort(Split(randomNums, 0, arrayLenght / 2), false);
            int[] secondHalf = Sort(Split(randomNums, arrayLenght/2, arrayLenght), true);

            Write("\nArray completo: ");
            PrintArray(randomNums);

            Write("\nPrima metà dell'array ordinato: ");
            PrintArray(firstHalf);

            Write("\nSeconda metà dell'array in ordine inverso: ");
            PrintArray(secondHalf);
        }

        static int[] Split(int[] array, int startingValue, int endValue)
        {
            int[] splittedArray = new int[endValue-startingValue];
            int counter = 0;

            for(int i = startingValue; i<endValue; i++)
            {
                splittedArray[counter] = array[i];
                counter++;
            }

            return splittedArray;
        }
        
        static int[] Sort(int[] array, bool isIncreasing)
        {
            int[] processedArray = new int[array.Length];
            int lastElement = array[0];
            processedArray[0] = lastElement;
            for (int i = 1; i < array.Length; i++)
            {
                processedArray[i] = array[i];
                if (array[i] > lastElement)
                {
                    processedArray[i - 1] = array[i];
                    processedArray[i] = lastElement;
                }
            }

            if (isIncreasing)
                Array.Reverse(processedArray);

            return processedArray;
        }

        static void PrintArray(int[] array)
        {
            foreach(int element in array)
            {
                Write($"{element} - ");
            }
        }
    }
}