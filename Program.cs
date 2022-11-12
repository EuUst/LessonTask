using System.Reflection.PortableExecutable;

namespace LessonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repositoryPath = Directory.GetCurrentDirectory().ToString() + "\\LessonTask";

            string[] fileLines = File.ReadAllLines(Path.Combine(repositoryPath, "countrey.txt"));
            string columns = fileLines[0];

            //1 выборка
            string continent = GetContinentInput();
            List<string> sortedArray = ArraySorter.GetSortedArray(ArraySorter.GetArrayContinent(fileLines, continent)).ToList();

            InsertColumns(sortedArray, columns);

            string firstChooseName = GetFileNameInput();

            FileCreator.CreateFile(firstChooseName, sortedArray.ToArray(), repositoryPath);

            //Вторая выборка
            char inputLetter = GetLetterInput();
            string secondChooseName = GetFileNameInput();

            List<string> chosenRows = ChooseCountryByLetter(inputLetter, fileLines);

            chosenRows = SortByAlphabet(chosenRows);
            InsertColumns(chosenRows, columns);

            FileCreator.CreateFile(secondChooseName, chosenRows.ToArray(), repositoryPath);
        }

        public static void InsertColumns(List<string> listToInsert, string columns)
        {
            listToInsert.Insert(0, columns);
        }

        public static string GetFileNameInput()
        {
            Console.WriteLine("Введите нащвание файла, куда бы хотели записать результат выборки");
            string fileName = Console.ReadLine();
            return fileName;
        }

        public static string GetContinentInput()
        {
            while (true)
            {
                Console.WriteLine("Введите континент");
                string country = Console.ReadLine();

                for (int i = 0; i < country.Length; i++)
                {
                    if (!Char.IsLetter(country[i]))
                    {
                        Console.WriteLine("Некорректный континет!!");
                        break;
                    }
                    else
                    {
                        return country;
                    }                
                }
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