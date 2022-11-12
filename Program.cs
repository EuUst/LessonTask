using System.Reflection.PortableExecutable;

namespace LessonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "First Line", "Second Line" };
            FileCreator.CreateFile(array);
        }
    }
}