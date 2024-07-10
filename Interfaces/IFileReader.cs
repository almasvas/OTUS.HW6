namespace OTUS.HW6.Interfaces
{
    public interface IFileReader
    {
        Task<string> ReadFileAsync(string filePath);
    }
}
