using OTUS.HW6.Interfaces;
using System.Diagnostics;

namespace OTUS.HW6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string folderPath = @"C:\test";

            IFileReader fileReader = new FileReader();
            SpaceCounter spaceCounter = new SpaceCounter();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string[] files = Directory.GetFiles(folderPath, "*.txt");

            if (files.Length == 0)
            {
                Console.WriteLine($"В каталоге {folderPath} не найдены .txt файлы.");
                return;
            }

            Task<string>[] readTasks = files.Select(file => fileReader.ReadFileAsync(file)).ToArray();
            string[] contents = await Task.WhenAll(readTasks);

            int totalSpaces = contents.Sum(content => spaceCounter.CountSpaces(content));

            stopwatch.Stop();

            Console.WriteLine($"Всего пробелов: {totalSpaces}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
