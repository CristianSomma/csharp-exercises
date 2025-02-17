using static System.Console;
using System.Linq;

namespace ES_18_02_25
{
    internal class ES3_4
    {
        public static void NumsPyramid()
        {
            int height;
            Clear();
            WriteLine("WELCOME\nEnter the height of the pyramid:");
            Write("> ");

            while(!int.TryParse(ReadLine(), out height) || height < 1)
            {
                WriteLine("ERROR: Enter a valid value...");
                Write("> ");
            }

            string result = $"{calculateSpaces(height, 1)}1", halfLayer;
            string spaces;
            int maxValue = 2;
            for (int i = 1; i < height; i++)
            {
                result += "\n";
                halfLayer = "";
                spaces = calculateSpaces(height, maxValue);
                
                
                
                halfLayer += spaces;

                for (int j = 1; j < maxValue; j++)
                {
                    halfLayer += j;
                }

                result += $"{halfLayer}{maxValue}";
                result += new String(halfLayer.Reverse().ToArray());
                maxValue++;
            }
            WriteLine(result);
        }

        static string calculateSpaces(int height, int maxValue)
        {
            string spaces = "";
            for (int i = 0; i < height - maxValue; i++)
            {
                spaces += " ";
            }

            return spaces;
        }
    }
}
