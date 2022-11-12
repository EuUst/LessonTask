using System.Reflection.PortableExecutable;

namespace LessonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Временно оставлю так, если что - потом на норм путь заменю. Для тестов сгодится.
            string[] contriesFile = File.ReadAllLines(@"C:\Users\79681\source\repos\LessonTask\countrey.txt");

            string columns = contriesFile[0];

            char inputLetter = GetLetterInput();

            List<string> chosenRows = ChooseCountryByLetter(inputLetter, contriesFile);
       
            foreach(string r in chosenRows)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine();
            chosenRows = SortByAlphabet(chosenRows);
            foreach(string r in chosenRows)
            {
                Console.WriteLine(r);
            }
        }

        public static char GetLetterInput()
        {
            while (true)
            {
                Console.WriteLine("Введите первую букву столи");
                string input = Console.ReadLine();

                if (char.TryParse(input, out char result) && Char.IsLetter(result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод символа.");
                }     
            }          
        }

        public static List<string> ChooseCountryByLetter(char letter, string[] contriesFile)
        {
            List<string> chosenRows = new List<string>();

            for (int i = 1; i < contriesFile.Length; i++)
            {
                string[] elements = contriesFile[i].Split(";");
                if (elements[1].ToLower().StartsWith(letter))
                {
                    chosenRows.Add(contriesFile[i]);
                }
            }

            return chosenRows;
        }

        public static List<string> SortByAlphabet(List<string> listToSort)
        {
            List<string> orderedList = listToSort.OrderBy(p => p).ToList();
            return orderedList;
        }
    }
}