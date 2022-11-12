using System;
using System.IO;

namespace LessonTask
{
    internal class FileCreator
    {
        public static void CreateFile(string firstLine)
        {
            Console.Write("Введите название файла: ");
            string name = Console.ReadLine();

            StreamWriter file = new StreamWriter(name + ".txt");
            file.Write(firstLine);
            file.Close();
        }
    }
}
