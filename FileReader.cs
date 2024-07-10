using OTUS.HW6.Interfaces;

namespace OTUS.HW6;
public class FileReader : IFileReader
{
    public async Task<string> ReadFileAsync(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            return await reader.ReadToEndAsync();
        }
    }
}
