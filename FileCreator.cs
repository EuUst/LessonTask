using System;
using System.IO;

namespace LessonTask
{
    internal class FileCreator
    {
        public static void CreateFile(string[] allLines)
        {
            Console.Write("Введите название файла: ");
            string nameFile = Console.ReadLine();
            nameFile += ".txt";

            File.WriteAllLines(nameFile, allLines);
        }
    }
}
