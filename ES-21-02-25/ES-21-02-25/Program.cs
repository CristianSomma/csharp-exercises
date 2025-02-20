using static System.Console;

namespace ES_21_02_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            WriteLine("Benvenuto!");
            WriteLine("Inserire il numero corrispondente al programma da eseguire:"); ;
            Write("> ");

            while(!int.TryParse(ReadLine(), out choice) || choice < 0)
            {
                WriteLine("Inserire un valore valido...");
                Write("> ");
            }

            if (choice == 1)
                Es1Func();

            if (choice == 2)
                ES2Func();
        }

        static void Es1Func()
        {
            Clear();
            int inputLength;
            WriteLine("Benvenuto\nInserisci il numeri di numeri che inserirai:");
            Write("> ");
            while(!int.TryParse(ReadLine(), out inputLength) || inputLength < 1){
                WriteLine("Inserire un valore valido...");
                Write("> ");
            }

            int[] nums = new int[inputLength];
            bool isAllDifferent = true;
            for(int i = 0; i < nums.Length; i++)
            {
                int inputNum;
                Write($"{i+1}. > ");
                while (!int.TryParse(ReadLine(), out inputNum))
                {
                    WriteLine("Inserire un valore valido...");
                    Write($"{i+1}. > ");
                }

                if (nums.Contains(inputNum))
                {
                    isAllDifferent = false;
                    break;
                }

                nums[i] = inputNum;
            }

            if (isAllDifferent)
            {
                WriteLine("Result: 1");
            }
            else
            {
                WriteLine("Result: 0");
            }
        }

        static void ES2Func()
        {
            int[] nums = new int[30];
            Random random = new Random();
            string test = "";

            Write("Lista di tutti i 30 numeri: ");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 101);
                Write(nums[i] + " ");
            }

            WriteLine("\nCoppie trovate:");
            foreach(int num in nums)
            {
                if (num % 2 == 0 && num != 0)
                {
                    int halfIndex = Array.IndexOf(nums, num / 2);
                    if (halfIndex != -1)
                    {
                        Write($"{num / 2}-{num} / ");
                        nums[halfIndex] = 0;
                    }
                }
            }
        }
    }
}
