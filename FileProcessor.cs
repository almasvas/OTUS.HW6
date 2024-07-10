using OTUS.HW6.Interfaces;

namespace OTUS.HW6
{
    public class FileProcessor : IFileProcessor
    {
        public async Task<int> CountSpacesInFolder(string path)
        {
            string[] files = Directory.GetFiles(path, "*.txt");

            if (files.Length == 0)
            {
                throw new FileNotFoundException($"В каталоге {path} не найдены .txt файлы.");
            }

            Task<int>[] readTasks = files.Select(async file => {
                var content = await new FileReader().ReadFileAsync(file);
                return SpaceCounter.CountSpaces(content);
            }).ToArray();

            int[] results = await Task.WhenAll(readTasks);
            return results.Sum();
        }
    }
}
