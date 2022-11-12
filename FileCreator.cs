namespace LessonTask
{
    class FileCreator
    {
        public static void CreateFile(string nameFile, string[] allLines)
        {
            nameFile += ".txt";

            File.WriteAllLines(nameFile, allLines);
        }
    }
}
