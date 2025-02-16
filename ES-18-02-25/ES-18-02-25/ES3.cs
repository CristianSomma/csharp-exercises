using static System.Console;

namespace ES_18_02_25
{
    internal class ES3
    {
        public static void CollatzSequence()
        {
            int num;
            Clear();
            WriteLine("WELCOME\nEnter a number:");
            Write("> ");
            while(!int.TryParse(ReadLine(), out num) || num <= 1)
            {
                WriteLine("ERROR: Enter a valid value");
                Write("> ");
            }

            Write($"{num} ");

            while(num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num = num * 3 + 1;
                }
                Write($"-> {num} ");
            }
            
            return;
        }
    }
}
