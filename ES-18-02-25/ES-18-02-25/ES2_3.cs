using static System.Console;

namespace ES_18_02_25
{
    internal class ES2_3
    {
        public static void MagicWord()
        {
            Clear();
            WriteLine("WELCOME\nEnter a word!");
            Write("> ");
            string word = ReadLine();
            while(string.IsNullOrEmpty(word))
            {
                WriteLine("ERROR: Enter a word, not a number...");
                Write("> ");
                word = ReadLine();
            }

            string vowels = "AEIOU";
            int vowelsNums = 0;
            bool isMagical = false;
            foreach (char character in word)
            {
                string sanitizedCharacter = character.ToString().ToUpper();
                if (vowels.IndexOf(sanitizedCharacter) != -1)
                {
                    vowelsNums++;
                    if (vowelsNums == 4)
                    {
                        isMagical = true;
                        break;
                    }
                }
            }

            if (isMagical)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("The word is magical!");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("The word isn't magical...");
            }

            ResetColor();
        }
    }
}
