namespace LessonTask
{
    class ArraySorter
    {
        public static string[][] GetContitentArray(string[] array, string continent)
        {
            var list = new List<string[]>();
            foreach (string line in array)
            {
                string[] props = line.Split(';');
                if (props[4] == continent) list.Add(props);
            }

            return list.ToArray();
        }

        public static string[] SortByContinent(string[][] linesOfProps)
        {
            var sortedArray = new List<string>();
            for (int i = 0; i < linesOfProps.Length; i++)
            {
                int min = 2000000000;
                int index = 0;

                for (int j = 0; j < linesOfProps.Length; j++)
                {
                    int population = Convert.ToInt32(linesOfProps[j][3]);
                    if (population < min)
                    {
                        min = population;
                        index = j;
                    }

                    if (j == linesOfProps.Length - 1) sortedArray.Add(String.Join(';', linesOfProps[index]));
                }

                linesOfProps[index][3] = "2000000000";
            }

            return sortedArray.ToArray();
        }

        public static List<string> SortByAlphabet(List<string> listToSort)
        {
            List<string> orderedList = listToSort.OrderBy(p => p).ToList();
            return orderedList;
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
