namespace LessonTask
{
    class FileCreator
    {
        public static void CreateFile(string nameFile, string[] allLines, string path)
        {
            nameFile += ".txt";
            path = Path.Combine(path, nameFile);

            File.WriteAllLines(path, allLines);
        }
    }
}
