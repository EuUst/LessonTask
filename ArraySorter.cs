namespace LessonTask
{
    class ArraySorter
    {
        public static string[][] GetArrayContinent(string[] array, string continent)
        {
            var list = new List<string[]>();
            foreach (string line in array)
            {
                string[] props = line.Split(';');
                if (props[4] == continent) list.Add(props);
            }

            return list.ToArray();
        }

        public static string[] GetSortedArray(string[][] linesOfProps)
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
    }
}
