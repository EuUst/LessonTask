namespace LessonTask
{
    class InputWork
    {
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
    }
}
