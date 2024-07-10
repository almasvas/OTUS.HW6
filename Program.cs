using OTUS.HW6.Interfaces;
using System.Diagnostics;

namespace OTUS.HW6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string folderPath = "TestFiles";            

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            IFileProcessor fileProcessor = new FileProcessor();
            var totalSpaces = await fileProcessor.CountSpacesInFolder(folderPath);

            stopwatch.Stop();

            Console.WriteLine($"Всего пробелов: {totalSpaces}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
