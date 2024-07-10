namespace OTUS.HW6
{
    public class SpaceCounter
    {
        public int CountSpaces(string content)
        {
            return content.Count(c => c == ' ');
        }
    }
}
