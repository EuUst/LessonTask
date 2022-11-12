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
            
            GetChoseByContentAndPopulation(columns, fileLines, repositoryPath);

            GetCapitalsChoseByChar(columns, fileLines, repositoryPath);
        }

        public static void GetChoseByContentAndPopulation(string columns, string[] fileLines, string repositoryPath)
        {
            string continent = InputWork.GetContinentInput();
            string firstChooseName = InputWork.GetFileNameInput();

            List<string> sortedArray = ArraySorter.GetSortedArray(ArraySorter.GetArrayContinent(fileLines, continent)).ToList();
            
            InsertColumns(sortedArray, columns);
            FileCreator.CreateFile(firstChooseName, sortedArray.ToArray(), repositoryPath);

        }

        public static void GetCapitalsChoseByChar(string columns, string[] fileLines, string repositoryPath)
        {
            char inputLetter = InputWork.GetLetterInput();
            string chooseFileName = InputWork.GetFileNameInput();

            List<string> chosenRows = ChooseCountryByLetter(inputLetter, fileLines);

            chosenRows = ArraySorter.SortByAlphabet(chosenRows);

            InsertColumns(chosenRows, columns);
            FileCreator.CreateFile(chooseFileName, chosenRows.ToArray(), repositoryPath);
        }

        public static void InsertColumns(List<string> listToInsert, string columns)
        {
            listToInsert.Insert(0, columns);
        }

        public static List<string> ChooseCountryByLetter(char letter, string[] contriesFile)
        {
            List<string> chosenRows = new List<string>();

            for (int i = 1; i < contriesFile.Length; i++)
            {
                string[] elements = contriesFile[i].Split(";");
                if (elements[1].ToUpper().StartsWith(letter.ToString().ToUpper()))
                {
                    chosenRows.Add(contriesFile[i]);
                }
            }

            return chosenRows;
        }  
    }
}